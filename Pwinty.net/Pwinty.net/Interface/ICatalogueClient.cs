namespace Pwinty.Net.Interface
{
    using System.Collections.Generic;
    using Pwinty.Net.Model;

    /// <summary>
    /// Abstraction of the <see cref="CatalogueClient"/>.
    /// </summary>
    internal interface ICatalogueClient
    {
        /// <summary>
        /// Fetch prices from the catalogue.
        /// </summary>
        /// <param name="countryCode">Countrycode of the destination.</param>
        /// <param name="skus">Array of SKUs of products to check.</param>
        /// <returns>Prices.</returns>
        public IEnumerable<ProductPrice> FetchPrices(Country countryCode, string[] skus);
    }
}
