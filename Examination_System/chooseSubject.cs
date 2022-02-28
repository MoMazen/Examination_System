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
    public partial class chooseSubject : Form
    {
        public chooseSubject()
        {
            InitializeComponent();
        }

        private void chooseSubject_Load(object sender, EventArgs e)
        {
            GetSubjects();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetSubjects()
        {
            Program.dbEntity.sp_select_from_Course();
            ObjectResult<sp_select_from_Course_Result> coursesResult = null;
            try
            {
                coursesResult = Program.dbEntity.sp_select_from_Course();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure your connection is stable.");
                return;
            }
            //comBoxCourse.DataSource = coursesResult;
            comBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            var courses = new List<sp_select_from_Course_Result>();
            foreach (var result in coursesResult)
            {
                courses.Add(result);
            }

            List<ComboboxItem> items = new List<ComboboxItem>();
            foreach (var course in courses)
            {
                ComboboxItem item = new ComboboxItem();

                item.Value = course.ID;
                item.Text = course.Name;

                items.Add(item);
            }
            comBoxCourse.DataSource = items;
            comBoxCourse.SelectedIndex = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            object result = comBoxCourse.SelectedValue;
            ComboboxItem selectedItem = result as ComboboxItem;
            //MessageBox.Show($"Hello ID: {int.Parse(selectedItem.Value.ToString())}");
            this.Hide();
            Exams exam = new Exams(int.Parse(selectedItem.Value.ToString()));
            exam.ShowDialog();
            this.Close();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
