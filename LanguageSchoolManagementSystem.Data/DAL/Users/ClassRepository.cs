using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageSchoolManagementSystem.Data.DAL.Users
{
    public class ClassRepository : IBaseRepository<Class>
    {
        private SchoolContext _schoolContext;


        public ClassRepository()
        {
            _schoolContext = new SchoolContext();
        }

        public void Add(Class entity)
        {
            _schoolContext.Classes.Add(entity);
        }

        public void Delete(Class entity)
        {
            _schoolContext.Classes.Remove(entity);
        }

        public void Edit(Class entity)
        {
            _schoolContext.Classes.Update(entity);
        }

        public List<Class> GetAll()
        {
            return _schoolContext.Classes.AsNoTracking().ToList();
        }

        public Class GetSingle(Func<Class, bool> condition)
        {
            return _schoolContext.Classes.Include(classMembers => classMembers.StudentsInClass).First(condition);
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }
    }
}
