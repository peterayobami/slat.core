namespace Slat.Core
{
    public class CourseAttendanceRecordApiModel
    {
        public string CourseTitle { get; set; }

        public string CourseCode { get; set; }

        public int CourseUnit { get; set; }

        public int AttendanceCount { get; set; }

        public IEnumerable<LectureAttendanceRecordApiModel> Lectures { get; set; }
    }

    public class LectureAttendanceRecordApiModel
    {
        public string LectureTitle { get; set; }

        public int AttendanceCount { get; set; }
    }
}
