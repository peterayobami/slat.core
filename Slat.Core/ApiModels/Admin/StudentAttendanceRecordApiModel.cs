namespace Slat.Core
{
    /// <summary>
    /// Student attendance record api model
    /// </summary>
    public class StudentAttendanceRecordApiModel
    {
        /// <summary>
        /// The first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The matric number of the student
        /// </summary>
        public string MatricNo { get; set; }

        /// <summary>
        /// The email address of the student
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The total attendance of the student
        /// </summary>
        public int AttendanceCount { get; set; }
    }
}
