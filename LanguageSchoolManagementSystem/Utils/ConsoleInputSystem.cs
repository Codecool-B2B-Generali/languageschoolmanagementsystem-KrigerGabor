using static System.Console;

namespace LanguageSchoolManagementSystem.Utils
{
    internal class ConsoleInputSystem : IInputSystem
    {
        public string FetchStringValue(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }
    }
}
