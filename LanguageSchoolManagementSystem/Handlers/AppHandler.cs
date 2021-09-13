using LanguageSchoolManagementSystem.Data.DAL.Users;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Utils.Factories;
using LanguageSchoolManagementSystem.Views;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class AppHandler
    {
        private IUserDataManager _currentDataHandler;
        private CredentialHandler _credentialHandler;
        private IInputSystem _input;

        public AppHandler()
        {
            _input = new ConsoleInputSystem();
            _credentialHandler = new CredentialHandler(new UserFactory(_input), _input);
        }

        private void AssignUserBasedOnCredential()
        {
            var loggedUser = _credentialHandler.Login();

            switch (loggedUser.AccessLevel)
            {

                case AccessLevel.Admin:
                    _currentDataHandler = new AdminHandler(GetNewStudentHandler(), GetNewTeacherHandler(), new MenuDisplay(), new ConsoleInputSystem());
                    break;
                case AccessLevel.Teacher:
                    _currentDataHandler = GetNewTeacherHandler();
                    break;
                case AccessLevel.Student:
                    _currentDataHandler = GetNewStudentHandler();
                    break;
                default:
                    break;
            }
        }

        public StudentHandler GetNewStudentHandler()
        {
            return new StudentHandler(new ClassRepository(),
                new StudentRepository(),
                _input,
                new StudentConsoleView(), 
                new MenuDisplay());
        }

        public TeacherHandler GetNewTeacherHandler()
        {
            return new TeacherHandler(new TeacherRepository(),
                GetNewClassHandler(),
                GetNewStudentHandler(),
                _input,
                new TeacherConsoleView(),
                new MenuDisplay()); 
        }

        public ClassHandler GetNewClassHandler()
        {
            return new ClassHandler(new ClassRepository(), new ConsoleInputSystem(), new MenuDisplay());
        }

        public void Run()
        {
            System.Console.WriteLine("Welcome to system. Do you want to [R]egister or [L]ogin");
            var userInput = _input.FetchStringValue("Enter your option:");

            switch (userInput)
            {
                case "Register":
                    _credentialHandler.RegisterUser();
                    break;
                case "Login":
                    AssignUserBasedOnCredential();
                    _currentDataHandler.Run();
                    break;
                default:
                    _input.FetchStringValue("Incorrect option - press enter to proceed");
                    break;
            }         
        }
    }
}
