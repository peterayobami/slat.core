namespace Slat.Core
{
    /// <summary>
    /// The api model to create a lecture
    /// </summary>
    public class CreateLectureApiModel
    {
        /// <summary>
        /// The id of the lecturer trying to create this lecture
        /// </summary>
        public string LecturerId { get; set; }

        /// <summary>
        /// The id of the course of this lecture
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The title of this lecture
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of this lecture
        /// </summary>
        public string Description { get; set; }
    }
}
