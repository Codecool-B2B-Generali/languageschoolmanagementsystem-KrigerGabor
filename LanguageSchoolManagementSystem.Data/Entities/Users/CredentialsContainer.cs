using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public class CredentialsContainer
    {   
        [Key]
        public Guid CredentialsId { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public CredentialsContainer()
        {

        }

        public CredentialsContainer(string email, string login, string password)
        {
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
