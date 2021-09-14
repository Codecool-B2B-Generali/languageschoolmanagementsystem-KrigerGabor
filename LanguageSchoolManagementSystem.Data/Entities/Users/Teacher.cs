using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public class Teacher : User
    {
        public ICollection<Class> ClassesAssigned { get; set; }

        public Teacher()
        {
            ClassesAssigned = new List<Class>();
        }
    }
}
