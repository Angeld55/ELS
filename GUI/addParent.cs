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
    public partial class addParent : Form
    {
        private Users.Director director = (Users.Director)Login.theUser;
        private EducationalFacility facility = Login.facility;
        public addParent()
        {
            InitializeComponent();
            foreach (String student in facility.Students.Keys) {
                cb_students.Items.Add(student);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users.Student theStudent = null;
     

            if (txt_egn.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("Please fill the fields");
                return;
            }
            string[] names = txt_name.Text.Split();

            if (names.Length != 2)
            {
                MessageBox.Show("Please enter two names");
                return;
            }

            if (txt_egn.Text.Length != 10)
            {
                MessageBox.Show("EGN is not correct");
                return;
            }

            try
            {

                theStudent = facility.Students[cb_students.Text];

                string name = txt_name.Text;
                string egn = txt_egn.Text;

                director.CreateParent(name, egn, theStudent);

                MessageBox.Show("Parent " + name + " of the Student " + cb_students.Text + " is created!");
                txt_name.Text = "";
                txt_egn.Text = "";
                return;
            }
            catch (Exception exp) {
                if (theStudent == null)
                {
                    MessageBox.Show("Student not found");
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
