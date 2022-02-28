using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity.Core.Objects;

namespace Examination_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel5.BackColor = Color.White;
            txtEmail.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter The Email and Password");
            }
            else
            {
                ObjectResult<LoginProcedure_Result> user = null;
                try
                {
                    user = Program.dbEntity.LoginProcedure(txtEmail.Text, txtPassword.Text);
                }catch (Exception ex)
                {
                    MessageBox.Show("Please make sure your connection is stable.");
                    return;
                }

                foreach (var result in user)
                {
                    Program.userData = result;
                }

                if (Program.userData == null)
                {
                    MessageBox.Show("Please Enter valid Email and Password");
                }
                else
                {
                    this.Hide();
                    if(Program.userData.UserType == "student")
                    {
                        StudentLandPage studentLandPage = new StudentLandPage();
                        studentLandPage.ShowDialog();
                    }
                    this.Show();
                }

            }
        }
    }
}