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
            var surname = _inputSystem.FetchStringValue("provider surname");

            var accessLevel = _inputSystem.FetchStringValue("Provide access level");

            return accessLevel switch
            {
                "Teacher" => new Teacher {Name = name, Surname = surname, AccessLevel = AccessLevel.Teacher},
                "Student" => new Student {Name = name, Surname = surname, AccessLevel = AccessLevel.Teacher},
                _ => new User {Name = name, Surname = surname, AccessLevel = AccessLevel.Admin}
            };
        }
    }
}
