namespace Pwinty.Net.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Object that shows how an order will be shipped.
    /// </summary>
    public class ShippingInfo
    {
        /// <summary>
        /// Gets or sets the cost of the entire shipment.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets an array of shipment objects.
        /// </summary>
        public List<Shipment> Shipments { get; set; }
    }
}
