using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Views
{
    public interface IMenuDisplay
    {
        void ClearScreen();
        void PrintMany<T>(List<T> entities);
        void PrintMessage(string content);
        void PrintOptions(List<string> options);
    }
}