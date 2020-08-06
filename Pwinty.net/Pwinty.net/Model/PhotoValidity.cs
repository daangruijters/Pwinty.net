namespace Pwinty.Net.Model
{
    using Pwinty.Net.Enums.Errors;

    /// <summary>
    /// Validity of a photo.
    /// </summary>
    public class PhotoValidity
    {
        /// <summary>
        /// Gets the ID of the order.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets any errors associated with this image.
        /// </summary>
        public PhotoValidityErrors Errors { get; private set; }

        /// <summary>
        /// Gets any warnings associated with this image.
        /// </summary>
        public PhotoValidityWarnings Warnings { get; private set; }
    }
}
