namespace Slat.Core
{
    /// <summary>
    /// The lecturers database table representational model
    /// </summary>
    public class LecturersDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The email address of the lecturer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the lecturer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The photo of the lecturer encoded in base 64
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// The lecturer's access code
        /// </summary>
        public int AccessCode { get; set; }

        /// <summary>
        /// The lectures relational entity model
        /// </summary>
        public List<LecturesDataModel> Lectures { get; set; }

        /// <summary>
        /// The lecturer courses entity relational model
        /// </summary>
        public List<LecturerCoursesDataModel> Courses { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
