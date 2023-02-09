using System.ComponentModel.DataAnnotations.Schema;

namespace Slat.Core
{
    /// <summary>
    /// The lecturer courses datababse table representational model
    /// </summary>
    public class LecturerCoursesDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The course id foreign key index
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The lecturer id foreign key index
        /// </summary>
        public string LecturerId { get; set; }

        /// <summary>
        /// The course entity relational model
        /// </summary>
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }

        /// <summary>
        /// The lecturer entity relational model
        /// </summary>
        [ForeignKey(nameof(LecturerId))]
        public LecturersDataModel Lecturer { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
