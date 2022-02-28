using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            //MyProgress.Value = count;
            PrecentageLbl.Text = counter + "%";

            if (counter == 100)
            {
                //MyProgress.Value = 0;
                timer1.Enabled = false;
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
