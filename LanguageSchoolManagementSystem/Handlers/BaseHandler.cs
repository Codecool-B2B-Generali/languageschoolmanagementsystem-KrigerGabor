using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Views;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Handlers
{
    public abstract class BaseHandler<T> : IUserDataManager
    {
        protected IInputSystem _inputManager;
        protected IView<T> _view;
        protected IMenuDisplay _display;
        protected string[] _availableCommands;

        protected BaseHandler(IInputSystem inputManager, IView<T> view, IMenuDisplay display)
        {
            _inputManager = inputManager;
            _view = view;
            _display = display;
        }

        public void Run()
        {
            string userInput = null;

            while (userInput != "quit")
            {
                _display.PrintOptions(new List<string>(_availableCommands));
                userInput = _inputManager.FetchStringValue("Provide option");

                RunFeatureBasedOn(userInput);

                _inputManager.FetchStringValue("Press enter to proceed...");
                _display.ClearScreen();
            }
        }

        public abstract void RunFeatureBasedOn(string userInput);
    }
}
