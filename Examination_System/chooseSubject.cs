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
        StudentLandPage stdLandPage;
        public chooseSubject(StudentLandPage _stdLandPage)
        {
            this.stdLandPage = _stdLandPage;
            InitializeComponent();
        }

        private void chooseSubject_Load(object sender, EventArgs e)
        {
            this.sp_select_from_CourseTableAdapter.Fill(this.selectCoursesDataSet.sp_select_from_Course);
            comBoxCourse.SelectedIndex = 0;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            stdLandPage.course_id = int.Parse(comBoxCourse.SelectedValue.ToString());
            comBoxCourse.DataSource = null;
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
