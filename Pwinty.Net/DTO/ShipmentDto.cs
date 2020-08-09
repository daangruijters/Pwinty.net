#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line
namespace Pwinty.Net.DTO
{
    using System;

    internal class ShipmentDto
    {
        public string ShipmentId { get; set; }
        public bool IsTracked { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public DateTime EarliestEstimatedArrivalDate { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
