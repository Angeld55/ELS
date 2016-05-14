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
    public partial class addTeacher : Form
    {
        private Users.Director director = (Users.Director)Login.theUser;
        private EducationalFacility facility = Login.facility;
        public addTeacher()
        {
            InitializeComponent();
        }

        private void addTeacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_egn.Text == "" || txt_name.Text == "" || txt_subject.Text == "") {
                MessageBox.Show("Please fill the fields");
                return;
            }
            string[] names = txt_name.Text.Split();
            
            if (names.Length != 2) {
                MessageBox.Show("Please enter two names");
                return;
            }

            if (txt_egn.Text.Length != 10)
            {
                MessageBox.Show("EGN is not correct");
                return;
            }

            string name = txt_name.Text;
            string egn = txt_egn.Text;
            string subject = txt_subject.Text;

            director.CreateTeacher(name, egn, subject);

            MessageBox.Show("Teacher " + name + " teaching " + subject + " is created!");
            txt_subject.Text = "";
            txt_name.Text = "";
            txt_egn.Text = "";
            return; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
