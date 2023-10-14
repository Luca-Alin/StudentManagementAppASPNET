using StudentManagementApp.Data.Enums;
using StudentManagementApp.Models;
using StudentManagementApp.Models.Student;

namespace StudentManagementApp.Data;

public static class Seed
{
    public static void SeedData(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

        context!.Database.EnsureCreated();

        //Add students
        var student1 = new StudentModel
        {
            FirstName = "Teddy",
            LastName = "Smith",
            Email = "teddysmith@fun-university.com",
            DateOfBirth = new DateTime(2000, 10, 10),
            PhoneNumber = "704-555-5555",
            AddressModel = new AddressModel
            {
                Country = "USA",
                City = "Charlotte",
                Street = "Main St",
                Number = 123
            },
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password")
        };

        var student2 = new StudentModel
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@fun-university.com",
            DateOfBirth = new DateTime(2000, 10, 10),
            PhoneNumber = "704-555-5555",
            AddressModel = new AddressModel
            {
                Country = "USA",
                City = "Charlotte",
                Street = "Main St",
                Number = 124
            },
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password")
        };

        var student3 = new StudentModel
        {
            FirstName = "Jane",
            LastName = "Doe",
            Email = "janedoe@fun-iniversity.com",
            DateOfBirth = new DateTime(2000, 10, 10),
            PhoneNumber = "704-555-5555",
            AddressModel = new AddressModel
            {
                Country = "USA",
                City = "Charlotte",
                Street = "Main St",
                Number = 125
            },
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password")
        };

        var student4 = new StudentModel
        {
            FirstName = "Bob",
            LastName = "Smith",
            Email = "bobsmith@fun-univsity.com",
            DateOfBirth = new DateTime(2000, 10, 10),
            PhoneNumber = "704-555-5555",
            AddressModel = new AddressModel
            {
                Country = "USA",
                City = "Charlotte",
                Street = "Main St",
                Number = 126
            },
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password")
        };

        if (!context.Students.Any())
        {
            context.Students.AddRange(new List<StudentModel>
            {
                student1, student2, student3, student4
            });
            context.SaveChanges();
        }


        //Add faculties
        var faculty1 = new Faculty
        {
            Name = "Computer Science"
        };

        var faculty2 = new Faculty
        {
            Name = "Mathematics"
        };

        if (!context.Faculties.Any())
            context.Faculties.AddRange(new List<Faculty>
            {
                faculty1, faculty2
            });

        //Add courses
        AddCoursesFaculty1(context, faculty1);


        // var facultyCourses1 = new FacultyCoursesModel
        // {
        //     Faculty = faculty1,
        //     Course1 = course1,
        //     Course2 = course2,
        //     Course3 = course3,
        //     Course4 = course4,
        //     Course5 = course5,
        //     Course6 = course6,
        //     Course7 = course7,
        //     Semester = 1,
        //     Year = 1
        // };
        //
        // if (!context.FacultyCoursesModel.Any())
        // {
        //     context.FacultyCoursesModel.AddRange(new List<FacultyCoursesModel>
        //     {
        //         facultyCourses1
        //     });
        //     context.SaveChanges();
        // }

        var whatFacultyAStudentAttends1 = new WhatFacultyAStudentAttendsModel
        {
            Student = student1,
            Faculty = faculty1
        };

        var whatFacultyAStudentAttends2 = new WhatFacultyAStudentAttendsModel
        {
            Student = student2,
            Faculty = faculty1
        };

        var whatFacultyAStudentAttends3 = new WhatFacultyAStudentAttendsModel
        {
            Student = student3,
            Faculty = faculty1
        };

        var whatFacultyAStudentAttends4 = new WhatFacultyAStudentAttendsModel
        {
            Student = student4,
            Faculty = faculty1
        };


        if (!context.WhatFacultyAStudentAttends.Any())
        {
            context.WhatFacultyAStudentAttends.AddRange(new List<WhatFacultyAStudentAttendsModel>
            {
                whatFacultyAStudentAttends1, whatFacultyAStudentAttends2, whatFacultyAStudentAttends3,
                whatFacultyAStudentAttends4
            });
            context.SaveChanges();
        }

        List<CourseModel> courses = context.Courses.ToList();
        List<StudentModel> students = context.Students.ToList();
        List<GradeModel> grades = new List<GradeModel>();
        Random random = new Random();
        foreach (var s in students)
        {
            foreach (var c in courses)
            {
                var grade = new GradeModel
                {
                    Value = (byte) random.Next(1, 10),
                    Student = s,
                    CourseModel = c
                };
                grades.Add(grade);
            }
        }

        if (!context.Grades.Any())
        {
            context.AddRange(grades);
            context.SaveChanges();
        }
    }
        
    private static void AddCoursesFaculty1(AppDbContext context, Faculty faculty)
    {
        if (!context.Courses.Any())
        {
            context.Courses.AddRange(new List<CourseModel>
            {
                new()
                {
                    Faculty = faculty,
                    Code = "0639",
                    Name = "Fundamentals of programming",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 0,
                    LaboratoryHours = 3,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 7
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0258",
                    Name = "Computer systems architecture",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 0,
                    LaboratoryHours = 2,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 6
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0010",
                    Name = "Mathematical Analysis",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 2,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Colloquy,
                    Credits = 5
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0712",
                    Name = "Algebraic foundations of computer science",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 2,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 5
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0713",
                    Name = "Mathematical and computational logic",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 2,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 6
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0465",
                    Name = "English I",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 0,
                    SeminarHours = 1,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 2
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0651",
                    Name = "Physical Education I",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.One,
                    Year = Year.One,
                    CourseHours = 0,
                    SeminarHours = 1,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.AdmittedOrRejected,
                    Credits = 3
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0276",
                    Name = "Operating Systems",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 0,
                    LaboratoryHours = 2,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 6
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0272",
                    Name = "Object-oriented programming",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 0,
                    LaboratoryHours = 3,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 7
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0714",
                    Name = "Fundamental algorithms",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 0,
                    LaboratoryHours = 2,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 5
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0256",
                    Name = "Algorithmic graphs",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 2,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 5
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0076",
                    Name = "Computational geometry",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 2,
                    SeminarHours = 2,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 5
                },
                new()
                {
                    Faculty = faculty,
                    Code = "",
                    Name = "English Language II",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 0,
                    SeminarHours = 1,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 2
                },
                new()
                {
                    Faculty = faculty,
                    Code = "0652",
                    Name = "Physical Education II",
                    CourseType = CourseType.Compulsory,
                    Semester = Semester.Two,
                    Year = Year.One,
                    CourseHours = 0,
                    SeminarHours = 1,
                    LaboratoryHours = 0,
                    ProjectHours = 0,
                    PracticeHours = 0,
                    ExaminationType = ExaminationType.Exam,
                    Credits = 3
                }            });
            context.SaveChanges();
        }
    }
}