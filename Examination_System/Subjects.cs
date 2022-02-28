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
    public partial class Subjects : Form
    {
        private int id = -1;
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            key = 0;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL - WSEF\Documents\QuizDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplaySubjects()
        {
            conn.Open();
            string Query = "select * from SubjectTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl (SName) values (@Sn)", conn);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");

                    conn.Close();
                    DisplaySubjects();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                SNameTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {


                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update SubjectTbl set  SName=@Sn where Sid=@CKey ", conn);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    
                    if (id > -1)
                    {
                        cmd.Parameters.AddWithValue("@CKey", id);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");

                    conn.Close();
                   DisplaySubjects();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidats obj = new Candidats();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Exams obj = new Exams(1);
            obj.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidats obj = new Candidats();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }
    }
}
