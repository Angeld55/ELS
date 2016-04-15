using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.School;
using ELS.Users;
using ELS.Records;

namespace ELS.Users
{
    public class Teacher : User
    {
        private List<Lesson> lessons;
        private string subject;
        private Lesson currentLesson;
        private Class classOfTecher;
        public Teacher(string name,long egn,string subject):base(name,egn)
        {
            this.Subject = subject;
            lessons = new List<Lesson>();
        }

        public string Subject 
        { 
            get
            {
                return subject;
            }
            set
            {
                this.subject=value;
            }
        }

        public Lesson CurrentLesson 
        { 
            get
            {
                return currentLesson;
            }
            private set
            {
                this.currentLesson=value;
            }
        }

        public List<Lesson> LessonsByThisTeacher
        {
            get
            {
                return lessons;
            }
            private set
            {
                this.lessons = value;
            }
        }
        public Class ClassOfTeacher
        {
            get
            {
                return classOfTecher;
            }
            set
            {
                this.classOfTecher = value;
            }
        }
        public void CreateLesson(Class SchoolClass)
        {
            DateTime now = DateTime.Today;
            Lesson lesson = new Lesson(this,SchoolClass,now);
            if (!SchoolClass.Lessons.ContainsKey(now))
            {
                SchoolClass.Lessons.Add(now, new List<Lesson>());
            }
            SchoolClass.Lessons[now].Add(lesson);
            CurrentLesson = lesson;
            lessons.Add(lesson);
        }
        public void LessonAddDescription(Lesson lesson,string description)
        {
            if (!lesson.Teacher.Equals(this))
            {
                throw new InvalidOperationException("You can't change the description! You are not the owner of the lesson!");
            }
            lesson.AddDescription(description);
        }
        public void LessonAddHomeWork(Lesson lesson,string HomeWork)
        {
            if (!lesson.Teacher.Equals(this))
            {
                throw new InvalidOperationException("You can't add homework! You are not the owner of the lesson!");
            }
            lesson.AddHomeWork(HomeWork);
        }
        private void AddGradeToStudent(Lesson lesson,Student student, byte grade, string note = null)
        {
            
            Grade gradeForStudent = new Grade(grade, this, lesson.DateOfLesson, note);
            lesson.LessonRecords.Add(gradeForStudent);
           
            ///
            if (!student.GradesBySubject.ContainsKey(Subject))
            {
                student.GradesBySubject.Add(Subject, new List<Grade>());
            }
            if (!student.DayRecords.ContainsKey(lesson.DateOfLesson))
            {
                student.DayRecords.Add(lesson.DateOfLesson, new List<Record>());
            }
            student.GradesBySubject[Subject].Add(gradeForStudent);
            student.DayRecords[lesson.DateOfLesson].Add(gradeForStudent);
        }
        ///overload -> add grade by students number;
        public void AddGradeToStudent(Lesson lesson,byte StudentNumber,byte grade,string note=null)
        {
            if (!CheckIfOwnerOfLesson(lesson))
            {
                throw new InvalidOperationException("You are not the owner of this lesson!");
            }
            Student student =lesson.SchoolClass.getStudentByNumber(StudentNumber);
            AddGradeToStudent(lesson, student, grade, note);
        }
        public void AddAbsenceToStudent(Lesson lesson,Student student,string note)
        {
            Absence absenceForStudent = new Absence(this, lesson.DateOfLesson, note);
            lesson.LessonRecords.Add(absenceForStudent);
            student.Absences.Add(absenceForStudent);
            if (!student.DayRecords.ContainsKey(absenceForStudent.Date))
            {
                student.DayRecords.Add(absenceForStudent.Date, new List<Record>());
            }
            student.DayRecords[absenceForStudent.Date].Add(absenceForStudent);
            student.UnexcusedAbsences++;
        }
        ///overload -> add absence by students number;
        public void AddAbsenceToStudent(Lesson lesson, byte StudentNumber,string note = null)
        {
            if (!CheckIfOwnerOfLesson(lesson))
            {
                throw new InvalidOperationException("You are not the owner of this lesson!");
            }
            Student student = lesson.SchoolClass.getStudentByNumber(StudentNumber);
            AddAbsenceToStudent(lesson, student, note);
        }
        public void AddNoteToStudent(Lesson lesson,Student student,string note=null)
        {
            Note noteForStudent = new Note(this, lesson.DateOfLesson, note);
            
            student.Notes.Add(noteForStudent);
            if (!student.DayRecords.ContainsKey(lesson.DateOfLesson))
            {
                student.DayRecords.Add(lesson.DateOfLesson, new List<Record>());
            }
            student.DayRecords[lesson.DateOfLesson].Add(noteForStudent);
        }
        ///overload ->add note by students number
        public void AddNoteToStudent(Lesson lesson,byte StudentNumber,string note)
        {
            if (!CheckIfOwnerOfLesson(lesson))
            {
                throw new InvalidOperationException("You are not the owner of this lesson!");
            }
            Student student = lesson.SchoolClass.getStudentByNumber(StudentNumber);
            AddNoteToStudent(lesson, student, note);
        }

        public void ExcuseAbsenceToStudent(Student student, Absence absence,string note)
        {
            if (!student.Class.Teacher.Equals(this))
            {
                throw new InvalidOperationException("You cant excuse this students absence!The student is not in your class!");
            }
            absence.Excused = true;
            absence.NoteForExusingTheAbsence = note;
            student.UnexcusedAbsences--;
        }

        public void InitializeClass(Class schoolClass)
        {
            if (!schoolClass.Teacher.Equals(this))
            {
                throw new InvalidOperationException("Invalid operation! You don't have the rights todo that");
            }
            schoolClass.setStudentNumbers();

        }

        private bool CheckIfOwnerOfLesson(Lesson lesson)
        {
            if (lesson.Teacher!=this)
            {
                return false;
            }
            return true;
        }
    }
}
