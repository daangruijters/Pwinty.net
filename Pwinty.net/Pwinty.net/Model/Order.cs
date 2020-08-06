namespace Pwinty.Net.Model
{
    using Pwinty.Net.Enums;

    /// <summary>
    /// Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the ID of the order.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order can be cancelled (depends on fulfilment partner and status
        /// of the order).
        /// </summary>
        public bool CanCancel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order can be placed on hold (depends on fulfilment partner and
        /// status of the order).
        /// </summary>
        public bool CanHold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order shipping address/method can be udpated (depends on
        /// fulfilment partner and status of the order).
        /// </summary>
        public bool CanUpdateShipping { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the images in the order are updateable (depends on fulfilment
        /// partner and status of the order).
        /// </summary>
        public bool CanUpdateImages { get; set; }

        /// <summary>
        /// Gets or sets the name of to whom the order will be addressed.
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or sets the first line of recipient address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of recipient address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the town/city of recipient address.
        /// </summary>
        public string AddressTownOrCity { get; set; }

        /// <summary>
        /// Gets or sets the state (US), county (UK) or region of recipient address.
        /// </summary>
        public string StateOrCountry { get; set; }

        /// <summary>
        /// Gets or sets the postal/Zipcode of recipient address.
        /// </summary>
        public string PostalOrZipCode { get; set; }

        /// <summary>
        /// Gets or sets the two-letter country code of the recipient.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the status of order.
        /// </summary>
        public OrderStatus Status { get; set; }
    }
}
