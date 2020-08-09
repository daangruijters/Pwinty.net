namespace Pwinty.Net.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Interfaces;
    using Pwinty.Net.Model;
    using RestSharp;

    /// <inheritdoc/>
    public class CountryClient : ClientBase, ICountryClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryClient"/> class.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="apiUrl">URL of the api to connect to.</param>
        public CountryClient(string merchantId, string apiKey, Uri apiUrl)
            : base(merchantId, apiKey, apiUrl)
        {
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Country>> ListAllAsync()
        {
            var request = new RestRequest("countries");

            var response = await this.RestClient
                .ExecuteAsync<IEnumerable<CountryDto>>(request)
                .ConfigureAwait(false);

            if (response.IsSuccessful)
            {
                return response.Data.Select(dto => new Country(dto));
            }
            else
            {
                return null;
            }
        }
    }
}
