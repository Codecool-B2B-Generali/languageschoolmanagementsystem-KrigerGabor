using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageSchoolManagementSystem.Data.DAL.Users
{
    public class StudentRepository : IBaseRepository<Student>
    {
        private SchoolContext _schoolContext;

        public StudentRepository()
        {
            _schoolContext = new SchoolContext();
        }
        public void Add(Student entity)
        {
            _schoolContext.Students
                .Add(entity);
        }

        public void Delete(Student entity)
        {
            _schoolContext.Students
                .Remove(entity);
        }

        public void Edit(Student entity)
        {
            _schoolContext.Students
                .Update(entity);
        }

        public List<Student> GetAll()
        {
            return _schoolContext.Students.AsNoTracking().ToList();
        }

        public Student GetSingle(Func<Student, bool> condition)
        {
            return _schoolContext.Students
                .Include(student => student.CurrentClass)
                .Where(condition).First();
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }

        public void AddAttendance(Attendance attendance)
        {
            _schoolContext.Attendances.Add(attendance);
            _schoolContext.SaveChanges();
        }
    }
}
