using LanguageSchoolManagementSystem.Data.Entities.Users;
using System;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Views
{
    internal class TeacherConsoleView : IView<Teacher>
    {
        public void DisplayAll(List<Teacher> entities)
        {
            entities.ForEach(DisplaySingle);
        }

        public void DisplaySingle(Teacher entity)
        {
            Console.WriteLine($"Teacher  {entity.Name} {entity.Surname} ");
        }
    }
}
