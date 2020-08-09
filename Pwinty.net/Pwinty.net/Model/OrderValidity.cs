namespace Pwinty.Net.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Enums.Errors;

    /// <summary>
    /// Validity of an order.
    /// </summary>
    public class OrderValidity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderValidity"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the class on.</param>
        internal OrderValidity(OrderValidityDto dto)
        {
            this.Id = dto.Id;
            this.IsValid = dto.IsValid;
            this.InvalidPhotos = dto.InvalidPhotos.Select(dto => new PhotoValidity(dto));
            this.GeneralErrors = (OrderValidityErrors)Enum.Parse(typeof(OrderValidityErrors), string.Join(',', dto.GeneralErrors));
        }

        /// <summary>
        /// Gets the ID of the order.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the order is valid. Submission will it succeed if you submit it.
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets the invalid images in the order.
        /// </summary>
        public IEnumerable<PhotoValidity> InvalidPhotos { get; private set; }

        /// <summary>
        /// Gets the top level errors associated with the order.
        /// </summary>
        public OrderValidityErrors GeneralErrors { get; private set; }
    }
}
