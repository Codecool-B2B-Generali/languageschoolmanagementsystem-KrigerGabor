using System;
using LanguageSchoolManagementSystem.Data.DAL;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Views;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class ClassHandler : BaseHandler<Class>
    {
        public ClassHandler(IBaseRepository<Class> repositoryClass, IInputSystem inputManager, IMenuDisplay display)
            : base (inputManager, new ClassConsoleView(), display)
        {
            throw new NotImplementedException();
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
