namespace Slat.Core
{
    /// <summary>
    /// The api model to fetch lecturer
    /// </summary>
    public class LecturersApiModel
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
    }
}
