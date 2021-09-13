using System;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Views
{
    public class MenuDisplay : IMenuDisplay
    {
        public void PrintOptions(List<string> options)
        {
            Console.WriteLine("~~~~~~ Options available ~~~~~~");
            options.ForEach(Console.WriteLine);
        }

        public void PrintMany<T>(List<T> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintMessage(string content)
        {
            Console.WriteLine(content);
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
