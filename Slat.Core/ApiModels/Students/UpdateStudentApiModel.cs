namespace Slat.Core
{
    /// <summary>
    /// The api model to update the student's photo
    /// </summary>
    public class UpdateStudentPhotoApiModel
    {
        /// <summary>
        /// The unique id of the student
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The base 64 encoded photo
        /// </summary>
        public string EncodedPhoto { get; set; }
    }
}
