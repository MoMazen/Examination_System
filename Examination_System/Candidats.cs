using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examination_System
{
    
    public partial class Candidats : Form
    {

        private int id = -1;
        public Candidats()
        {
            InitializeComponent();
            DisplayCandidates();
        }
       
        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            PasswordTb.Text = "";

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL - WSEF\Documents\QuizDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayCandidates()
        {
            conn.Open();
            string Query = "select * from CandidateTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
           
            dataGridView1.DataSource= ds.Tables[0].DefaultView;
           
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (CNameTb.Text == "" || CAgeTb.Text == "" || AddressTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int scoure =0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into candidateTbl (CName,CAge,CPass,CScore,CAdd,CPhone) values (@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)",conn);
                    cmd.Parameters.AddWithValue("@Cn",CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs",scoure);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Saved");

                    conn.Close();
                    DisplayCandidates();
                    Reset();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CNameTb.Text =dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //CNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //CNameTb.Text =dataGridView1.SelectedRows[key].Cells[1].Value.ToString();
           
            //CNameTb.Text =(++key).ToString();
            //CAgeTb.Text=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //PasswordTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //AddressTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //PhoneTb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                CNameTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                CAgeTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                PasswordTb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                AddressTb.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                PhoneTb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || AddressTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                  
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update CandidateTbl set  CName=@Cn,CAge=@Ca,CPass=@Cp,CAdd=@Cad,CPhone=@Cph where Cid=@CKey ", conn);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);

                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    if (id > -1)
                    {
                        cmd.Parameters.AddWithValue("@CKey", id);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated");

                    conn.Close();
                    DisplayCandidates();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            Questions obj = new Questions();
            obj.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        //private void dataGridView1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
