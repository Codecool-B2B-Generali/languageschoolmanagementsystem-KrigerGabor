using LanguageSchoolManagementSystem.Data.Entities.Users;

namespace LanguageSchoolManagementSystem.Utils.Factories
{
    public class UserFactory
    {
        private readonly IInputSystem _inputSystem;

        public UserFactory(IInputSystem inputSystem)
        {
            _inputSystem = inputSystem;
        }

        public User GetNewUser()
        {
            var name = _inputSystem.FetchStringValue("Provide name");
            var surname = _inputSystem.FetchStringValue("Provider surname");
            int age = 0;
            try
            {
                age = _inputSystem.FetchIntValue("Provider age");
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Input not valid! Try again! \n");
                GetNewUser();
            }
            var accessLevel = _inputSystem.FetchStringValue("Provide access level");

            return accessLevel switch
            {
                "Teacher" => new Teacher { Name = name, Surname = surname, Age = age, AccessLevel = AccessLevel.Teacher },
                "Student" => new Student { Name = name, Surname = surname, Age = age, AccessLevel = AccessLevel.Student },
                "Admin" => new Admin { Name = name, Surname = surname, Age = age, AccessLevel = AccessLevel.Admin },
                _ => throw new System.NotImplementedException()
            };
        }
    }
}
