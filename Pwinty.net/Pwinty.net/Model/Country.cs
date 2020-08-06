namespace Pwinty.Net.Model
{
    using System;
    using System.Globalization;

    /// <summary>
    /// ISO 3166 two-letter country code.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        /// <param name="isoCode">Two-letter ISO 3166 country code.</param>
        public Country(string isoCode)
        {
            if (isoCode.Length != 2)
            {
                throw new ArgumentException("Code has to be a two-letter code", nameof(isoCode));
            }

            if (new RegionInfo(isoCode) == null)
            {
                throw new ArgumentException("Code is not defined in ISO 3166, thus not a valid country code.", nameof(isoCode));
            }
        }

        /// <summary>
        /// Gets the country ISO code.
        /// </summary>
        public string IsoCode { get; private set; }
    }
}
