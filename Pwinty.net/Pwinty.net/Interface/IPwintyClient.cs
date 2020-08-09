namespace Pwinty.Net.Interface
{
    /// <summary>
    /// Client that connects to the Pwinty API. See https://www.pwinty.com/api/ for full documentation of the API.
    /// </summary>
    public interface IPwintyClient
    {
        /// <summary>
        /// Gets the catalogue related operations.
        /// </summary>
        public ICatalogueClient Catalogue { get; }

        /// <summary>
        /// Gets the country related operations.
        /// </summary>
        public ICountryClient Countries { get; }

        /// <summary>
        /// Gets the order related operations.
        /// </summary>
        public IOrderClient Orders { get; }
    }
}
