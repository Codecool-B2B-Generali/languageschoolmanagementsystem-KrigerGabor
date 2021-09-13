using System;
using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public class Attendance
    {
        public Guid AttendanceId { get; set; }
        public ICollection<AttendanceEntry> AttendanceHistory { get; set; }

        public Guid StudentOwnerID { get; set; }

        public Attendance()
        {   
            AttendanceHistory = new List<AttendanceEntry>();
        }
    }
}
