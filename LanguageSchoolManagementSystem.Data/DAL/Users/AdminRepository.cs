using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageSchoolManagementSystem.Data.DAL.Users
{
    public class AdminRepository : IBaseRepository<Admin>
    {
        private SchoolContext _schoolContext;

        public AdminRepository()
        {
            _schoolContext = new SchoolContext();
        }

        public void Add(Admin entity)
        {
            _schoolContext.Admins
                .Add(entity);
        }

        public void Delete(Admin entity)
        {
            _schoolContext.Admins
                .Remove(entity);
        }

        public void Edit(Admin entity)
        {
            _schoolContext.Admins
                .Update(entity);
        }

        public List<Admin> GetAll()
        {
            return _schoolContext.Admins.AsNoTracking().ToList();
        }

        public Admin GetSingle(Func<Admin, bool> condition)
        {
            return _schoolContext.Admins
                .Where(condition).First();
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }
    }
}
