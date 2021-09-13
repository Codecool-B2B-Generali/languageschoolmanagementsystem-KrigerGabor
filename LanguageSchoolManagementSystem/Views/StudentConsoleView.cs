using LanguageSchoolManagementSystem.Data.Entities.Users;
using System.Collections.Generic;
using static System.Console;

namespace LanguageSchoolManagementSystem.Views
{
    internal class StudentConsoleView : IView<Student>
    {
        public void DisplayAll(List<Student> entities)
        {
            entities.ForEach(DisplaySingle);
        }

        public void DisplaySingle(Student entity)
        {
            WriteLine($"Student: {entity.UserID} Name {entity.Name} Surname {entity.Surname} ");
        }
    }
}
