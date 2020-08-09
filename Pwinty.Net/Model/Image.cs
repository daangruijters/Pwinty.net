namespace Pwinty.Net.Model
{
    using System;
    using System.Collections.Generic;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Enums;

    /// <summary>
    /// Product including the image to print.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="sku">An identification code of the product associated with this image.</param>
        /// <param name="imageUrl">URL of the iamge.</param>
        /// <param name="copies">Number of copies of the image to include in the order.</param>
        /// <param name="imageSizing">How the image should be resized when printing.</param>
        public Image(string sku, Uri imageUrl, uint copies, ImageSizing imageSizing)
        {
            if (string.IsNullOrEmpty(sku))
            {
                throw new ArgumentException($"{nameof(sku)} is null or empty.", nameof(sku));
            }

            if (imageUrl == null)
            {
                throw new ArgumentNullException(nameof(imageUrl), $"{nameof(imageUrl)} is null.");
            }

            this.SKU = sku;
            this.ImageUrl = imageUrl;
            this.Copies = copies;
            this.Sizing = imageSizing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the image on.</param>
        internal Image(ImageDto dto)
        {
            this.Id = dto.Id;
            this.ImageUrl = new Uri(dto.Url);
            this.Status = dto.Status;
            this.Copies = dto.Copies;
            this.Sizing = dto.Sizing;
            this.Price = dto.Price;
            this.PriceToUser = dto.PriceToUser;
            this.MD5Hash = dto.MD5Hash;
            this.PreviewUrl = new Uri(dto.PreviewUrl);
            this.ThumbnailUrl = new Uri(dto.ThumbnailUrl);
            this.SKU = dto.SKU;
            this.Attributes = dto.Attributes;
            this.ErrorMessage = dto.ErrorMessage;
        }

        /// <summary>
        /// Gets the unique integer identifying the image.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets or sets the image URL If image is to be downloaded by Pwinty, the image's URL.
        /// </summary>
        public Uri ImageUrl { get; set; }

        /// <summary>
        /// Gets the current status of the image.
        /// </summary>
        public ImageStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets the number of copies of the image to include in the order.
        /// </summary>
        public uint Copies { get; set; }

        /// <summary>
        /// Gets or sets how the image should be resized when printing.
        /// </summary>
        public ImageSizing Sizing { get; set; }

        /// <summary>
        /// Gets the amount (in cents/pence) that Pwinty will charge you for this item.
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// Gets or sets the price (in cents/pence) that you want to charge the user for this item, if
        /// <see cref="Order.Payment"/> is set to <see cref="PaymentOption.InvoiceRecipient"/>.
        /// </summary>
        public int PriceToUser { get; set; }

        /// <summary>
        /// Gets or sets the md5 hash of the image file (when available).
        /// </summary>
        public string MD5Hash { get; set; }

        /// <summary>
        /// Gets the URL of the image after cropping.
        /// </summary>
        public Uri PreviewUrl { get; private set; }

        /// <summary>
        /// Gets the URL that will serve up a thumbnail of the image after cropping.
        /// </summary>
        public Uri ThumbnailUrl { get; private set; }

        /// <summary>
        /// Gets or sets the identification code of the product associated with this image.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Gets attributes set on the object.
        /// </summary>
        public Dictionary<string, string> Attributes { get; private set; }

        /// <summary>
        /// Gets the detail about any error on the request.
        /// </summary>
        public string ErrorMessage { get; private set; }
    }
}
