namespace Pwinty.Net.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Pwinty.Net.DTO;
    using Pwinty.Net.Enums;

    /// <summary>
    /// Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="dto">Dto to base the order on.</param>
        internal Order(OrderDto dto)
        {
            this.Id = dto.Id;
            this.CanCancel = dto.CanCancel;
            this.CanHold = dto.CanHold;
            this.CanUpdateShipping = dto.CanUpdateShipping;
            this.CanUpdateImages = dto.CanUpdateImages;
            this.RecipientName = dto.RecipientName;
            this.Address1 = dto.Address1;
            this.Address2 = dto.Address2;
            this.AddressTownOrCity = dto.AddressTownOrCity;
            this.StateOrCountry = dto.StateOrCountry;
            this.PostalOrZipCode = dto.PostalOrZipCode;
            this.CountryCode = new Country(dto.CountryCode);
            this.MobileTelephone = dto.MobileTelephone;
            this.Price = dto.Price;
            this.Status = dto.Status;
            this.ShippingInfo = new ShippingInfo(dto.ShippingInfo);
            this.Payment = dto.Payment;
            this.PaymentUrl = new Uri(dto.PaymentUrl);
            this.Images = dto.Images.Select(dto => new Image(dto));
            this.MerchantOrderId = dto.MerchantOrderId;
            this.PreferredShippingMethod = dto.PreferredShippingMethod;
            this.Created = dto.Created;
            this.LastUpdated = dto.LastUpdated;
            this.ErrorMessage = dto.ErrorMessage;
            this.InvoiceAmountNet = dto.InvoiceAmountNet;
            this.InvoiceTax = dto.InvoiceTax;
            this.InvoiceCurrency = dto.InvoiceCurrency;
        }

        /// <summary>
        /// Gets or sets the ID of the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the order can be cancelled (depends on fulfilment partner and status
        /// of the order).
        /// </summary>
        public bool CanCancel { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the order can be placed on hold (depends on fulfilment partner and
        /// status of the order).
        /// </summary>
        public bool CanHold { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the order shipping address/method can be udpated (depends on
        /// fulfilment partner and status of the order).
        /// </summary>
        public bool CanUpdateShipping { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the images in the order are updateable (depends on fulfilment
        /// partner and status of the order).
        /// </summary>
        public bool CanUpdateImages { get; private set; }

        /// <summary>
        /// Gets or sets the name of to whom the order will be addressed.
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or sets the first line of recipient address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of recipient address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the town/city of recipient address.
        /// </summary>
        public string AddressTownOrCity { get; set; }

        /// <summary>
        /// Gets or sets the state (US), county (UK) or region of recipient address.
        /// </summary>
        public string StateOrCountry { get; set; }

        /// <summary>
        /// Gets or sets the postal/Zipcode of recipient address.
        /// </summary>
        public string PostalOrZipCode { get; set; }

        /// <summary>
        /// Gets or sets the two-letter country code of the recipient.
        /// </summary>
        public Country CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the recipients mobile phone number.
        /// </summary>
        public string MobileTelephone { get; set; }

        /// <summary>
        /// Gets the price that Pwinty will charge for this order.
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// Gets the status of order.
        /// </summary>
        public OrderStatus Status { get; private set; }

        /// <summary>
        /// Gets info about how the order will be shipped.
        /// </summary>
        public ShippingInfo ShippingInfo { get; private set; }

        /// <summary>
        /// Gets or sets the payment option for the order.
        /// </summary>
        public PaymentOption Payment { get; set; }

        /// <summary>
        /// Gets or sets the URL that the customer should be sent to, to complete the payment. This is ignored when
        /// <see cref="Payment"/> is set to <see cref="PaymentOption.InvoiceMe"/>.
        /// </summary>
        public Uri PaymentUrl { get; set; }

        /// <summary>
        /// Gets an array of objects representing the images in the order.
        /// </summary>
        public IEnumerable<Image> Images { get; private set; }

        /// <summary>
        /// Gets or sets your order reference.
        /// </summary>
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// Gets or sets the preferred shipping method when creating an order.
        /// </summary>
        public ShippingMethod PreferredShippingMethod { get; set; }

        /// <summary>
        /// Gets the time the order was created.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Gets the time the order was updated for the last time.
        /// </summary>
        public DateTime LastUpdated { get; private set; }

        /// <summary>
        /// Gets detail about any error on the request.
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets or sets the net invoice amount. Used for orders where an invoice amount must be supplied (e.g. to Middle East).
        /// </summary>
        public int InvoiceAmountNet { get; set; }

        /// <summary>
        /// Gets or sets the invoice tax amount. Used for orders where an invoice amount must be supplied (e.g. to Middle East).
        /// </summary>
        public int InvoiceTax { get; set; }

        /// <summary>
        /// Gets or sets the invoice currency.. Used for orders where an invoice amount must be supplied (e.g. to Middle East).
        /// </summary>
        public string InvoiceCurrency { get; set; }
    }
}
