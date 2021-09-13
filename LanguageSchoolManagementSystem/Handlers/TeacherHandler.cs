using LanguageSchoolManagementSystem.Data.DAL;
using LanguageSchoolManagementSystem.Data.DAL.Users;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using LanguageSchoolManagementSystem.Utils;
using LanguageSchoolManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageSchoolManagementSystem.Handlers
{
    public class TeacherHandler : BaseHandler<Teacher>
    {
        public TeacherHandler(IBaseRepository<Teacher> repositoryTeacher, ClassHandler classHandler, StudentHandler studentHandler, IInputSystem inputManager, IView<Teacher> view, IMenuDisplay menuDisplay)
            : base (inputManager, view, menuDisplay)
        {
            throw new NotImplementedException();
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
