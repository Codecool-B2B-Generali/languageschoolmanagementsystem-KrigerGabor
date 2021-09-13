using LanguageSchoolManagementSystem.Data.DAL;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Views;
using System;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class StudentHandler : BaseHandler<Student>
    {
        public StudentHandler(IBaseRepository<Class> repositoryClass, IBaseRepository<Student> repositoryStudent, IInputSystem inputManager, IView<Student> view, IMenuDisplay menuDisplay) 
            : base(inputManager, view, menuDisplay)
        {
            throw new NotImplementedException();
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
