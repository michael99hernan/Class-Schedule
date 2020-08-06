using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Schedule.Models;
using SchedulePicker.Models;

namespace SchedulePicker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> Courses { get; set; }
        public DbSet<PreReq> PreReqs { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MajorCourse> MajorCourses { get; set; }
        public DbSet<CoReq> CoReqs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
            builder.Entity<PreReq>().HasKey(x => x.Id);
            builder.Entity<CoReq>().HasKey(x => x.Id);
                   
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SchedulePicker.Models.StudentCourse> StudentCourses { get; set; }
        public DbSet<Schedule.Models.Course> Course { get; set; }
    }
}
