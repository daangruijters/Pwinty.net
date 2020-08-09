namespace Pwinty.Net.Model
{
    using System;
    using Pwinty.Net.DTO;

    /// <summary>
    /// Price of a product.
    /// </summary>
    public class ProductPrice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPrice"/> class.
        /// </summary>
        /// <param name="priceDto">Price dto to base the model on.</param>
        internal ProductPrice(ProductPriceDto priceDto)
        {
            if (priceDto == null)
            {
                throw new ArgumentNullException(nameof(priceDto), $"{nameof(priceDto)} is null.");
            }

            this.SKU = priceDto.SKU;
            this.Price = priceDto.Price;
            this.Currency = priceDto.Currency;
        }

        /// <summary>
        /// Gets the identification code of the product.
        /// </summary>
        public string SKU { get; private set; }

        /// <summary>
        /// Gets the amount (in cents/pence) that Pwinty will charge you for this product.
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// Gets the currency code in which product is priced.
        /// </summary>
        public string Currency { get; private set; }
    }
}
