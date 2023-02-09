namespace Slat.Core
{
    public class AssignLecturerToCourseApiModel
    {
        /// <summary>
        /// The id of the course to assign
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The id of the lecturer the course is assigned unto
        /// </summary>
        public string LecturerId { get; set; }
    }
}
