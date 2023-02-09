namespace Slat.Core
{
    /// <summary>
    /// Error result object api model
    /// </summary>
    public class ErrorResult
    {
        /// <summary>
        /// The list of errors for this <see cref="ErrorResult"/> instance
        /// </summary>
        public List<IssuesApiModel> Errors { get; set; }
    }
}
