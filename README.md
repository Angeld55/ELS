check description.txt for instructuons! Unit tests included!

5 type of users:
Director
AssistantDirector
Teacher
Student
Parent

Educational facility
in constructor --> We create the Director

through the facility we have access to all users,classes, teachers and students

The director have this funcitons:
->CreateClass
->CreateTeacher
->CreateStudent
->CreateParent
->AddStudentToClass
->InitializeClass (after all students are in the class , we should initilize it! 
This sets their numbers so the class is ready!It's recommended not to add students after the initilization)
->CreateAssistantDirector (same functions as the director)

Every teacher can:
->CreateLesson(also editing one, adding homework and description)
->AddGradeToStudent
->AddAbsenceToStudent
->AddNoteToStudent
->ExcuseAbsenceToStudent(only for students from his class) 
->InitializeClass (same as directors)

-->Login should be made through EducationalFacility.Identify <-----
