namespace Pwinty.Net.Clients
{
    using System;
    using Pwinty.Net.Interface;

    /// <inheritdoc/>
    public class PwintyClient : IPwintyClient
    {
        /// <summary>
        /// URL of the production environment API.
        /// </summary>
        private const string ENDPOINTURLLIVE = "https://api.pwinty.com/v3.0/";

        /// <summary>
        /// URL of the sandbox environment API.
        /// </summary>
        private const string ENDPOINTURLTEST = "https://sandbox.pwinty.com/v3.0/";

        /// <summary>
        /// Initializes a new instance of the <see cref="PwintyClient"/> class.
        /// </summary>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="sandboxMode">True to use the client in sandbox mode. False to use live mode.</param>
        public PwintyClient(string merchantId, string apiKey, bool sandboxMode = true)
        {
            Uri url = sandboxMode ? new Uri(ENDPOINTURLTEST) : new Uri(ENDPOINTURLLIVE);

            this.Countries = new CountryClient(merchantId, apiKey, url);
            this.Catalogue = new CatalogueClient(merchantId, apiKey, url);
            this.Orders = new OrderClient(merchantId, apiKey, url);
        }

        /// <inheritdoc/>
        public ICatalogueClient Catalogue { get; private set; }

        /// <inheritdoc/>
        public ICountryClient Countries { get; private set; }

        /// <inheritdoc/>
        public IOrderClient Orders { get; private set; }
    }
}
