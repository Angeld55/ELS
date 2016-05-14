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
    public partial class AssDirectorPage : Form
    {
        public AssDirectorPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addStudent adds = new addStudent();
            adds.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addTeacher at = new addTeacher();
            at.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addParent addp = new addParent();
            addp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClass ac = new addClass();
            ac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudentToClass adtc = new AddStudentToClass();
            adtc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InitClass ic = new InitClass();
            ic.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationRun.theLogin.Show();
        }
    }
}
