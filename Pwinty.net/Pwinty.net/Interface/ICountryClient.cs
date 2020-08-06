namespace Pwinty.Net.Interface
{
    using System.Collections.Generic;
    using Pwinty.Net.DTO;

    /// <summary>
    /// Abstraction of the <see cref="CountryClient"/>.
    /// </summary>
    internal interface ICountryClient
    {
        /// <summary>
        /// Returns all countries available in the system.
        /// </summary>
        /// <returns>List of all countries available in the system.</returns>
        public IEnumerable<CountryDto> ListAll();
    }
}
