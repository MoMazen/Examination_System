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
    
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            DisplayCandidates();
        }

        private void DisplayCandidates()
        {
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void OpenReportDialog(int reportNo, string lblText)
        {
            ReportDialog obj = new ReportDialog();
            obj.reportNo = reportNo;
            obj.lblText = lblText;
            obj.ShowDialog();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            OpenReportDialog(1, "Please Enter Department id:");
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            OpenReportDialog(2, "Please Enter Student id:");
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            OpenReportDialog(3, "Please Enter Instructor id:");
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            OpenReportDialog(4, "Please Enter Course id:");
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            OpenReportDialog(5, "Please Enter Exam id:");
        }

        private void btnReport6_Click(object sender, EventArgs e)
        {
            OpenReportDialog(6, "Please Enter Exam id:");
        }
    }
}
