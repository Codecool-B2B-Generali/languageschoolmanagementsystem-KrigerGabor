using System;
using static System.Console;

namespace LanguageSchoolManagementSystem.Utils
{
    internal class ConsoleInputSystem : IInputSystem
    {
        public int FetchIntValue(string prompt)
        {
            WriteLine(prompt);
            try
            {
                return int.Parse(ReadLine());
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public string FetchStringValue(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }
    }
}
