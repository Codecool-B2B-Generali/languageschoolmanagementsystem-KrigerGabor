using System;

namespace LanguageSchoolManagementSystem.Data.Entities.Users
{
    public class AttendanceEntry
    {
        public Guid AttendanceEntryId { get; set; }
        public DateTime TimeEntry { get; set; }
        public AttendanceStatus Status { get; set; }

        public AttendanceEntry()
        {

        }

        public AttendanceEntry(DateTime timeEntry, AttendanceStatus status)
        {
            TimeEntry = timeEntry;
            Status = status;
        }
    }
}
