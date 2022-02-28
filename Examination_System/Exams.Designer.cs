using System.Windows.Forms;

namespace Examination_System
{
    partial class Exams
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
            this.Load += new System.EventHandler(this.Exams_Load);

            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblStdName = new System.Windows.Forms.Label();
            this.TimingBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.TimeLb1 = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.GroupBox();
            this.qOption4 = new System.Windows.Forms.RadioButton();
            this.qOption3 = new System.Windows.Forms.RadioButton();
            this.qOption2 = new System.Windows.Forms.RadioButton();
            this.qOption1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TimingBar.SuspendLayout();
            this.question.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(667, 517);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Size = new System.Drawing.Size(148, 41);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 699);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.lblStdName);
            this.panel2.Controls.Add(this.TimingBar);
            this.panel2.Controls.Add(this.lblQuestionNo);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.lblCourse);
            this.panel2.Controls.Add(this.question);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 678);
            this.panel2.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(343, 517);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Padding = new System.Windows.Forms.Padding(2);
            this.btnPrev.Size = new System.Drawing.Size(148, 41);
            this.btnPrev.TabIndex = 48;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblStdName
            // 
            this.lblStdName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblStdName.ForeColor = System.Drawing.Color.Peru;
            this.lblStdName.Location = new System.Drawing.Point(927, 30);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(269, 35);
            this.lblStdName.TabIndex = 46;
            this.lblStdName.Text = "Student Name";
            // 
            // TimingBar
            // 
            this.TimingBar.Controls.Add(this.TimeLb1);
            this.TimingBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TimingBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimingBar.ForeColor = System.Drawing.Color.White;
            this.TimingBar.Location = new System.Drawing.Point(1083, 524);
            this.TimingBar.Maximum = 80;
            this.TimingBar.Minimum = 0;
            this.TimingBar.Name = "TimingBar";
            this.TimingBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TimingBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TimingBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TimingBar.Size = new System.Drawing.Size(151, 151);
            this.TimingBar.TabIndex = 43;
            this.TimingBar.Text = "guna2CircleProgressBar1";
            // 
            // TimeLb1
            // 
            this.TimeLb1.AutoSize = true;
            this.TimeLb1.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TimeLb1.Location = new System.Drawing.Point(55, 60);
            this.TimeLb1.Name = "TimeLb1";
            this.TimeLb1.Size = new System.Drawing.Size(58, 29);
            this.TimeLb1.TabIndex = 38;
            this.TimeLb1.Text = "Tmg";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblQuestionNo.Location = new System.Drawing.Point(515, 186);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(163, 30);
            this.lblQuestionNo.TabIndex = 42;
            this.lblQuestionNo.Text = "Question No.";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(667, 492);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(2);
            this.btnNext.Size = new System.Drawing.Size(148, 41);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCourse.Location = new System.Drawing.Point(537, 30);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(93, 27);
            this.lblCourse.TabIndex = 39;
            this.lblCourse.Text = "Course";
            // 
            // question
            // 
            this.question.Controls.Add(this.qOption4);
            this.question.Controls.Add(this.qOption3);
            this.question.Controls.Add(this.qOption2);
            this.question.Controls.Add(this.qOption1);
            this.question.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.question.Location = new System.Drawing.Point(152, 218);
            this.question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question.Name = "question";
            this.question.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question.Size = new System.Drawing.Size(845, 270);
            this.question.TabIndex = 28;
            this.question.TabStop = false;
            this.question.Text = "Question";
            // 
            // qOption4
            // 
            this.qOption4.AutoSize = true;
            this.qOption4.Font = new System.Drawing.Font("Arial", 12F);
            this.qOption4.Location = new System.Drawing.Point(21, 195);
            this.qOption4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qOption4.Name = "qOption4";
            this.qOption4.Size = new System.Drawing.Size(100, 27);
            this.qOption4.TabIndex = 3;
            this.qOption4.TabStop = true;
            this.qOption4.Text = "Option4";
            this.qOption4.UseVisualStyleBackColor = true;
            // 
            // qOption3
            // 
            this.qOption3.AutoSize = true;
            this.qOption3.Font = new System.Drawing.Font("Arial", 12F);
            this.qOption3.Location = new System.Drawing.Point(21, 168);
            this.qOption3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qOption3.Name = "qOption3";
            this.qOption3.Size = new System.Drawing.Size(100, 27);
            this.qOption3.TabIndex = 2;
            this.qOption3.TabStop = true;
            this.qOption3.Text = "Option3";
            this.qOption3.UseVisualStyleBackColor = true;
            // 
            // qOption2
            // 
            this.qOption2.AutoSize = true;
            this.qOption2.Font = new System.Drawing.Font("Arial", 12F);
            this.qOption2.Location = new System.Drawing.Point(21, 141);
            this.qOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qOption2.Name = "qOption2";
            this.qOption2.Size = new System.Drawing.Size(100, 27);
            this.qOption2.TabIndex = 1;
            this.qOption2.TabStop = true;
            this.qOption2.Text = "Option2";
            this.qOption2.UseVisualStyleBackColor = true;
            // 
            // qOption1
            // 
            this.qOption1.AutoSize = true;
            this.qOption1.Font = new System.Drawing.Font("Arial", 12F);
            this.qOption1.Location = new System.Drawing.Point(21, 113);
            this.qOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qOption1.Name = "qOption1";
            this.qOption1.Size = new System.Drawing.Size(100, 27);
            this.qOption1.TabIndex = 0;
            this.qOption1.TabStop = true;
            this.qOption1.Text = "Option1";
            this.qOption1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(624, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quize Pro 1.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1273, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Exams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exams";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TimingBar.ResumeLayout(false);
            this.TimingBar.PerformLayout();
            this.question.ResumeLayout(false);
            this.question.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSubmit;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private GroupBox question;
        private Label TimeLb1;
        private RadioButton qOption4;
        private RadioButton qOption3;
        private RadioButton qOption2;
        private RadioButton qOption1;
        private Label lblCourse;
        private Button btnNext;
        private Label lblQuestionNo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar TimingBar;
        private Timer timer1;
        private Button btnPrev;
        private Label lblStdName;
    }
}