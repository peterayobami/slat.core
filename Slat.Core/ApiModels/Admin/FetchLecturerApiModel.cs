namespace Slat.Core
{
    /// <summary>
    /// The api model to fetch lecturer
    /// </summary>
    public class FetchLecturerApiModel
    {
        /// <summary>
        /// The unique id of the lecturer
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The first name of the lecturer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the lecturer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email of the lecturer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The courses that this lecturer takes
        /// </summary>
        public List<CourseApiModel> Courses { get; set; }

        /// <summary>
        /// The photo of the lecturer
        /// </summary>
        public string Photo { get; set; }
    }
}
