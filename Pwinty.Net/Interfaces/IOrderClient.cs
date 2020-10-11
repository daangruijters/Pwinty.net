namespace Pwinty.Net.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Pwinty.Net.Model;

    /// <summary>
    /// Abstraction of the <see cref="OrderClient"/>.
    /// </summary>
    public interface IOrderClient
    {
        /// <summary>
        /// Get an existing order.
        /// </summary>
        /// <param name="id">Id of the order to get.</param>
        /// <returns>Order.</returns>
        Task<Order> GetAsync(string id);

        /// <summary>
        /// Retrieves multiple orders, most recent first. Note that calls that return potentially more than one result
        /// may omit shipping information from the results if the order hasn't yet been processed.
        /// </summary>
        /// <param name="limit">Number of orders to return. Default 100, max 250.</param>
        /// <param name="start">Start position used for paginating order list. Default 0.</param>
        /// <returns>Order objects.</returns>
        Task<IEnumerable<Order>> ListAsync(ushort? limit = 100, ushort? start = 0);

        /// <summary>
        /// Create an order.
        /// </summary>
        /// <param name="order">Order to create.</param>
        /// <returns>Created order.</returns>
        Task<Order> CreateAsync(Order order);

        /// <summary>
        /// Update an order.
        /// </summary>
        /// <param name="order">Order to update..</param>
        /// <returns>Updated order.</returns>
        Task<Order> UpdateAsync(Order order);

        /// <summary>
        /// Before submitting an order, you can validate it to make sure it's good to go, or we can tell you why it isn't.
        /// </summary>
        /// <param name="orderId">Id of the order to validate.</param>
        /// <returns>Object containing the validity of an order.</returns>
        Task<OrderValidity> ValidateAsync(int orderId);

        /// <summary>
        /// Cancel an order.
        /// </summary>
        /// <param name="orderId">Id of the order to cancel.</param>
        /// <returns>Task that cancels an order.</returns>
        Task CancelAsync(int orderId);

        /// <summary>
        /// Stage an order by setting the status to <see cref="Enums.OrderStatus.AwaitingPayment"/>.
        /// </summary>
        /// <param name="orderId">Id of the order to stage.</param>
        /// <returns>Task that sets the status of an order to AwaitingPayment.</returns>
        Task StageAsync(int orderId);

        /// <summary>
        /// Submit an order.
        /// </summary>
        /// <param name="orderId">Id of the order to submit.</param>
        /// <returns>Task that submits an order.</returns>
        Task SubmitAsync(int orderId);

        /// <summary>
        /// Add an image to an order.
        /// </summary>
        /// <param name="orderId">Id of the order to add the image to.</param>
        /// <param name="image">Image to add to the order.</param>
        /// <returns>The added image.</returns>
        Task<Image> AddImage(int orderId, Image image);

        /// <summary>
        /// Add multiple images to an order.
        /// </summary>
        /// <param name="orderId">Id of the order to add the image to.</param>
        /// <param name="images">Images to add to the order.</param>
        /// <returns>The added images.</returns>
        Task<IEnumerable<Image>> AddImages(int orderId, IEnumerable<Image> images);
    }
}
