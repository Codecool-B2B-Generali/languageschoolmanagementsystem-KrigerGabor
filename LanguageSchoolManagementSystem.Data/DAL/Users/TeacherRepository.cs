using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LanguageSchoolManagementSystem.Data.DAL.Users
{
    public class TeacherRepository : IBaseRepository<Teacher>
    {
        private SchoolContext SchoolContext;

        public TeacherRepository()
        {
            SchoolContext = new SchoolContext();
        }

        public void Add(Teacher entity)
        {
            SchoolContext.Teachers
                .Add(entity);
        }

        public void Delete(Teacher entity)
        {
            SchoolContext.Teachers.Remove(entity);
        }

        public void Edit(Teacher entity)
        {
            SchoolContext.Teachers
                .Update(entity);
        }

        public List<Teacher> GetAll()
        {
            return SchoolContext.Teachers
                .AsNoTracking()
                .ToList();
        }

        public Teacher GetSingle(Func<Teacher,bool> selectCondition)
        {
            return SchoolContext.Teachers
                .Where(selectCondition)
                .First();
        }

        public void Save()
        {
            SchoolContext.SaveChanges();
        }
    }
}
