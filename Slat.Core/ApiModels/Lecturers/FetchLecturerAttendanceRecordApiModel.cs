namespace Slat.Core
{
    /// <summary>
    /// The api model to fetch lecturer attendance record
    /// </summary>
    public class FetchLecturerAttendanceRecordApiModel
    {
        /// <summary>
        /// The id of the lecturer
        /// </summary>
        public List<CoursesApiModel> Courses { get; set; }
    }

    public class CoursesApiModel
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
        public IEnumerable<CourseLectureApiModel> Lectures { get; set; }

        /// <summary>
        /// The point in time this course was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }
    }

    public class CourseLectureApiModel
    {
        /// <summary>
        /// The unique id for this lecture
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The title of this lecture
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of this lecture
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The collection lecture attendees
        /// </summary>
        public IEnumerable<LectureAttendeeApiModel> Attendees { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }
    }

    public class LectureAttendeeApiModel
    {
        public string MatricNo { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
