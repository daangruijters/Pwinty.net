namespace Pwinty.Net.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Pwinty.Net.Model;

    /// <summary>
    /// Abstraction of the <see cref="CatalogueClient"/>.
    /// </summary>
    public interface ICatalogueClient
    {
        /// <summary>
        /// Fetch prices from the catalogue.
        /// </summary>
        /// <param name="countryCode">Countrycode of the destination.</param>
        /// <param name="skus">Array of SKUs of products to check.</param>
        /// <returns>Prices.</returns>
        Task<IEnumerable<ProductPrice>> FetchPricesAsync(Country countryCode, string[] skus);
    }
}
