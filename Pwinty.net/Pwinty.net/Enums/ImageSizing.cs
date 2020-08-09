namespace Pwinty.Net.Enums
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// How an image should be resized when printing.
    /// </summary>
    public enum ImageSizing
    {
        /// <summary>
        /// Your image will be centred and cropped so that it exactly fits the aspect ratio (height divided by width)
        /// of the printing area of the product you chose. Your image will cover all of the product print area.
        /// </summary>
        Crop,

        /// <summary>
        /// Your image will be shrunk until the whole image fits within the print area of the product, whilst retaining
        /// the aspect ratio of your image. This will usually mean there is white space at the top/bottom or left/right
        /// edges.
        /// </summary>
        ShrinkToFit,

        /// <summary>
        /// Your image will be resized so that it completely fills the print area of the product. If the aspect ratio of
        /// your image is different to that of the printing area, your image will be stretched or squashed to fit.
        /// </summary>
        ShrinkToExactFit,
    }
}
