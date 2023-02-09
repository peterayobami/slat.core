namespace Slat.Core
{
    /// <summary>
    /// The api model for student verification
    /// </summary>
    public class VerifyStudentApiModel
    {
        /// <summary>
        /// The course id to verify student against
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// The student's matric number
        /// </summary>
        public string MatricNumber { get; set; }
    }
}
