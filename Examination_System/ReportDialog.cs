using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class ReportDialog : Form
    {

        public int reportNo;
        public string lblText;

        public ReportDialog()
        {
            InitializeComponent();
        }

        private void chooseSubject_Load(object sender, EventArgs e)
        {
            label1.Text = lblText;
            if(reportNo == 6)
            {
                text2.Visible = true;
                label2.Visible = true;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int id1 = -1;
            int id2 = -1;
            if (text1.Text == "" || !(int.TryParse(text1.Text, out id1)) || (text2.Visible && (text2.Text == "" || !(int.TryParse(text2.Text, out id2)))))
            {
                MessageBox.Show("Please enter a valid number", "Alert");
                return;
            }
            if(id1 <= 0 || (text2.Visible && id2 <= 0))
            {
                MessageBox.Show("Please enter a valid number", "Alert");
                return;
            }
            AllReports report = new AllReports();
            switch (reportNo)
            {
                case 1:
                    report.Report1(id1);
                    break;
                case 2:
                    report.Report2(id1);
                    break;
                case 3:
                    report.Report3(id1);
                    break;
                case 4:
                    report.Report4(id1);
                    break;
                case 5:
                    report.Report5(id1);
                    break;
                case 6:
                    report.Report6(id1,id2);
                    break;
            }
            this.Close();
        }
    }
}
