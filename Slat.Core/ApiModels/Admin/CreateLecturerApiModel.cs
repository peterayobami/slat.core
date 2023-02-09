namespace Slat.Core
{
    /// <summary>
    /// The api model for creating lecturer(s)
    /// </summary>
    public class CreateLecturerApiModel
    {
        /// <summary>
        /// The email of the lecturer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The first name of the lecturer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the lecturer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The photo of the lecturer
        /// </summary>
        public string Photo { get; set; }
    }

    public class LecturerApiModel
    {
        /// <summary>
        /// The unique id of this lecturer
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The email of the lecturer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The first name of the lecturer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the lecturer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The photo of the lecturer
        /// </summary>
        public string Photo { get; set; }
    }
}
