namespace Pwinty.Net.Model
{
    using System;

    /// <summary>
    /// Shipment.
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// Gets or sets the unique identifier for this shipment. Null if order hasn't been submitted.
        /// </summary>
        public string ShipmentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order will be tracked.
        /// </summary>
        public bool IsTracked { get; set; }

        /// <summary>
        /// Gets or sets the tracking number, when available.
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets the tracking URL, when available.
        /// </summary>
        public Uri TrackingUrl { get; set; }

        /// <summary>
        /// Gets or sets the estimated earliest arrival of shipment.
        /// </summary>
        public DateTime EarliestEstimatedArrivalDate { get; set; }
    }
}
