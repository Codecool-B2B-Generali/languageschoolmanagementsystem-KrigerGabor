using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageSchoolManagementSystem.Data.DAL.Credentials
{
    public class CredentialRepository : IBaseRepository<CredentialsContainer>
    {
        private SchoolContext _schoolContext;

        public CredentialRepository()
        {
            _schoolContext = new SchoolContext(); 
        }

        public void Add(CredentialsContainer entity)
        {
            _schoolContext.CredentialsContainers.Add(entity);
        }

        public void Delete(CredentialsContainer entity)
        {
            _schoolContext.CredentialsContainers.Remove(entity);
        }

        public void Edit(CredentialsContainer entity)
        {
            _schoolContext.CredentialsContainers.Update(entity);
        }

        public List<CredentialsContainer> GetAll()
        {
            return _schoolContext.CredentialsContainers.AsNoTracking().ToList();
        }

        public CredentialsContainer GetSingle(Func<CredentialsContainer, bool> condition)
        {
            return _schoolContext.CredentialsContainers.Where(condition).FirstOrDefault();
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }
    }
}
