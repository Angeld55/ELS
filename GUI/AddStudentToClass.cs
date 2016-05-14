using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELS.GUI
{

    public partial class AddStudentToClass : Form
    {
        private Users.Director director = (Users.Director)Login.theUser;
        private EducationalFacility facility = Login.facility;
        public AddStudentToClass()
        {
            InitializeComponent();
            foreach  (string student  in facility.Students.Keys)
            {
                if (facility.Students[student].Class==null)
                {
                    cb_student.Items.Add(student);
                }
                
            }
            foreach (string classes in facility.Classes.Keys)
            {
                if (!facility.Classes[classes].isIntialized)
                {
                    cb_class.Items.Add(classes);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users.Student theStudent = null;
            School.Class theClass = null;

            if (cb_student.Text == "" || cb_class.Text == "")
            {
                MessageBox.Show("Please fill the fields");
                return;
            }
            
            try
            {
                theClass = facility.Classes[cb_class.Text];
                theStudent = facility.Students[cb_student.Text];
                if (theStudent.Class!=null)
                {
                    MessageBox.Show("The student is already in a class!");
                    return;
                }

                director.AddStudentToClass(theStudent, theClass);
                MessageBox.Show("Student " + cb_student.Text + " is added to class " + cb_class.Text);
                cb_class.Text = "";
                cb_student.Text = "";
            }
            catch (Exception exp) {
                if (theStudent == null)
                {
                    MessageBox.Show("Student not found");
                    return;
                }

                if (theClass == null)
                {
                    MessageBox.Show("Class not found");
                    return;
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
