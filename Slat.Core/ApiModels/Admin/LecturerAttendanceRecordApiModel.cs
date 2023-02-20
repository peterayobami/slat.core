namespace Slat.Core
{
    public class LecturerAttendanceRecordApiModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LecturerEmail { get; set; }

        public int AttendanceCount { get; set; }

        public IEnumerable<LectureAttendanceRecordApiModel> Lectures { get; set; }
    }
}
