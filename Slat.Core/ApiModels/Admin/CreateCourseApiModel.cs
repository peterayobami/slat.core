namespace Slat.Core
{
    /// <summary>
    /// The api model to create courses
    /// </summary>
    public class CreateCourseApiModel
    {
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
    }

    public class CourseApiModel
    {
        /// <summary>
        /// The id of this course
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
    }
}
