namespace Slat.Core
{
    /// <summary>
    /// The api model to register students' courses
    /// </summary>
    public class RegisterStudentCoursesApiModel
    {
        /// <summary>
        /// The student's id
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// The id of courses to register for the student
        /// </summary>
        public string[] CourseIds { get; set; }
    }
}
