using System;
using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.DAL.Users;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Utils.Factories;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class CredentialHandler
    {
        private UserFactory userFactory;
        private IInputSystem inputSystem;

        public CredentialHandler(UserFactory userFactory, IInputSystem inputSystem)
        {
            this.userFactory = userFactory;
            this.inputSystem = inputSystem;
        }

        public User Login()
        {
            return new Admin();
        }

        internal void RegisterUser()
        {
            var createdUser = userFactory.GetNewUser();

            switch (createdUser.AccessLevel)
            {
                case AccessLevel.Admin:
                    var admin = new AdminRepository();
                    admin.Add((Admin) createdUser);
                    admin.Save();
                    break;
                case AccessLevel.Teacher:
                    var teacher = new TeacherRepository();
                    teacher.Add((Teacher) createdUser);
                    teacher.Save();
                    break;
                case AccessLevel.Student:
                    var student = new StudentRepository();
                    student.Add((Student)createdUser);
                    student.Save();
                    break;
                default:
                    Console.WriteLine("User input not correct, try again! \n");
                    RegisterUser();
                    break;
            }
        }
    }
}
