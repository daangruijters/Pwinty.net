﻿namespace Pwinty.Net.Interface
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
        public Task<Order> GetAsync(string id);

        /// <summary>
        /// Retrieves multiple orders, most recent first. Note that calls that return potentially more than one result
        /// may omit shipping information from the results if the order hasn't yet been processed.
        /// </summary>
        /// <param name="limit">Number of orders to return. Default 100, max 250.</param>
        /// <param name="start">Start position used for paginating order list. Default 0.</param>
        /// <returns>Order objects.</returns>
        public Task<IEnumerable<Order>> ListAsync(ushort? limit = 100, ushort? start = 0);

        /// <summary>
        /// Create an order.
        /// </summary>
        /// <param name="order">Order to create.</param>
        /// <returns>Created order.</returns>
        public Task<Order> CreateAsync(Order order);

        /// <summary>
        /// Update an order.
        /// </summary>
        /// <param name="order">Order to update..</param>
        /// <returns>Updated order.</returns>
        public Task<Order> UpdateAsync(Order order);

        /// <summary>
        /// Before submitting an order, you can validate it to make sure it's good to go, or we can tell you why it isn't.
        /// </summary>
        /// <param name="orderId">Id of the order to validate.</param>
        /// <returns>Object containing the validity of an order.</returns>
        public Task<OrderValidity> ValidateAsync(int orderId);

        /// <summary>
        /// Cancel an order.
        /// </summary>
        /// <param name="orderId">Id of the order to cancel.</param>
        /// <returns></returns>
        public Task CancelAsync(int orderId);

        /// <summary>
        /// Stage an order by setting the status to <see cref="Enums.OrderStatus.AwaitingPayment"/>.
        /// </summary>
        /// <param name="orderId">Id of the order to stage.</param>
        /// <returns></returns>
        public Task StageAsync(int orderId);

        /// <summary>
        /// Submit an order.
        /// </summary>
        /// <param name="orderId">Id of the order to submit.</param>
        /// <returns></returns>
        public Task SubmitAsync(int orderId);
    }
}
