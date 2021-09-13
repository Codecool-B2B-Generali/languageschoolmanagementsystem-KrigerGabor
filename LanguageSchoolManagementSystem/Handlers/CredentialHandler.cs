using System;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Utils.Factories;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class CredentialHandler
    {
        public CredentialHandler(UserFactory userFactory, IInputSystem inputSystem)
        {
            throw new NotImplementedException();
        }

        public User Login()
        {
            return new User();
        }

        internal void RegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
