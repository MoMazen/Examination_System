namespace Examination_System
{
    partial class ReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDialog));
            this.spselectfromCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCoursesDataSet = new Examination_System.SelectCoursesDataSet();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_select_from_CourseTableAdapter = new Examination_System.SelectCoursesDataSetTableAdapters.sp_select_from_CourseTableAdapter();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spselectfromCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spselectfromCourseBindingSource
            // 
            this.spselectfromCourseBindingSource.DataMember = "sp_select_from_Course";
            this.spselectfromCourseBindingSource.DataSource = this.selectCoursesDataSet;
            // 
            // selectCoursesDataSet
            // 
            this.selectCoursesDataSet.DataSetName = "SelectCoursesDataSet";
            this.selectCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(154, 11);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closebtn.Location = new System.Drawing.Point(446, 2);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 38);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.text1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 505);
            this.panel2.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(18, 267);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(404, 40);
            this.text1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Label1";
            // 
            // sp_select_from_CourseTableAdapter
            // 
            this.sp_select_from_CourseTableAdapter.ClearBeforeFill = true;
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(18, 374);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(404, 40);
            this.text2.TabIndex = 37;
            this.text2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "Please Enter Student id:";
            this.label2.Visible = false;
            // 
            // ReportGetDeptStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 505);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportGetDeptStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chooseSubject";
            this.Load += new System.EventHandler(this.chooseSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spselectfromCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private SelectCoursesDataSet selectCoursesDataSet;
        private System.Windows.Forms.BindingSource spselectfromCourseBindingSource;
        private SelectCoursesDataSetTableAdapters.sp_select_from_CourseTableAdapter sp_select_from_CourseTableAdapter;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label2;
    }
}