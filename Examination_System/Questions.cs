using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Questions : Form
    {
        private int id = -1;
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL - WSEF\Documents\QuizDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetSubjects()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl",conn);
            SqlDataReader rdr;
            rdr= cmd.ExecuteReader();   
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            conn.Close();
        }
        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;
        }
        private void DisplayQuestions()
        {
            conn.Open();
            string Query = "select * from QuestionTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int scoure = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionTbl (QDesc,QO1,QO2,QO3,QO4,QA,QS) values (@Qd,@O1,@O2,@O3,@O4,@Qan,@Qsu)", conn);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Saved");

                    conn.Close();
                    DisplayQuestions();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                                                                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update QuestionTbl set  QDesc=@Qd,QO1=@O1,QO2=@O2,QO3=@O3,QO4=@O4,QA=@Qan,QS=@Qsu where Qid=@CKey ", conn);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());

                    if (id > -1)
                    {
                        cmd.Parameters.AddWithValue("@CKey", id);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Updated");

                    conn.Close();
                    DisplayQuestions();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                QuestTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Op1Tb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Op2Tb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Op3Tb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Op4Tb.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                AnswerTb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                SubjectCb.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidats obj = new Candidats();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Exams obj = new Exams(1);
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
