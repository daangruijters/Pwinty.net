namespace Pwinty.Net.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Enums;
    using Pwinty.Net.Interfaces;
    using Pwinty.Net.Model;
    using RestSharp;

    /// <inheritdoc/>
    public class OrderClient : ClientBase, IOrderClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderClient"/> class.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="apiUrl">URL of the api to connect to.</param>
        public OrderClient(string merchantId, string apiKey, Uri apiUrl)
            : base(merchantId, apiKey, apiUrl)
        {
        }

        /// <inheritdoc/>
        public async Task<Order> GetAsync(string id)
        {
            var request = new RestRequest($"/orders/{id}", Method.GET);

            var response = await this.RestClient
                .ExecuteGetAsync<OrderDto>(request);

            if (response.IsSuccessful)
            {
                return new Order(response.Data);
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Order>> ListAsync(ushort? limit = 100, ushort? start = 0)
        {
            var request = new RestRequest("orders", Method.GET);

            if (limit.HasValue)
            {
                request.AddParameter("limit", limit);
            }

            if (start.HasValue)
            {
                request.AddParameter("start", start);
            }

            var response = await this.RestClient
                .ExecuteAsync<IEnumerable<OrderDto>>(request);

            if (response.IsSuccessful)
            {
                return response.Data.Select(dto => new Order(dto));
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<Order> CreateAsync(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), $"{nameof(order)} is null.");
            }

            var request = new RestRequest("orders", Method.POST);

            request.AddJsonBody(order);

            var response = await this.RestClient
                .ExecuteAsync<OrderDto>(request);

            if (response.IsSuccessful)
            {
                return new Order(response.Data);
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<Order> UpdateAsync(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), $"{nameof(order)} is null.");
            }

            var request = new RestRequest($"orders/{order.Id}", Method.PUT);

            request.AddJsonBody(order);

            var response = await this.RestClient
                .ExecuteAsync<OrderDto>(request);

            if (response.IsSuccessful)
            {
                return new Order(response.Data);
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<OrderValidity> ValidateAsync(int orderId)
        {
            var request = new RestRequest($"orders/{orderId}/SubmissionStatus", Method.GET);

            var response = await this.RestClient
                .ExecuteAsync<OrderValidityDto>(request);

            if (response.IsSuccessful)
            {
                return new OrderValidity(response.Data);
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task CancelAsync(int orderId)
        {
            await this.UpdateStatus(orderId, OrderStatus.Cancelled);
        }

        /// <inheritdoc/>
        public async Task StageAsync(int orderId)
        {
            await this.UpdateStatus(orderId, OrderStatus.AwaitingPayment);
        }

        /// <inheritdoc/>
        public async Task SubmitAsync(int orderId)
        {
            await this.UpdateStatus(orderId, OrderStatus.Submitted);
        }

        /// <inheritdoc/>
        public async Task<Image> AddImage(int orderId, Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), $"{nameof(image)} is null.");
            }

            var request = new RestRequest($"orders/{orderId}/images", Method.POST);

            var response = await this.RestClient
                .ExecuteAsync<ImageDto>(request);

            if (response.IsSuccessful)
            {
                return new Image(response.Data);
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Image>> AddImages(int orderId, IEnumerable<Image> images)
        {
            if (images == null || !images.Any())
            {
                throw new ArgumentNullException(nameof(images), $"{nameof(images)} is null.");
            }

            var request = new RestRequest($"orders/{orderId}/images/batch", Method.POST);

            var response = await this.RestClient
                .ExecuteAsync<ImagesDto>(request);

            if (response.IsSuccessful)
            {
                return response.Data.Items.Select(dto => new Image(dto));
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Evaluate whether an OrderStatus is valid to use when updating an order.
        /// </summary>
        /// <param name="status">Status to evaluate.</param>
        /// <returns>A value indicating whether the orderstatus is valid.</returns>
        private static bool IsValidUpdateStatus(OrderStatus status)
        {
            return status == OrderStatus.Cancelled
                || status == OrderStatus.AwaitingPayment
                || status == OrderStatus.Submitted;
        }

        /// <summary>
        /// Update the status of an order.
        /// </summary>
        /// <param name="orderId">Order to update the status of.</param>
        /// <param name="status">Status to update the order to.</param>
        /// <returns>A value indicating whether the status update was successful.</returns>
        private async Task UpdateStatus(int orderId, OrderStatus status)
        {
            if (!IsValidUpdateStatus(status))
            {
                throw new ArgumentException("Status is not a valid update status.", nameof(status));
            }

            var request = new RestRequest($"orders/{orderId}/status", Method.POST);

            var response = await this.RestClient
                .ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                throw new NotImplementedException("#3 Add exceptions");
            }
        }
    }
}
