using System;
using System.Linq;
using ElectronicStudentJournal.Models;

namespace ElectronicStudentJournal
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Users.Any()) return; // Skip jeśli dane już istnieją

            // === USERS ===
            var user1 = new User { Login = "marek.w", Password = "password1", AccessLevel = 0 }; // Student
            var user2 = new User { Login = "karolina.z", Password = "password2", AccessLevel = 0 }; // Student
            var user3 = new User { Login = "jan.k", Password = "password3", AccessLevel = 1 }; // Teacher
            var user4 = new User { Login = "anna.n", Password = "password4", AccessLevel = 1 }; // Teacher
            var user5 = new User { Login = "qwe", Password = "qwe", AccessLevel = 2 };   // Admin

            context.Users.AddRange(user1, user2, user3, user4, user5);
            context.SaveChanges();

            // === TEACHERS ===
            var teacher1 = new Teacher
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                NumerPesel = "12345678901",
                NumerTelefonu = "500100100",
                AdresZamieszkania = "Warszawa",
                UserId = user3.Id
            };

            var teacher2 = new Teacher
            {
                FirstName = "Anna",
                LastName = "Nowak",
                NumerPesel = "98765432109",
                NumerTelefonu = "500200200",
                AdresZamieszkania = "Kraków",
                UserId = user4.Id
            };

            context.Teachers.AddRange(teacher1, teacher2);

            // === SUBJECTS ===
            var subject1 = new Subject { Name = "Matematyka" };
            var subject2 = new Subject { Name = "Fizyka" };
            context.Subjects.AddRange(subject1, subject2);

            // === CLASSES ===
            var class1 = new Class { Name = "1A" };
            var class2 = new Class { Name = "2B" };
            context.Classes.AddRange(class1, class2);
            context.SaveChanges();

            // === TEACHING ASSIGNMENTS ===
            var ta1 = new TeachingAssignment { TeacherId = teacher1.Id, SubjectId = subject1.Id, ClassId = class1.Id };
            var ta2 = new TeachingAssignment { TeacherId = teacher2.Id, SubjectId = subject2.Id, ClassId = class1.Id };
            var ta3 = new TeachingAssignment { TeacherId = teacher1.Id, SubjectId = subject1.Id, ClassId = class2.Id };
            var ta4 = new TeachingAssignment { TeacherId = teacher2.Id, SubjectId = subject2.Id, ClassId = class2.Id };
            context.TeachingAssignments.AddRange(ta1, ta2, ta3, ta4);
            context.SaveChanges();

            // === STUDENTS ===
            var student1 = new Student
            {
                FirstName = "Marek",
                LastName = "Wiśniewski",
                NumerPesel = "11111111111",
                NumerTelefonu = "600300300",
                AdresZamieszkania = "Łódź",
                ClassId = class1.Id,
                UserId = user1.Id
            };

            var student2 = new Student
            {
                FirstName = "Karolina",
                LastName = "Zielińska",
                NumerPesel = "22222222222",
                NumerTelefonu = "600400400",
                AdresZamieszkania = "Poznań",
                ClassId = class2.Id,
                UserId = user2.Id
            };

            context.Students.AddRange(student1, student2);
            context.SaveChanges();

            // === GRADES ===
            var grade1 = new Grade
            {
                Value = 5,
                Description = "Sprawdzian 1",
                Date = DateTime.Now.AddDays(-10),
                StudentId = student1.Id,
                TeachingAssignmentId = ta1.Id
            };

            var grade2 = new Grade
            {
                Value = 3,
                Description = "Kartkówka",
                Date = DateTime.Now.AddDays(-5),
                StudentId = student2.Id,
                TeachingAssignmentId = ta2.Id
            };

            context.Grades.AddRange(grade1, grade2);

            // === ADMIN ===
            var admin = new Admin
            {
                UserId = user5.Id
            };

            context.Admins.Add(admin);

            context.SaveChanges();
        }
    }
}
