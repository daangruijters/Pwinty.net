namespace Pwinty.Net.Model
{
    using System;
    using Pwinty.Net.DTO;

    /// <summary>
    /// Shipment.
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the class on.</param>
        internal Shipment(ShipmentDto dto)
        {
            this.ShipmentId = dto.ShipmentId;
            this.IsTracked = dto.IsTracked;
            this.TrackingNumber = dto.TrackingNumber;
            this.TrackingUrl = new Uri(dto.TrackingUrl);
            this.EarliestEstimatedArrivalDate = dto.EarliestEstimatedArrivalDate;
        }

        /// <summary>
        /// Gets the unique identifier for this shipment. Null if order hasn't been submitted.
        /// </summary>
        public string ShipmentId { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the order will be tracked.
        /// </summary>
        public bool IsTracked { get; private set; }

        /// <summary>
        /// Gets the tracking number, when available.
        /// </summary>
        public string TrackingNumber { get; private set; }

        /// <summary>
        /// Gets the tracking URL, when available.
        /// </summary>
        public Uri TrackingUrl { get; private set; }

        /// <summary>
        /// Gets the estimated earliest arrival of shipment.
        /// </summary>
        public DateTime EarliestEstimatedArrivalDate { get; private set; }
    }
}
