using LanguageSchoolManagementSystem.Data.Context.Seeders;
using LanguageSchoolManagementSystem.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace LanguageSchoolManagementSystem.Data.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<CredentialsContainer> CredentialsContainers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceEntry> AttendanceEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=HUGPWL01WS;Database=LanguageSchool;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }

    }
}
