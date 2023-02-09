namespace Slat.Core
{
    /// <summary>
    /// The api model to fetch courses
    /// </summary>
    public class FetchCoursesApiModel
    {
        /// <summary>
        /// The unique id of the course
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The title of this course
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// The code of this course
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// The unit of this course
        /// </summary>
        public int CourseUnit { get; set; }

        /// <summary>
        /// The description of this course
        /// </summary>
        public string CourseDescription { get; set; }

        /// <summary>
        /// The lecturers that handle this course
        /// </summary>
        public List<LecturerApiModel> Lecturers { get; set; }

        /// <summary>
        /// The point in time this course was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }
    }
}
