using System.ComponentModel.DataAnnotations.Schema;

namespace Slat.Core
{
    /// <summary>
    /// The lectures database table representational model
    /// </summary>
    public class LecturesDataModel
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
        /// The lecturer's id foreign key index
        /// </summary>
        public string LecturerId { get; set; }

        /// <summary>
        /// The title of this lecture
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of this lecture
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The course relational entity model
        /// </summary>
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }

        /// <summary>
        /// The lecturer relational entity model
        /// </summary>
        [ForeignKey(nameof(LecturerId))]
        public LecturersDataModel Lecturer { get; set; }

        /// <summary>
        /// The attendees entity relational model
        /// </summary>
        public List<AttendeesDataModel> Attendees { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
