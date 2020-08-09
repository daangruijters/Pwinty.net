namespace Pwinty.Net.Enums.Errors
{
    using System;

    /// <summary>
    /// Reasons why an order is invalid.
    /// </summary>
    [Flags]
    public enum OrderValidityErrors
    {
        /// <summary>
        /// You cannot submit any more orders until you have paid off the balance outstanding on your account.
        /// </summary>
        AccountBalanceInsufficient,

        /// <summary>
        /// One or more of the images in the order has errors- see the photos object for more information.
        /// </summary>
        ItemsContainingErrors,

        /// <summary>
        /// The order has no images associated with it, so cannot be submitted.
        /// </summary>
        NoItemsInOrder,

        /// <summary>
        /// The recipient address fields on the order were not properly set. You must supply at least address1,
        /// addressTownOrCity, postalOrZipCode and countryCode.
        /// </summary>
        PostalAddressNotSet,
    }
}
