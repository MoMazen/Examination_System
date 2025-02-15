﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examination_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ITIDBProjectEntities : DbContext
    {
        public ITIDBProjectEntities()
            : base("name=ITIDBProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<int>> CorrectExam(Nullable<int> exam_Id, Nullable<int> student_Id)
        {
            var exam_IdParameter = exam_Id.HasValue ?
                new ObjectParameter("Exam_Id", exam_Id) :
                new ObjectParameter("Exam_Id", typeof(int));
    
            var student_IdParameter = student_Id.HasValue ?
                new ObjectParameter("Student_Id", student_Id) :
                new ObjectParameter("Student_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CorrectExam", exam_IdParameter, student_IdParameter);
        }
    
        public virtual int Exam_Answer(Nullable<int> exam_id, Nullable<int> course_id, Nullable<int> question_id, Nullable<int> student_id, string answer)
        {
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("Exam_id", exam_id) :
                new ObjectParameter("Exam_id", typeof(int));
    
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("course_id", course_id) :
                new ObjectParameter("course_id", typeof(int));
    
            var question_idParameter = question_id.HasValue ?
                new ObjectParameter("question_id", question_id) :
                new ObjectParameter("question_id", typeof(int));
    
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("student_id", student_id) :
                new ObjectParameter("student_id", typeof(int));
    
            var answerParameter = answer != null ?
                new ObjectParameter("answer", answer) :
                new ObjectParameter("answer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Exam_Answer", exam_idParameter, course_idParameter, question_idParameter, student_idParameter, answerParameter);
        }
    
        public virtual ObjectResult<GetCourseTopics_Result> GetCourseTopics(Nullable<int> course_id)
        {
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("course_id", course_id) :
                new ObjectParameter("course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCourseTopics_Result>("GetCourseTopics", course_idParameter);
        }
    
        public virtual int GetExamInfo(Nullable<int> exam_Id, ObjectParameter ques_Id, ObjectParameter course_Id)
        {
            var exam_IdParameter = exam_Id.HasValue ?
                new ObjectParameter("Exam_Id", exam_Id) :
                new ObjectParameter("Exam_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetExamInfo", exam_IdParameter, ques_Id, course_Id);
        }
    
        public virtual ObjectResult<GetExamQuestions_Result> GetExamQuestions(Nullable<int> exam_id)
        {
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("exam_id", exam_id) :
                new ObjectParameter("exam_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetExamQuestions_Result>("GetExamQuestions", exam_idParameter);
        }
    
        public virtual ObjectResult<GetInsCoursesAndStudents_Result> GetInsCoursesAndStudents(Nullable<int> instructor_id)
        {
            var instructor_idParameter = instructor_id.HasValue ?
                new ObjectParameter("instructor_id", instructor_id) :
                new ObjectParameter("instructor_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInsCoursesAndStudents_Result>("GetInsCoursesAndStudents", instructor_idParameter);
        }
    
        public virtual ObjectResult<GetStudentAnswers_Result> GetStudentAnswers(Nullable<int> student_id, Nullable<int> exam_id)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("student_id", student_id) :
                new ObjectParameter("student_id", typeof(int));
    
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("exam_id", exam_id) :
                new ObjectParameter("exam_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentAnswers_Result>("GetStudentAnswers", student_idParameter, exam_idParameter);
        }
    
        public virtual ObjectResult<GetStudentGrades_Result> GetStudentGrades(Nullable<int> student_id)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("student_id", student_id) :
                new ObjectParameter("student_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentGrades_Result>("GetStudentGrades", student_idParameter);
        }
    
        public virtual ObjectResult<GetStudentsInDepartment_Result> GetStudentsInDepartment(Nullable<int> dept_id)
        {
            var dept_idParameter = dept_id.HasValue ?
                new ObjectParameter("dept_id", dept_id) :
                new ObjectParameter("dept_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentsInDepartment_Result>("GetStudentsInDepartment", dept_idParameter);
        }
    
        public virtual ObjectResult<LoginProcedure_Result> LoginProcedure(string email, string pass)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginProcedure_Result>("LoginProcedure", emailParameter, passParameter);
        }
    
        public virtual ObjectResult<sp_select_from_Course_Result> sp_select_from_Course()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Course_Result>("sp_select_from_Course");
        }
    
        public virtual ObjectResult<sp_select_from_Department_Result> sp_select_from_Department()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Department_Result>("sp_select_from_Department");
        }
    
        public virtual ObjectResult<sp_select_from_Instructor_Result> sp_select_from_Instructor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Instructor_Result>("sp_select_from_Instructor");
        }
    
        public virtual ObjectResult<sp_select_from_Question_Result> sp_select_from_Question()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Question_Result>("sp_select_from_Question");
        }
    
        public virtual ObjectResult<sp_select_from_Question_Type_Result> sp_select_from_Question_Type()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Question_Type_Result>("sp_select_from_Question_Type");
        }
    
        public virtual ObjectResult<sp_select_from_Student_Result> sp_select_from_Student()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Student_Result>("sp_select_from_Student");
        }
    
        public virtual ObjectResult<sp_select_from_Topic_Result> sp_select_from_Topic()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_select_from_Topic_Result>("sp_select_from_Topic");
        }
    
        public virtual ObjectResult<Generate_Exam_Result1> Generate_Exam(Nullable<int> course_id)
        {
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("course_id", course_id) :
                new ObjectParameter("course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Generate_Exam_Result1>("Generate_Exam", course_idParameter);
        }
    }
}
