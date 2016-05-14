//using System;
//using ELS;
//using ELS.Users;
//using ELS.School;
//using System.Collections.Generic;


//namespace ELS.tests
//{
//    [TestClass]
//    public class ELSMainTests
//    {
//        [TestMethod]
//        [ExpectedException(typeof(InvalidOperationException), "No such user!")]
//        public void IdentifyingUsers()
//        {
//            EducationalFacility facility = new EducationalFacility("Steven Markov", "8703058883");
//            Assert.AreEqual(facility.Identify("Steven Markov", "8703058883"), facility.Director);
//            facility.Identify("Unexisting user", "12345678");
//        }
//    
//

////        [TestMethod]
////        public void AddingTeachers()
////        {

////            EducationalFacility facility = new EducationalFacility("Steven Markov", 8703058883);
////            facility.Director.CreateTeacher("Stanislava Dimitrova", 7612044442, "English");
////            facility.Director.CreateTeacher("Yordanka Popova", 6512435655, "Biology");
////            facility.Director.CreateTeacher("Petur Trunev", 6312123456, "Sports");
////            facility.Director.CreateTeacher("Ivan Bechev", 5911063455, "English");
////            facility.Director.CreateTeacher("Nasko Denev", 7321023456, "Sports");
////            facility.Director.CreateTeacher("Stanimir Lopatov", 8943263455, "English");
////            facility.Director.CreateTeacher("Petur Popov", 5311013876, "Sports");
////            Assert.AreEqual(facility.Teachers["Stanislava Dimitrova"].Name, "Stanislava Dimitrova");
////            Assert.AreEqual(facility.Teachers["Stanislava Dimitrova"].Subject, "English");
////            Assert.AreEqual(facility.Teachers["Stanislava Dimitrova"].EGN, 7612044442);
////            Assert.AreEqual(facility.Teachers["Yordanka Popova"].Name, "Yordanka Popova");
////            Assert.AreEqual(facility.Teachers["Yordanka Popova"].Subject, "Biology");
////            Assert.AreEqual(facility.Teachers["Yordanka Popova"].EGN, 6512435655);
////            Assert.AreEqual(facility.Teachers["Petur Trunev"].Name, "Petur Trunev");
////            Assert.AreEqual(facility.Teachers["Ivan Bechev"].Name, "Ivan Bechev");
////            Assert.AreEqual(facility.Teachers["Nasko Denev"].Name, "Nasko Denev");
////            Assert.AreEqual(facility.Teachers["Stanimir Lopatov"].Name, "Stanimir Lopatov");

////        }

////        [TestMethod]
////        public void AddingStudentsToClass()
////        {

////            EducationalFacility facility = new EducationalFacility("Steven Markov", 8703058883);
////            facility.Director.CreateTeacher("Stanislava Dimitrova", 7612044442, "English");
////            facility.Director.CreateTeacher("Yordanka Popova", 6512435655, "Biology");
////            facility.Director.CreateClass(11, 'D', facility.Teachers["Yordanka Popova"]);
////            Assert.AreEqual(facility.Classes["11D"].ClassLetter, 'D');
////            Assert.AreEqual(facility.Classes["11D"].Grade, 11);
////            facility.Director.CreateStudent("Pesho Popov", 6712015672);
////            facility.Director.CreateStudent("Iliqn Stefanov", 56030145567);
////            facility.Director.CreateStudent("Alexander Vasilev", 56030145567);
////            facility.Director.AddStudentToClass(facility.Students["Iliqn Stefanov"], facility.Classes["11D"]);
////            facility.Director.AddStudentToClass(facility.Students["Pesho Popov"], facility.Classes["11D"]);
////            facility.Director.AddStudentToClass(facility.Students["Alexander Vasilev"], facility.Classes["11D"]);
////            facility.Teachers["Yordanka Popova"].InitializeClass(facility.Classes["11D"]);

////            Assert.AreEqual(facility.Classes["11D"].getStudentByNumber(1).Name, "Alexander Vasilev");
////            Assert.AreEqual(facility.Classes["11D"].getStudentByNumber(2).Name, "Iliqn Stefanov");
////            Assert.AreEqual(facility.Classes["11D"].getStudentByNumber(3).Name, "Pesho Popov");

////        }
////        [TestMethod]
////        public void AddingGradesToStudent()
////        {

////            EducationalFacility facility = new EducationalFacility("Steven Markov", 8703058883);
////            facility.Director.CreateTeacher("Stanislava Dimitrova", 7612044442, "English");
////            facility.Director.CreateTeacher("Yordanka Popova", 6512435655, "Biology");
////            facility.Director.CreateClass(11, 'D', facility.Teachers["Yordanka Popova"]);

////            facility.Director.CreateStudent("Pesho Popov", 6712015672);
////            facility.Director.CreateStudent("Iliqn Stefanov", 56030145567);
////            facility.Director.CreateStudent("Alexander Vasilev", 56030145567);

////            ///all students in 11D!
////            facility.Director.AddStudentToClass(facility.Students["Iliqn Stefanov"], facility.Classes["11D"]);
////            facility.Director.AddStudentToClass(facility.Students["Pesho Popov"], facility.Classes["11D"]);
////            facility.Director.AddStudentToClass(facility.Students["Alexander Vasilev"], facility.Classes["11D"]);
////            /// Initilize class(Ready for work)
////            facility.Teachers["Yordanka Popova"].InitializeClass(facility.Classes["11D"]);

////            /// creating Lesson --> нов учебен час!
////            facility.Teachers["Yordanka Popova"].CreateLesson(facility.Classes["11D"]);

////            ///teacher finds the class, than the lesson ,then the student and adds the grade!
////            ///adding two gradeson biology to students with numbers 2 and 3(grades --> 6,2)
////            facility.Teachers["Yordanka Popova"].AddGradeToStudent(facility.Classes["11D"].Lessons[DateTime.Today][0], 2, 6);
////            facility.Teachers["Yordanka Popova"].AddGradeToStudent(facility.Classes["11D"].Lessons[DateTime.Today][0], 3, 2);
////            ///geting the grades by subject --> list;
////            Assert.AreEqual(facility.Students["Iliqn Stefanov"].GradesBySubject["Biology"][0].GradeOfStudent, 6);
////            Assert.AreEqual(facility.Students["Pesho Popov"].GradesBySubject["Biology"][0].GradeOfStudent, 2);
////            facility.Teachers["Stanislava Dimitrova"].CreateLesson(facility.Classes["11D"]);

////            ///adding grade for the second leson of the day(Lessons[DateTime.Today][1]) to student with number 2-->grade 3
////            facility.Teachers["Stanislava Dimitrova"].AddGradeToStudent(facility.Classes["11D"].Lessons[DateTime.Today][1], 2, 3);
////            Assert.AreEqual(facility.Students["Iliqn Stefanov"].GradesBySubject["English"][0].GradeOfStudent, 3);
////            facility.Teachers["Stanislava Dimitrova"].AddGradeToStudent(facility.Classes["11D"].Lessons[DateTime.Today][1], 2, 4);
////            Assert.AreEqual(facility.Students["Iliqn Stefanov"].GradesBySubject["English"][1].GradeOfStudent, 4);
////        }

////        [TestMethod]
////        public void AddingNotesAndAbsencesToStudents()
////        {
////            EducationalFacility facility = new EducationalFacility("Konstantin Popov", 7603451234);
////            Director directorOfSchool = (Director)facility.Identify("Konstantin Popov", 7603451234);
////            directorOfSchool.CreateTeacher("Juliana Kanaziirska", 4502251231, "German");
////            directorOfSchool.CreateStudent("Dejan Svetoslavov", 9510191234);
////            directorOfSchool.CreateStudent("Hristo Vassilev", 9502245511);
////            directorOfSchool.CreateStudent("Stanislav Kostov", 9512220323);
////            directorOfSchool.CreateClass(12, 'A', facility.Teachers["Juliana Kanaziirska"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Hristo Vassilev"], facility.Classes["12A"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Dejan Svetoslavov"], facility.Classes["12A"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Stanislav Kostov"], facility.Classes["12A"]);
////            /// seting the class ready for work!
////            directorOfSchool.InitializeClass(facility.Classes["12A"]);
////            Teacher teacher = (Teacher)facility.Identify("Juliana Kanaziirska", 4502251231);
////            teacher.CreateLesson(facility.Classes["12A"]);
////            teacher.AddAbsenceToStudent(teacher.CurrentLesson, 1);
////            teacher.AddNoteToStudent(teacher.CurrentLesson, 1, "losho momche!");
////            teacher.AddNoteToStudent(teacher.CurrentLesson, 2, "Pak bez domashna rabota!");
////            teacher.AddNoteToStudent(teacher.CurrentLesson, 2, "I se durji neprilichno v chas");


////            Assert.AreEqual(facility.Students["Dejan Svetoslavov"].Absences[0].Subject, "German");
////            Assert.AreEqual(facility.Students["Dejan Svetoslavov"].Notes[0].Note, "losho momche!");
////            Assert.AreEqual(facility.Students["Hristo Vassilev"].Notes[0].Note, "Pak bez domashna rabota!");
////            Assert.AreEqual(facility.Students["Hristo Vassilev"].Notes[1].Note, "I se durji neprilichno v chas");

////            Assert.AreEqual(facility.Students["Dejan Svetoslavov"].DayRecords[DateTime.Today].Count, 2);
////            Assert.AreEqual(facility.Students["Hristo Vassilev"].DayRecords[DateTime.Today].Count, 2);
////            teacher.AddAbsenceToStudent(teacher.CurrentLesson, 3);
////            teacher.AddAbsenceToStudent(teacher.CurrentLesson, 3);
////            teacher.AddAbsenceToStudent(teacher.CurrentLesson, 3);
////            Assert.AreEqual(facility.Students["Stanislav Kostov"].UnexcusedAbsences, 3);
////            teacher.ExcuseAbsenceToStudent(facility.Students["Stanislav Kostov"], facility.Students["Stanislav Kostov"].Absences[0], "vsichko e ok!");
////            Assert.AreEqual(facility.Students["Stanislav Kostov"].UnexcusedAbsences, 2);

////        }
////        [TestMethod]
////        public void ParentAcces()
////        {
////            EducationalFacility facility = new EducationalFacility("Konstantin Popov", 7603451234);
////            Director directorOfSchool = (Director)facility.Identify("Konstantin Popov", 7603451234);
////            directorOfSchool.CreateTeacher("Juliana Kanaziirska", 4502251231, "German");
////            directorOfSchool.CreateStudent("Dejan Svetoslavov", 9510191234);
////            directorOfSchool.CreateStudent("Hristo Vassilev", 9502245511);
////            directorOfSchool.CreateClass(12, 'A', facility.Teachers["Juliana Kanaziirska"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Hristo Vassilev"], facility.Classes["12A"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Dejan Svetoslavov"], facility.Classes["12A"]);
////            /// seting the class ready for work!
////            directorOfSchool.InitializeClass(facility.Classes["12A"]);

////            directorOfSchool.CreateParent("Luba Vassileva", 7012018743, facility.Students["Hristo Vassilev"]);

////            Parent parent = (Parent)facility.Identify("Luba Vassileva", 7012018743);

////            //Check if the parent and student are connected correctly!
////            Assert.AreEqual(parent.Student, facility.Students["Hristo Vassilev"]);
////            Assert.AreEqual(facility.Students["Hristo Vassilev"].Parent, parent);

////            Teacher teacher = (Teacher)facility.Identify("Juliana Kanaziirska", 4502251231);
////            teacher.CreateLesson(facility.Classes["12A"]);
////            teacher.AddAbsenceToStudent(teacher.CurrentLesson, 2, "ne e v chas!");
////            teacher.AddGradeToStudent(teacher.CurrentLesson, 2, 3);
////            teacher.AddNoteToStudent(teacher.CurrentLesson, 2, "losho momche!");
////            teacher.AddNoteToStudent(teacher.CurrentLesson, 2, "Pak bez domashna rabota!");
////            Assert.AreEqual(parent.getStudentRecords()[DateTime.Today].Count, 4);
////            Assert.AreEqual(parent.getStudentRecords()[DateTime.Today][3].Note, "Pak bez domashna rabota!");
////            Assert.AreEqual(parent.getStudentGrades()["German"][0].GradeOfStudent, 3);
////            Assert.AreEqual(parent.getStudentAbsences()[0].Note, "ne e v chas!");
////        }
////        [TestMethod]
////        public void LessonData()
////        {

////            EducationalFacility facility = new EducationalFacility("Konstantin Popov", 7603451234);
////            Director directorOfSchool = (Director)facility.Identify("Konstantin Popov", 7603451234);
////            directorOfSchool.CreateTeacher("Juliana Kanaziirska", 4502251231, "German");
////            directorOfSchool.CreateStudent("Dejan Svetoslavov", 9510191234);
////            directorOfSchool.CreateStudent("Hristo Vassilev", 9502245511);
////            directorOfSchool.CreateClass(12, 'A', facility.Teachers["Juliana Kanaziirska"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Hristo Vassilev"], facility.Classes["12A"]);
////            directorOfSchool.AddStudentToClass(facility.Students["Dejan Svetoslavov"], facility.Classes["12A"]);
////            /// seting the class ready for work!
////            directorOfSchool.InitializeClass(facility.Classes["12A"]);
////            //loggin teacher
////            Teacher teacher = (Teacher)facility.Identify("Juliana Kanaziirska", 4502251231);
////            teacher.CreateLesson(facility.Classes["12A"]);
////            teacher.LessonAddDescription(teacher.CurrentLesson, "urok po nemski");
////            teacher.LessonAddHomeWork(teacher.CurrentLesson, "Exercise 3");
////            // login Student
////            Student student = (Student)facility.Identify("Dejan Svetoslavov", 9510191234);
////            Assert.AreEqual(student.Class.Lessons[DateTime.Today][0].HomeWork, "Exercise 3");
////            Assert.AreEqual(student.Class.Lessons[DateTime.Today][0].Description, "urok po nemski");
////        }
////        [TestMethod]
////        public void AssistantDirectorWork()
////        {
////            EducationalFacility facility = new EducationalFacility("Petur Ivanov", 6712023451);
////            Director currentUser = (Director)facility.Identify("Petur Ivanov", 6712023451);
////            currentUser.CreateAssistantDirector("Angel Ivanov", 9504244449);
////            AssistantDirector currenUser2 = (AssistantDirector)facility.Identify("Angel Ivanov", 9504244449);
////            currenUser2.CreateTeacher("Stefan ivanov", 12423432, "Sports");
////            currenUser2.CreateClass(5, 'D', facility.Teachers["Stefan ivanov"], 2);
////            currenUser2.CreateStudent("Alex Savov", 13234234);
////            currenUser2.AddStudentToClass(facility.Students["Alex Savov"], facility.Classes["5D"]);
////            Assert.AreEqual(facility.Classes["5D"].Students.Count, 1);
////            Assert.AreEqual(facility.Classes["5D"].Teacher, facility.Teachers["Stefan ivanov"]);
////            Assert.AreEqual(facility.Classes["5D"].Students[0], facility.Students["Alex Savov"]);
////        }

////        [TestMethod]
////        [ExpectedException(typeof(InvalidOperationException), "You are not the owner of this lesson!")]
////        public void CheckIfOtherTeacherCanEditLessons()
////        {
////            EducationalFacility facility = new EducationalFacility("Steven Markov", 8703058883);
////            facility.Director.CreateTeacher("Stanislava Dimitrova", 7612044442, "English");
////            facility.Director.CreateTeacher("Yordanka Popova", 6512435655, "Biology");
////            facility.Director.CreateClass(11, 'D', facility.Teachers["Yordanka Popova"]);

////            facility.Director.CreateStudent("Pesho Popov", 6712015672);
////            facility.Director.CreateStudent("Iliqn Stefanov", 56030145567);
////            facility.Director.CreateStudent("Alexander Vasilev", 56030145567);
////            facility.Director.InitializeClass(facility.Classes["11D"]);

////            Teacher teacher = (Teacher)facility.Identify("Stanislava Dimitrova", 7612044442);
////            teacher.CreateLesson(facility.Classes["11D"]);

////            Teacher other = (Teacher)facility.Identify("Yordanka Popova", 6512435655);
////            other.AddGradeToStudent(facility.Classes["11D"].Lessons[DateTime.Today][0], 0, 4);
////        }
////    }
////}
