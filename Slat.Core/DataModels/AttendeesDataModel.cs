using System.ComponentModel.DataAnnotations.Schema;

namespace Slat.Core
{
    /// <summary>
    /// The attendees database table representational model
    /// </summary>
    public class AttendeesDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The lecture id foreign key index
        /// </summary>
        public string LectureId { get; set; }

        /// <summary>
        /// The student id foreign key index
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// The lecture relational entity model
        /// </summary>
        [ForeignKey(nameof(LectureId))]
        public LecturesDataModel Lecture { get; set; }

        /// <summary>
        /// The student relational entity model
        /// </summary>
        [ForeignKey(nameof(StudentId))]
        public StudentsDataModel Student { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
