using System.ComponentModel.DataAnnotations.Schema;

namespace Slat.Core
{
    /// <summary>
    /// The student courses database table representational model
    /// </summary>
    public class StudentCoursesDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The student id foreign key index
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// The course id foreign key index
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The student entity relational model
        /// </summary>
        [ForeignKey(nameof(StudentId))]
        public StudentsDataModel Student { get; set; }

        /// <summary>
        /// The course entity relational model
        /// </summary>
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
