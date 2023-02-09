using Microsoft.EntityFrameworkCore;

namespace Slat.Core
{
    /// <summary>
    /// The database model for the application
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="options">The database options</param>
        /// <param name="operationalStoreOptions">The operational store options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// The admins database table
        /// </summary>
        public DbSet<AdminsDataModel> Admins { get; set; }

        /// <summary>
        /// The students database table
        /// </summary>
        public DbSet<StudentsDataModel> Students { get; set; }

        /// <summary>
        /// The lecturers database table
        /// </summary>
        public DbSet<LecturersDataModel> Lecturers { get; set; }

        public DbSet<AttendeesDataModel> Attendees { get; set; }

        public DbSet<LecturesDataModel> Lectures { get; set; }

        public DbSet<CoursesDataModel> Courses { get; set; }

        public DbSet<LecturerCoursesDataModel> LecturerCourses { get; set; }

        public DbSet<StudentCoursesDataModel> StudentCourses { get; set; }
    }
}
