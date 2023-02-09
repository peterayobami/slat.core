namespace Slat.Core
{
    /// <summary>
    /// The api model to create a student
    /// </summary>
    public class CreateStudentApiModel
    {
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
        /// The matric number of the student
        /// </summary>
        public string MatricNo { get; set; }
    }
}
