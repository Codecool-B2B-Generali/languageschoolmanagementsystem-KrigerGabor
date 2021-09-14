﻿using System;

namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public abstract class User
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public CredentialsContainer Credentials { get; set; }

        public User()
        {

        }

        public User(string name, string surname, AccessLevel accessLevel)
        {
            Name = name;
            Surname = surname;
            AccessLevel = accessLevel;
        }

        public User(string name, string surname, int age, AccessLevel accessLevel)
        {
            Name = name;
            Surname = surname;
            Age = age;
            AccessLevel = accessLevel;
        }
    }
}
