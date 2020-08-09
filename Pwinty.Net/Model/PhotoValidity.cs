namespace Pwinty.Net.Model
{
    using System;
    using System.Linq;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Enums.Errors;

    /// <summary>
    /// Validity of a photo.
    /// </summary>
    public class PhotoValidity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoValidity"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the class on.</param>
        internal PhotoValidity(PhotoValidityDto dto)
        {
            this.Id = dto.Id;
            this.Errors = (PhotoValidityErrors)Enum.Parse(typeof(PhotoValidityErrors), string.Join(',', dto.Errors));
            this.Warnings = (PhotoValidityWarnings)Enum.Parse(typeof(PhotoValidityWarnings), string.Join(',', dto.Warnings));
        }

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
