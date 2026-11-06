using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza2
{
    public partial class Form1 : Form
    {

        private DBData db = new DBData();
        public Form1()
        {
            InitializeComponent();
            ReadTeachers();
        }

        private void ReadTeachers()
        {
            listBoxTeachers.Items.Clear();
            listBoxTeachers.Items.AddRange(db.Teachers.ToArray());
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTeachers.SelectedItem is Teacher)
            {
                flowLayoutPanelSubjects.Controls.Clear();
                Teacher teacher = listBoxTeachers.SelectedItem as Teacher;
                foreach(Subject subject in teacher.Subjects)
                {
                    flowLayoutPanelSubjects.Controls.Add(new UserControlSubject(subject));
                }
            }
        }
    }
}
