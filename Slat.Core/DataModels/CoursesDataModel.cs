namespace Slat.Core
{
    /// <summary>
    /// The courses database table representational model
    /// </summary>
    public class CoursesDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The course code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The course title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course unit
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// Description of this course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The lectures entity relational model
        /// </summary>
        public List<LecturesDataModel> Lectures { get; set; }

        /// <summary>
        /// The lecturer courses entity relational model
        /// </summary>
        public List<LecturerCoursesDataModel> Lecturers { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
