using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class AllReports : Form
    {
        private SaveFileDialog sfd;
        private void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            try
            {
                using (FileStream stream = new FileStream(savePath, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This file can't be modified right now");
                return;
            }
        }

        public AllReports()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            ////Fill dataSource of report1
            //GetStudentsInDepartment_ResultBindingSource.DataSource = Program.dbEntity.GetStudentsInDepartment(1);
            //// Fill dataSource of report2
            //GetStudentGrades_ResultBindingSource.DataSource = Program.dbEntity.GetStudentGrades(1);
            //// Fill dataSource of report3
            //GetInsCoursesAndStudents_ResultBindingSource.DataSource = Program.dbEntity.GetInsCoursesAndStudents(20);
            //// Fill dataSource of report4
            //GetCourseTopics_ResultBindingSource.DataSource = Program.dbEntity.GetCourseTopics(1);
            //// Fill dataSource of report5
            //GetCourseTopics_ResultBindingSource.DataSource = Program.dbEntity.GetExamQuestions(96);
            //// Fill dataSource of report6
            //GetStudentAnswers_ResultBindingSource.DataSource = Program.dbEntity.GetStudentAnswers(1, 1);

            //this.reportViewer5.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.reportViewer4.RefreshReport();
            //this.reportViewer6.RefreshReport();
        }

        public void Report1(int dept_id)
        {
            // Fill dataSource of report1
            GetStudentsInDepartment_ResultBindingSource.DataSource = Program.dbEntity.GetStudentsInDepartment(dept_id);
            this.reportViewer1.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer1, sfd.FileName);
            }
        }

        public void Report2(int student_id)
        {
            // Fill dataSource of report2
            GetStudentGrades_ResultBindingSource.DataSource = Program.dbEntity.GetStudentGrades(student_id);
            this.reportViewer2.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer2, sfd.FileName);
            }
        }
        public void Report3(int instructor_id)
        {
            // Fill dataSource of report3
            GetInsCoursesAndStudents_ResultBindingSource.DataSource = Program.dbEntity.GetInsCoursesAndStudents(instructor_id);

            this.reportViewer3.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer3, sfd.FileName);
            }
        }
        public void Report4(int course_id)
        {
            // Fill dataSource of report4
            GetCourseTopics_ResultBindingSource.DataSource = Program.dbEntity.GetCourseTopics(course_id);
            this.reportViewer4.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer4, sfd.FileName);
            }
        }
        public void Report5(int exam_id)
        {
            // Fill dataSource of report5
            GetExamQuestions_ResultBindingSource.DataSource = Program.dbEntity.GetExamQuestions(exam_id);
            this.reportViewer5.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer5, sfd.FileName);
            }
        }
        public void Report6(int exam_id, int student_id)
        {
            // Fill dataSource of report6
            GetStudentAnswers_ResultBindingSource.DataSource = Program.dbEntity.GetStudentAnswers(student_id, exam_id);
            this.reportViewer6.RefreshReport();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePDF(this.reportViewer6, sfd.FileName);
            }
        }

    }
}
