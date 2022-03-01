namespace Examination_System
{
    partial class AllReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetExamQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetStudentAnswers_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetCourseTopics_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetInsCoursesAndStudents_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetStudentGrades_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetStudentsInDepartment_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetExamQuestions_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetExamQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentAnswers_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCourseTopics_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInsCoursesAndStudents_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentGrades_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentsInDepartment_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetExamQuestions_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetStudentsInDepartment_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Examination_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(189, 370);
            this.reportViewer1.TabIndex = 15;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.GetStudentGrades_ResultBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Examination_System.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(213, 119);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(189, 370);
            this.reportViewer2.TabIndex = 16;
            // 
            // reportViewer3
            // 
            reportDataSource4.Name = "DataSet3";
            reportDataSource4.Value = this.GetInsCoursesAndStudents_ResultBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Examination_System.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(409, 119);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(188, 370);
            this.reportViewer3.TabIndex = 17;
            // 
            // reportViewer4
            // 
            reportDataSource5.Name = "DataSet4";
            reportDataSource5.Value = this.GetCourseTopics_ResultBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Examination_System.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(604, 119);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(188, 370);
            this.reportViewer4.TabIndex = 18;
            // 
            // reportViewer5
            // 
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.GetExamQuestions_ResultBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Examination_System.Report5.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(798, 119);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(189, 370);
            this.reportViewer5.TabIndex = 14;
            // 
            // reportViewer6
            // 
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.GetStudentAnswers_ResultBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Examination_System.Report6.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(993, 119);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(189, 370);
            this.reportViewer6.TabIndex = 19;
            // 
            // GetExamQuestionsBindingSource
            // 
            this.GetExamQuestionsBindingSource.DataMember = "GetExamQuestions";
            // 
            // GetStudentAnswers_ResultBindingSource
            // 
            this.GetStudentAnswers_ResultBindingSource.DataSource = typeof(Examination_System.GetStudentAnswers_Result);
            // 
            // GetCourseTopics_ResultBindingSource
            // 
            this.GetCourseTopics_ResultBindingSource.DataSource = typeof(Examination_System.GetCourseTopics_Result);
            // 
            // GetInsCoursesAndStudents_ResultBindingSource
            // 
            this.GetInsCoursesAndStudents_ResultBindingSource.DataSource = typeof(Examination_System.GetInsCoursesAndStudents_Result);
            // 
            // GetStudentGrades_ResultBindingSource
            // 
            this.GetStudentGrades_ResultBindingSource.DataSource = typeof(Examination_System.GetStudentGrades_Result);
            // 
            // GetStudentsInDepartment_ResultBindingSource
            // 
            this.GetStudentsInDepartment_ResultBindingSource.DataSource = typeof(Examination_System.GetStudentsInDepartment_Result);
            // 
            // GetExamQuestions_ResultBindingSource
            // 
            this.GetExamQuestions_ResultBindingSource.DataSource = typeof(Examination_System.GetExamQuestions_Result);
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 567);
            this.Controls.Add(this.reportViewer6);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.reportViewer5);
            this.Name = "AllReports";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetExamQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentAnswers_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCourseTopics_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInsCoursesAndStudents_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentGrades_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudentsInDepartment_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetExamQuestions_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource GetExamQuestionsBindingSource;
        //private ITIDBProjectDataSet ITIDBProjectDataSet;
        //private ITIDBProjectDataSetTableAdapters.GetExamQuestionsTableAdapter GetExamQuestionsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource GetStudentsInDepartment_ResultBindingSource;
        private System.Windows.Forms.BindingSource GetStudentGrades_ResultBindingSource;
        private System.Windows.Forms.BindingSource GetInsCoursesAndStudents_ResultBindingSource;
        private System.Windows.Forms.BindingSource GetCourseTopics_ResultBindingSource;
        private System.Windows.Forms.BindingSource GetExamQuestions_ResultBindingSource;
        private System.Windows.Forms.BindingSource GetStudentAnswers_ResultBindingSource;
    }
}