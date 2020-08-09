namespace Pwinty.Net.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Interfaces;
    using Pwinty.Net.Model;
    using RestSharp;

    /// <inheritdoc/>
    public class CatalogueClient : ClientBase, ICatalogueClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogueClient"/> class.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="apiUrl">URL of the api to connect to.</param>
        public CatalogueClient(string merchantId, string apiKey, Uri apiUrl)
            : base(merchantId, apiKey, apiUrl)
        {
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ProductPrice>> FetchPricesAsync(Country countryCode, string[] skus)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode), $"{nameof(countryCode)} is null.");
            }

            if ((skus == null) || (skus.Length == 0))
            {
                throw new ArgumentException($"{nameof(skus)} is null or empty.", nameof(skus));
            }

            var request = new RestRequest($"catalogue/prodigi%20direct/destination/{countryCode.IsoCode}/prices");

            var response = await this.RestClient
                .ExecuteAsync<IEnumerable<ProductPriceDto>>(request);

            if (response.IsSuccessful)
            {
                return response.Data.Select(dto => new ProductPrice(dto));
            }
            else
            {
                return null;
            }
        }
    }
}
