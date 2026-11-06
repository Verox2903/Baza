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
    public partial class UserControlSubject : UserControl
    {
        private Subject subject;
        public UserControlSubject(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;
            this.textBoxName.Text = subject.Name;
            this.numericUpDownHours.Value = subject.Hours;
        }
    }
}
