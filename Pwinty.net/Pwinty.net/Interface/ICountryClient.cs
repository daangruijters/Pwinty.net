namespace Pwinty.Net.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Pwinty.Net.Model;

    /// <summary>
    /// Abstraction of the <see cref="CountryClient"/>.
    /// </summary>
    public interface ICountryClient
    {
        /// <summary>
        /// Returns all countries available in the system.
        /// </summary>
        /// <returns>List of all countries available in the system.</returns>
        public Task<IEnumerable<Country>> ListAllAsync();
    }
}
