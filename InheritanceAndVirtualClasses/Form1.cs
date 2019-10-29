using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceAndVirtualClasses
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string gender
        {
            get
            {
                if (menButton.Checked)
                    return "Male";
                else
                    if (womenButton.Checked)
                    return "Female";
                else
                    return null;
            }
        }
        public string course
        {
            get
            {
                if (comboCourse.Text != null)
                    return comboCourse.Text;
                else
                    return null;
            }
        }
        public string department
        {
            get
            {
                if (comboDepartment.Text != null)
                    return comboDepartment.Text;
                else
                    return null;
            }
        }

        public event EventHandler getNameClick;
        public event EventHandler getNameStudentClick;
        public event EventHandler getTeacherClick;

        public void MessageError(string message)
        {
            MessageBox.Show(message);
        }

        public void RequestSuccess(string message)
        {
            mainTextBox.Text += message + ":\n";
        }

        public void RequestGetNameOnSuccess(Person person)
        {
            
        }

        public void RequestGetNameStudentOnSuccess(Person person)
        {
            throw new NotImplementedException();
        }

        public void RequestGetTeacherOnSuccess(Person person)
        {
            throw new NotImplementedException();
        }

        private void getName_Click(object sender, EventArgs e)
        {
            if (getNameClick != null)
                getNameClick(this, EventArgs.Empty);
        }

        private void getNameStudent_Click(object sender, EventArgs e)
        {
            if (getNameStudentClick != null)
                getNameStudentClick(this, EventArgs.Empty);
        }

        private void getTeacher_Click(object sender, EventArgs e)
        {
            if (getTeacherClick != null)
                getTeacherClick(this, EventArgs.Empty);
        }


    }
}
