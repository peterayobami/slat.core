namespace Slat.Core
{
    /// <summary>
    /// The students database table representational model
    /// </summary>
    public class StudentsDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The email address of the student
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The photo of the student encoded in base 64
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// The matric no of this student
        /// </summary>
        public string MatricNo { get; set; }

        /// <summary>
        /// The student's registered entity relational model
        /// </summary>
        public List<StudentCoursesDataModel> RegisteredCourses { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
