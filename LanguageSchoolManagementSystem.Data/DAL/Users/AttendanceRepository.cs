using LanguageSchoolManagementSystem.Data.Context;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageSchoolManagementSystem.Data.DAL.Users
{
    public class AttendanceRepository : IBaseRepository<Attendance>
    {
        private SchoolContext _schoolContext;

        public AttendanceRepository()
        {
            _schoolContext = new SchoolContext();
        }

        public void Add(Attendance entity)
        {
            _schoolContext.Attendances.Add(entity);
        }

        public void AddEntry(AttendanceEntry attendanceEntry)
        {
            _schoolContext.AttendanceEntries.Add(attendanceEntry);
        }

        public void Delete(Attendance entity)
        {
            _schoolContext.Attendances.Remove(entity);
        }

        public void Edit(Attendance entity)
        {
            _schoolContext.Attendances.Update(entity);
        }

        public List<Attendance> GetAll()
        {
            return _schoolContext.Attendances.AsNoTracking().ToList();
        }

        public Attendance GetSingle(Func<Attendance, bool> condition)
        {
            return _schoolContext.Attendances.Where(condition).First();
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }
    }
}
