using LanguageSchoolManagementSystem.Data.Entities.Users;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Views
{
    public class ClassConsoleView : IView<Class>
    {
        public void DisplayAll(List<Class> entities)
        {
            entities.ForEach(DisplaySingle);
        }

        public void DisplaySingle(Class entity)
        {
            System.Console.WriteLine(entity);
        }
    }
}
