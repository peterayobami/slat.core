namespace Slat.Core
{
    /// <summary>
    /// The warning result object api model
    /// </summary>
    public class WarningResult
    {
        /// <summary>
        /// The list of warnings for this <see cref="WarningResult"/> instance
        /// </summary>
        public List<IssuesApiModel> Warnings { get; set; }
    }
}
