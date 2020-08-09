namespace Pwinty.Net.Clients
{
    using System;
    using System.Net.Http;
    using RestSharp;

    /// <summary>
    /// Base class that contains the configured Rest client.
    /// </summary>
    public abstract class ClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBase"/> class.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="apiUrl">URL of the api to connect to.</param>
        public ClientBase(string merchantId, string apiKey, Uri apiUrl)
        {
            if (string.IsNullOrWhiteSpace(merchantId))
            {
                throw new ArgumentException(
                    $"{nameof(merchantId)} is null or empty. Please enter a valid MerchantId. You can find this in " +
                    $"your settings at https://dashboard.prodigi.com/settings/integrations.",
                    nameof(merchantId));
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException(
                    $"{nameof(apiKey)} is null or empty. Please enter a valid API key. You can find this in your " +
                    $"settings at https://dashboard.prodigi.com/settings/integrations.",
                    nameof(apiKey));
            }

            if (apiUrl == null)
            {
                throw new ArgumentNullException(nameof(apiUrl), $"{nameof(apiUrl)} is null.");
            }

            this.RestClient = InitializeRestClient(merchantId, apiKey, apiUrl);
        }

        /// <summary>
        /// Gets or sets the HttpClient that performs the requests.
        /// </summary>
        protected RestClient RestClient { get; set; }

        /// <summary>
        /// Initialize the RestClient with the user-provided information.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="apiUrl">URL of the api to connect to.</param>
        /// <returns>The initialized HttpClient.</returns>
        private static RestClient InitializeRestClient(string merchantId, string apiKey, Uri apiUrl)
        {
            var restClient = new RestClient(apiUrl);

            restClient.AddDefaultHeader("X-Pwinty-MerchantId", merchantId);
            restClient.AddDefaultHeader("X-Pwinty-REST-API-Key", apiKey);

            return restClient;
        }
    }
}
