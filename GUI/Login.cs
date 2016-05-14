using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ELS.GUI
{
    public partial class Login : Form
    {
     
        public static EducationalFacility facility = new EducationalFacility("Petur Ivanov", "6712023451");
        private Users.Director currentDirector = (Users.Director)facility.Identify("Petur Ivanov", "6712023451");     
        public static ELS.Users.User theUser = null;
        public static Users.Teacher theTeacher = null;
        public static Users.Student theStudent = null;
        public static Users.Parent theParent = null;
        public static Users.AssistantDirector theAssDirector = null;

        public Login()
        {
            InitializeComponent();
            //currentDirector.CreateAssistantDirector("Deyan Svetoslavov", "1313131313");
            //currentDirector.CreateTeacher("Juli Kanata", "11111111", "Sports");
            //currentDirector.CreateTeacher("Jivka Buchvata", "11111111", "Informatics");
            //currentDirector.CreateStudent("Agd 145", "1010101010");
            //currentDirector.CreateStudent("Dejan Sve", "1010101010");
            //currentDirector.CreateClass(12, 'A', facility.Teachers["Juli Kanata"]);
            //currentDirector.CreateClass(12, 'V', facility.Teachers["Jivka Buchvata"]);
            //currentDirector.AddStudentToClass(facility.Students["Dejan Sve"], facility.Classes["12A"]);
            //currentDirector.InitializeClass(facility.Classes["12A"]);
            //currentDirector.AddStudentToClass(facility.Students["Agd 145"], facility.Classes["12V"]);
            //currentDirector.InitializeClass(facility.Classes["12V"]);
            //facility.Teachers["Stefan Savov"].CreateLesson(facility.Classes["1A"]);
            //facility.Teachers["Stefan Savov"].AddGradeToStudent(facility.Teachers["Stefan Savov"].CurrentLesson, 1, 5);
            //facility.Teachers["Stefan Savov"].LessonAddHomeWork(facility.Teachers["Stefan Savov"].CurrentLesson, "You have homework");
            //currentDirector.CreateParent("Angel Dimitriev", "1111111111", facility.Students["Ivan Ivanov"]);
            //facility.Teachers["Stefan Savov"].AddAbsenceToStudent(facility.Teachers["Stefan Savov"].CurrentLesson, 1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
         

            if(txt_UserName.Text=="" || txt_Password.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                if (!facility.Users.ContainsKey(txt_UserName.Text))
                {
                    MessageBox.Show("No such User");
                    throw new InvalidOperationException("No such user!");
                }

                theUser = facility.Users[txt_UserName.Text];

                if (txt_Password.Text != theUser.EGN)
                {
                    MessageBox.Show("Invalid password");
                    throw new InvalidOperationException("Invalid password!");
                }
                else {
                    string userType = Users.User.userType(theUser);

                    switch (userType)
                    {
                        case "director":
                            //txt_Password.Text = theUser.EGN;
                            Users.Director theDirector = (Users.Director)theUser;
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            DirectorPage fm = new DirectorPage();
                            fm.Show(); 
                            txt_UserName.Text= "";
                            txt_Password.Text = "";
                            break;
                        case "teacher":
                            //txt_Password.Text = theUser.EGN;
                            theTeacher = (Users.Teacher)theUser;
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            TeachersPage tp = new TeachersPage(theTeacher);
                           
                            tp.Show();        
                            txt_UserName.Text= "";
                            txt_Password.Text = "";
                            break;
                        case "student":
                            //txt_Password.Text = theUser.EGN;
                            theStudent = (Users.Student)theUser;
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            StudentPage sp = new StudentPage();
                            sp.Show();
                            txt_UserName.Text= "";
                            txt_Password.Text = "";
                            break;
                        case "parent":
                            //txt_Password.Text = theUser.EGN;
                            theParent = (Users.Parent)theUser;
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            ParentPage pp = new ParentPage();
                            pp.Show();
                            txt_UserName.Text= "";
                            txt_Password.Text = "";
                            break;
                        case "AssDirector" : 
                            theAssDirector = (Users.AssistantDirector)theUser;
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            AssDirectorPage adp = new AssDirectorPage();
                            adp.Show();
                            txt_UserName.Text= "";
                            txt_Password.Text = "";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception exc)
            { 
                //do nothing
            }

           

            
            
        }     
    }
}
