namespace Slat.Core
{
    /// <summary>
    /// The admins database table representational model
    /// </summary>
    public class AdminsDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The point in time this record was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
