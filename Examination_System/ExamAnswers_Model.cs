using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class ExamAnswers_Model
    {
        public Nullable<int> exam_id;
        public Nullable<int> course_id;
        public Nullable<int> question_id;
        public Nullable<int> student_id;
        public string answer;
    }
}
