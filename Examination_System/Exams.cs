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
        private ExamAnswers_Model[] answersList = new ExamAnswers_Model[10];
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

        int duration = 3_600;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            count++;

            int min = duration / 60;
            int sec = duration - min * 60;

            TimingBar.Value = count;

            string timer = min + ":" + sec;
            if(sec < 10)
                timer = min + ":0" + sec;
            if (min < 10)
                timer = "0" + timer;

            TimeLb1.Text = timer;
            if (TimingBar.Value == 3_600)
            {
                timer1.Stop();
                submitAnswers();
                var result = Program.dbEntity.CorrectExam(questionsList[0].Exam_Id, 1);

                int? studentRsult = -1;

                foreach (var r in result)
                {
                    studentRsult = r;
                }

                MessageBox.Show($"Sorry your time has finished!\n Your result is {studentRsult}", "Alert");
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            saveStudentAnswer();

            questionIndex++;
            questionNumber++;
            ShowCurrentQuestion();
            qOption1.Checked = true;
            if (questionIndex + 1 == questionsList.Count)
            {
                btnNext.Visible = false;
                btnSubmit.Visible = true;
            }
            btnPrev.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveStudentAnswer();
            submitAnswers();
            var result = Program.dbEntity.CorrectExam(questionsList[0].Exam_Id, 1);

            int? studentRsult = -1;

            foreach (var r in result)
            {
                studentRsult = r;
            }
            timer1.Stop();
            MessageBox.Show($"Your result is {studentRsult}", "Alert");
            this.Close();
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
                    questionIndex --;
                }
            }
            if (questionIndex == 0)
                btnPrev.Visible = false;
            questionNumber--;
            ShowCurrentQuestion();
            qOption1.Checked = true;
            btnNext.Visible = true;
        }

        private void submitAnswers()
        {
            foreach(var answer in answersList)
            {
                Program.dbEntity.Exam_Answer(answer.exam_id, answer.course_id, answer.question_id, answer.student_id, answer.answer);
            }
        }

        private void saveStudentAnswer()
        {
            string studentAnswer = "";
            if (qOption1.Checked)
                studentAnswer = qOption1.Text;
            else if (qOption2.Checked)
                studentAnswer = qOption2.Text;
            else if (qOption3.Checked)
                studentAnswer = qOption3.Text;
            else if (qOption4.Checked)
                studentAnswer = qOption4.Text;

            answersList[questionNumber - 1] = new ExamAnswers_Model();

            answersList[questionNumber - 1].exam_id = questionsList[questionIndex].Exam_Id;
            answersList[questionNumber - 1].course_id = questionsList[questionIndex].Course_ID;
            answersList[questionNumber - 1].question_id = questionsList[questionIndex].Question_ID;
            answersList[questionNumber - 1].student_id = 1;//Program.userData.ID;
            answersList[questionNumber - 1].answer = studentAnswer;
        }
    }
}
