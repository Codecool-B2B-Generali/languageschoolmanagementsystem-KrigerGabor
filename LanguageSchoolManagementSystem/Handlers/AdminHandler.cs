using System;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Views;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class AdminHandler : BaseHandler<User>
    {
        public AdminHandler(StudentHandler studentHandler, TeacherHandler techerHandler, IMenuDisplay display, IInputSystem input) : base (input, new AdminConsoleView(), display)
        {
            throw new NotImplementedException();
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
