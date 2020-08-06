namespace Pwinty.Net.Model
{
    using System.Collections.Generic;
    using Pwinty.Net.Enums.Errors;

    /// <summary>
    /// Validity of an order.
    /// </summary>
    public class OrderValidity
    {
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
        public List<PhotoValidity> InvalidPhotos { get; private set; }

        /// <summary>
        /// Gets the top level errors associated with the order.
        /// </summary>
        public OrderValidityErrors GeneralErrors { get; private set; }
    }
}
