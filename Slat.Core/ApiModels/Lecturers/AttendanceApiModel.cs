namespace Slat.Core
{
    /// <summary>
    /// The api model to mark a student's attendance
    /// </summary>
    public class AttendanceApiModel
    {
        /// <summary>
        /// The student's matric number
        /// </summary>
        public string MatricNo { get; set; }

        /// <summary>
        /// The id of lecture this attendance belongs to
        /// </summary>
        public string LectureId { get; set; }
    }
}
