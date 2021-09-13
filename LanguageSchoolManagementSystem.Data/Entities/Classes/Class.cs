using System;
using System.Collections.Generic;


namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> StudentsInClass { get; set; }

        public Class()
        {
            StudentsInClass = new List<Student>();
        }
    }
}
