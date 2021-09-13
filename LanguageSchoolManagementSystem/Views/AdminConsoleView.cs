using LanguageSchoolManagementSystem.Data.Entities.Users;
using System.Collections.Generic;
using static System.Console;

namespace LanguageSchoolManagementSystem.Views
{
    internal class AdminConsoleView : IView<User>
    {
        public void DisplayAll(List<User> entities)
        {
            entities.ForEach(DisplaySingle);
        }

        public void DisplaySingle(User entity)
        {
            WriteLine($"Admin: {entity.Name}");
        }
    }
}
