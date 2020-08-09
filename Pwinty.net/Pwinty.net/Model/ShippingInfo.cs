namespace Pwinty.Net.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using Pwinty.Net.DTO;

    /// <summary>
    /// Object that shows how an order will be shipped.
    /// </summary>
    public class ShippingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingInfo"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the class on.</param>
        internal ShippingInfo(ShippingInfoDto dto)
        {
            this.Price = dto.Price;
            this.Shipments = dto.Shipments.Select(dto => new Shipment(dto));
        }

        /// <summary>
        /// Gets or sets the cost of the entire shipment.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets an array of shipment objects.
        /// </summary>
        public IEnumerable<Shipment> Shipments { get; set; }
    }
}
