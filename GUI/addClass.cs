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
    public partial class addClass : Form
    {
        private Users.Director director = (Users.Director)Login.theUser;
        private EducationalFacility facility = Login.facility;


        private bool isLetter(char c)
        {
            bool isLetter = true;
            if ((c < 'a' && c >'z') || (c < 'A' && c > 'Z'))
            {
                isLetter = false;
            }
            return isLetter;
        }

        public addClass()
        {
            InitializeComponent();        
            foreach (String teacher in facility.Teachers.Keys)
            {
                cb_teachers.Items.Add(teacher);
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Users.Teacher theTeacher = null;
            if (cb_teachers.Text == "" && txt_Letter.Text == "" && txt_numberOfStudents.Text == "")  {
                MessageBox.Show("Please fill the fields");
                return;
            }

            if (txt_Letter.Text.Length > 1 && !isLetter(txt_Letter.Text[0])) {
                MessageBox.Show("Invalid Letter");
                return;
            }
            try
            {
                theTeacher = facility.Teachers[cb_teachers.Text];
                short grade = (short)nup_grade.Value;
                char Letter = txt_Letter.Text[0];
                byte numberOfStudents = Byte.Parse(txt_numberOfStudents.Text);

                if (theTeacher == null)
                {
                    MessageBox.Show("Teacher not found");
                    return;
                }
                if (theTeacher.ClassOfTeacher!=null)
                {
                    MessageBox.Show("Teacher already have a class!");
                    return;
                }

                director.CreateClass(grade, Letter, theTeacher, numberOfStudents);
                MessageBox.Show("Class " + grade + Letter + " with " + numberOfStudents + " has been created. The Teacher is " + theTeacher.Name);
                txt_Letter.Text = "";
                cb_teachers.Text = "";
                txt_numberOfStudents.Text = "";
                return;               

            }
            catch (Exception exc) {

                if (theTeacher == null)
                {
                    MessageBox.Show("Teacher not found");
                    return;
                }
                else
                {
                    MessageBox.Show("Please fill the fields");
                    return;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    
    }
}
