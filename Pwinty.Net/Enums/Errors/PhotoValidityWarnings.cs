namespace Pwinty.Net.Enums.Errors
{
    using System;

    /// <summary>
    /// Warnings about a photo.
    /// </summary>
    [Flags]
    public enum PhotoValidityWarnings
    {
        /// <summary>
        /// The image supplied does not match the aspect ratio of the printing area of the product. We will need to crop
        /// or resize it.
        /// </summary>
        CroppingWillOccur,

        /// <summary>
        /// The image supplied is below the recommended resolution.
        /// </summary>
        PictureSizeTooSmall,

        /// <summary>
        /// You've supplied an image with a URL, but we haven't downloaded it yet. This means we can't check the image
        /// size at the moment.
        /// </summary>
        CouldNotValidateImageSize,

        /// <summary>
        /// You've supplied an image with a URL, but we haven't downloaded it yet. This means we can't check the aspect
        /// ratio at the moment.
        /// </summary>
        CouldNotValidateAspectRatio,

        /// <summary>
        /// One of the product attributes set on the image is invalid.
        /// </summary>
        AttributeNotValid,
    }
}
