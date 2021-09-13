using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Data.Context.Seeders
{
    public static class SchoolSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher()
            {
                UserID = Guid.Parse("ed7344a1-0333-4db8-88de-52b9739bf6f4"),
                Name = "Adrian",
                Surname = "Starzyk",
                Age = 27,
                ClassesAssigned = new List<Class>(),
                AccessLevel = AccessLevel.Teacher,
                Credentials = null,

            });
            teachers.Add(new Teacher()
            {
                UserID = Guid.Parse("5ecffa2e-cd9e-48ab-9091-9d0ceb133254"),
                Name = "Kamil",
                Surname = "Wójcik",
                Age = 37,
                ClassesAssigned = new List<Class>(),
                AccessLevel = AccessLevel.Teacher,
                Credentials = null,

            });

            List<Student> students = new List<Student>();

            List<CredentialsContainer> credentials = new List<CredentialsContainer>();
            credentials.Add(new CredentialsContainer()
            {
                CredentialsId = Guid.Parse("61ed95e5-3623-4bf5-bc06-c0ff482bc23f"),
                Email = "D@starzyk.pl",
                Login = "Dodos93",
                Password = "Dodos93"
            });
            credentials.Add(new CredentialsContainer()
            {
                CredentialsId = Guid.Parse("34781758-f9e1-48c2-b632-693304019e66"),
                Email = "K@wojcik.pl",
                Login = "Wojcik93",
                Password = "Wojcik93"
            });
            credentials.Add(new CredentialsContainer()
            {
                CredentialsId = Guid.Parse("9637922f-6201-4723-886a-add460e867ec"),
                Email = "Jarek",
                Login = "Jarek",
                Password = "Jarek"
            });
            
            List<Class> classes = new List<Class>();
            classes.Add(new Class()
            {
                ClassId = Guid.Parse("692e3dc0-862b-4cdc-874e-ea3692becc78"),
                ClassName = "3A BEST OF",
                StudentsInClass = new List<Student>()
            });

            //students.Add(new Student()
            //{
            //    UserID = Guid.Parse("93751fe6-c475-41ea-9f9f-388573234482"),
            //    Name = "Jarek",
            //    Surname = "Kowalski",
            //    AccessLevel = AccessLevel.Student,
            //    Age = 18,
            //    Attendance = null,
            //    CurrentClass = null,
            //    Credentials = null,
                
            //});
            //students[0].Credentials = credentials[2];

            builder.Entity<Teacher>().HasData(teachers);
            //builder.Entity<Student>().HasData(students);
            builder.Entity<CredentialsContainer>().HasData(credentials);
            
            builder.Entity<Class>().HasData(classes);


            
        }
    }
}
