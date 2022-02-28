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
    public partial class Exams : Form
    {
        private List<Generate_Exam_Result1> questionsList;
        private int questionIndex = 0;
        private int questionNumber = 1;
        private int courseId;

        public Exams(int _courseId)
        {
            courseId = _courseId;
            questionsList = new List<Generate_Exam_Result1>();
            InitializeComponent();
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            getExam(courseId);
            timer1.Start();
        }

        private void getExam(int courseId)
        {
            var result = Program.dbEntity.Generate_Exam(courseId);
            FetchQuestions(result);
        }

        private void FetchQuestions(ObjectResult<Generate_Exam_Result1> questionsQuery)
        {

            foreach (var question in questionsQuery)
            {
                questionsList.Add(question);
            }
            if (questionsList.Count > 0)
            {
                ShowCurrentQuestion();
            }
        }

        private void ShowCurrentQuestion()
        {
            if (questionIndex >= 0 && questionIndex < questionsList.Count-1)
            {
                lblQuestionNo.Text = "Question " + questionNumber;
                question.Text = questionsList[questionIndex].Question;
                qOption1.Text = questionsList[questionIndex].Choice;
                qOption2.Text = questionsList[++questionIndex].Choice;
                if (questionsList[questionIndex].Type_ID == 2)
                {
                    qOption3.Visible = true;
                    qOption4.Visible = true;
                    qOption3.Text = questionsList[++questionIndex].Choice;
                    qOption4.Text = questionsList[++questionIndex].Choice;
                }
                else
                {
                    qOption3.Visible = false;
                    qOption4.Visible = false;
                }
            }
        }

        int chorno = 80000;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            chorno -= 1;
            count++;
            TimingBar.Value = count;
            TimeLb1.Text = "" + chorno;
            if (TimingBar.Value == 80000)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time Over");
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionIndex++;
            questionNumber++;
            ShowCurrentQuestion();
            if (questionIndex + 1 == questionsList.Count)
            {
                btnNext.Visible = false;
                btnSubmit.Visible = true;
            }
            btnPrev.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (questionsList[questionIndex].Type_ID == 2) // questionType => MCQ
            {
                questionIndex -= 4;
                if (questionsList[questionIndex].Type_ID == 2) // questionType => MCQ
                {
                    questionIndex -= 3;
                }
                else
                {
                    questionIndex--;
                }
            }
            else
            {
                questionIndex -= 2;
                if (questionsList[questionIndex].Type_ID == 2) // questionType => MCQ
                {
                    questionIndex -= 3;
                }
                else
                {
                    questionIndex -= 2;
                }
            }
            if (questionIndex == 0)
                btnPrev.Visible = false;
            questionNumber--;
            ShowCurrentQuestion();
            btnNext.Visible = true;
        }
    }
}
