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
    public partial class InitClass : Form
    {
        private Users.Director director = (Users.Director)Login.theUser;
        private EducationalFacility facility = Login.facility;

        public InitClass()
        {
            InitializeComponent();
            foreach  (School.Class classes in facility.Classes.Values)
            {
                if(!classes.isIntialized){
                    cb_class.Items.Add(classes.ToString());
                }              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_class.Text == "")
            {
                MessageBox.Show("Please select class");
                return;
            }
            if (facility.Classes[cb_class.Text].isIntialized)
            {
                MessageBox.Show("The class is initialized!");
                return;
            }
            director.InitializeClass(facility.Classes[cb_class.Text]);
            MessageBox.Show("Class " + cb_class.Text + " is initialized! ");
            cb_class.Items.Remove(cb_class.Text);
            cb_class.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
