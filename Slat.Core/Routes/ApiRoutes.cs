using Microsoft.Extensions.Logging.Console;

namespace Slat.Core
{
    /// <summary>
    /// The routes to api endpoints
    /// </summary>
    public class ApiRoutes
    {
        /// <summary>
        /// The route to the FetchStudent endpoint
        /// </summary>
        public const string FetchStudent = "api/student/fetch";

        /// <summary>
        /// The route to the FetchStudents endpoint
        /// </summary>
        public const string FetchStudents = "api/students/fetch";

        /// <summary>
        /// The route to the FetchLecturer endpoint
        /// </summary>
        public const string FetchLecturer = "api/lecturer/fetch";

        /// <summary>
        /// The route to the FetchLecturer endpoint
        /// </summary>
        public const string FetchLecturerByEmail = "api/lecturer/fetch-by-email";

        /// <summary>
        /// The route to the FetchLecturers endpoint
        /// </summary>
        public const string FetchLecturers = "api/lecturers/fetch";

        /// <summary>
        /// The route to the CreateStudent endpoint
        /// </summary>
        public const string CreateStudent = "api/student/create";

        /// <summary>
        /// The route to the CreateStudents endpoint
        /// </summary>
        public const string CreateStudents = "api/students/create"; 

        /// <summary>
        /// The route to the CreateLecturer endpoint
        /// </summary>
        public const string CreateLecturer = "api/lecturer/create";

        /// <summary>
        /// The route to the CreateLecturers endpoint
        /// </summary>
        public const string CreateLecturers = "api/lecturers/create";

        /// <summary>
        /// The route to the UpdateStudentPhoto endpoint
        /// </summary>
        public const string UpdateStudentPhoto = "api/student-photo/update";

        /// <summary>
        /// The route to the FetchCourse endpoint
        /// </summary>
        public const string FetchCourse = "api/course/fetch";

        /// <summary>
        /// The route to the FetchCourses endpoint
        /// </summary>
        public const string FetchCourses = "api/courses/fetch";

        /// <summary>
        /// The route to the CreateCourse endpoint
        /// </summary>
        public const string CreateCourse = "api/course/create";

        /// <summary>
        /// The route to the CreateCourses endpoint
        /// </summary>
        public const string CreateCourses = "api/courses/create";

        /// <summary>
        /// The route to the CreateLecture endpoint
        /// </summary>
        public const string CreateLecture = "api/lecture/create";

        /// <summary>
        /// The route to the VerifyStudent endpoint
        /// </summary>
        public const string VerifyStudent = "api/student/verify";

        /// <summary>
        /// The route to the MarkAttendance endpoint
        /// </summary>
        public const string MarkAttendance = "api/attendance/mark";

        /// <summary>
        /// The route to the AssignLecturerToCourse endpoint
        /// </summary>
        public const string AssignLecturerToCourse = "api/lecturer/assign-course";

        /// <summary>
        /// The route to the RegisterStudentCourse endpoint
        /// </summary>
        public const string RegisterStudentCourse = "api/student-course/register";

        /// <summary>
        /// The route to the ValidateStudentAccess endpoint
        /// </summary>
        public const string ValidateStudentAccess = "api/student-access/validate";

        /// <summary>
        /// The route to the VerifyStudentAccess endpoint
        /// </summary>
        public const string VerifyStudentAccess = "api/student-access/verify";

        /// <summary>
        /// The route to the ValidateLecturerAccess endpoint
        /// </summary>
        public const string ValidateLecturerAccess = "api/lecturer-access/validate";

        /// <summary>
        /// The route to the VerifyLecturerAccess endpoint
        /// </summary>
        public const string VerifyLecturerAccess = "api/lecturer-access/verify";

        /// <summary>
        /// The route to the FetchLecturerAttendee endpoint
        /// </summary>
        public const string FetchLectureAttendees = "api/lecture-attendees/fetch";

        /// <summary>
        /// The route to the FetchLecturerAttendanceRecords endpoint
        /// </summary>
        public const string FetchLecturerAttendanceRecords = "api/lecturer-attendance-records/fetch";

        /// <summary>
        /// The route to the RetrieveStudentsAttendanceRanking endpoint
        /// </summary>
        public const string RetrieveStudentsAttendanceRanking = "api/student-attendance-ranking/fetch";

        /// <summary>
        /// The route to the RetrieveCoursesAttendanceRanking endpoint
        /// </summary>
        public const string RetrieveCoursesAttendanceRanking = "api/course-attendance-ranking/fetch";

        /// <summary>
        /// The route to the RetrieveLecturersAttendanceRanking endpoint
        /// </summary>
        public const string RetrieveLecturersAttendanceRanking = "api/lecturer-attendance-ranking/fetch";
    }
}
