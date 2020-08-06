#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line
namespace Pwinty.Net.DTO
{
    using System.Collections.Generic;

    internal class ShippingInfoDto
    {
        public int Price { get; set; }
        public List<ShipmentDto> Shipments { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
