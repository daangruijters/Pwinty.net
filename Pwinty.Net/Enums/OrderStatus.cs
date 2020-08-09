namespace Pwinty.Net.Enums
{
    /// <summary>
    /// Status of order.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Order is not yet submitted.
        /// </summary>
        NotYetSubmitted,

        /// <summary>
        /// Order is submitted.
        /// </summary>
        Submitted,

        /// <summary>
        /// Order is awaiting payment.
        /// </summary>
        AwaitingPayment,

        /// <summary>
        /// Order is complete.
        /// </summary>
        Complete,

        /// <summary>
        /// Order is cancelled
        /// </summary>
        Cancelled,
    }
}
