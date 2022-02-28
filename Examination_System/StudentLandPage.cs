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
    public partial class StudentLandPage : Form
    {
        public StudentLandPage()
        {
            InitializeComponent();
            this.getStudentGradesTableAdapter.Fill(this.iTIDBProjectDataSet.GetStudentGrades, Program.userData.ID);
            lblStdName.Text = Program.userData.FirstName + " " + Program.userData.LastName;
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            chooseSubject chooseSubject = new chooseSubject();
            chooseSubject.ShowDialog();
        }
    }
}
