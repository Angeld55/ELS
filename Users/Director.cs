using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.School;

namespace ELS.Users
{
    public class Director : User
    {
        private EducationalFacility educationalFacility;
        public Director(string name,string egn,EducationalFacility school):base(name,egn)
        {
            this.educationalFacility = school;
            EducationalFacility.Users.Add(this.Name, this);
        }
        private EducationalFacility EducationalFacility 
        {   
            get
            {
                return this.educationalFacility;
            }
        }

        //add exeptions for such name ??
        public void CreateClass(short Grade,char Letter,Teacher teacher,byte studentsInClass=30)
        {
            Class schoolClass = new Class(Grade,Letter,teacher,studentsInClass);
            if (teacher.ClassOfTeacher!=null)
            {
                throw new InvalidOperationException("The teacher already have a class!");
            }
            teacher.ClassOfTeacher = schoolClass;
            if (EducationalFacility.Classes.ContainsKey(schoolClass.ToString()))
            {
                throw new InvalidOperationException("The is a class with the same parameters (grade and letter)");
            }
            EducationalFacility.Classes.Add(schoolClass.ToString(), schoolClass);
          
        }
        public void CreateTeacher(string name, string egn, string subject)
        {
            Teacher teacher = new Teacher(name, egn, subject);
            EducationalFacility.Users.Add(teacher.Name, teacher);
            EducationalFacility.Teachers.Add(teacher.Name, teacher);
            
        }
        public void CreateStudent(string Name, string EGN)
        {
            Student student = new Student(Name, EGN);
            EducationalFacility.Users.Add(student.Name, student);
            EducationalFacility.Students.Add(student.Name, student);
        }
        public void CreateParent(string Name, string EGN, Student student)
        {
            Parent parent = new Parent(Name, EGN, student);
            student.Parent = parent;

            EducationalFacility.Users.Add(Name, parent);
        }

        public void AddStudentToClass(Student student,Class schoolClass)
        {
            if (student.Class!=null)
            {
                throw new InvalidOperationException("The student is in a class!");
            }
            student.Class = schoolClass;
            schoolClass.Students.Add(student);
        }
        public void InitializeClass(Class schoolClass)
        {
            schoolClass.setStudentNumbers();
        }

        public void CreateAssistantDirector(string Name, string EGN)
        {
            if (this.EducationalFacility.Users.ContainsKey(Name))
            {
                throw new InvalidOperationException("There is an user with this name");
            }
            AssistantDirector assistantDirector = new AssistantDirector(Name, EGN, this.EducationalFacility);          
        }

    }
}
