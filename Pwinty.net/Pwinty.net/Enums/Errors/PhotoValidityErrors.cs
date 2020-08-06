namespace Pwinty.Net.Enums.Errors
{
    using System;

    /// <summary>
    /// Reasons why a photo is invalid.
    /// </summary>
    [Flags]
    public enum PhotoValidityErrors : short
    {
        /// <summary>
        /// We could not download an image from the supplied URL, after multiple attempts.
        /// </summary>
        FileCouldNotBeDownloaded = 0,

        /// <summary>
        /// You haven't submitted an image URL nor have you POSTed an image.
        /// </summary>
        NoImageFile = 1,

        /// <summary>
        /// Image file format is not valid.
        /// </summary>
        InvalidImageFile = 2,

        /// <summary>
        /// Number of copies of the image has been set to zero.
        /// </summary>
        ZeroCopies = 4,
    }
}