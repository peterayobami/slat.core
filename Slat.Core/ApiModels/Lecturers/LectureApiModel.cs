using System.ComponentModel.DataAnnotations.Schema;

namespace Slat.Core
{
    /// <summary>
    /// The lecture api model
    /// </summary>
    public class LectureApiModel
    {
        /// <summary>
        /// The unique id for this course
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
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }
    }
}
