namespace Slat.Core
{
    public class IssuesApiModel
    {
        /// <summary>
        /// The HTTP status code applicable to this error
        /// </summary>
        public dynamic Status { get; set; }

        /// <summary>
        /// An application-specific error code
        /// </summary>
        public dynamic Code { get; set; }

        /// <summary>
        /// A short summary of the error
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Explanation of the error
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// An object containing references to the source of the error
        /// </summary>
        public Source Source { get; set; }
    }

    /// <summary>
    /// Contains references to the source of the error
    /// </summary>
    public class Source
    {
        /// <summary>
        /// A JSON Pointer [RFC6901] to the associated entity in the request document
        /// </summary>
        public string Pointer { get; set; }

        /// <summary>
        /// A string indicating which URI query parameter caused the issue
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// A string indicating an example of the right value
        /// </summary>
        public string Example { get; set; }
    }
}
