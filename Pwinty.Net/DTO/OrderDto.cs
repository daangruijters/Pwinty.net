#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line

namespace Pwinty.Net.DTO
{
    using System;
    using System.Collections.Generic;
    using Pwinty.Net.Enums;

    internal class OrderDto
    {
        public int ID { get; set; }
        public bool CanCancel { get; set; }
        public bool CanHold { get; set; }
        public bool CanUpdateShipping { get; set; }
        public bool CanUpdateImages { get; set; }
        public string RecipientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AddressTownOrCity { get; set; }
        public string StateOrCountry { get; set; }
        public string PostalOrZipCode { get; set; }
        public string CountryCode { get; set; }
        public string MobileTelephone { get; set; }
        public int Price { get; set; }
        public OrderStatus Status { get; set; }
        public ShippingInfoDto ShippingInfo { get; set; }
        public PaymentOption Payment { get; set; }
        public string PaymentUrl { get; set; }
        public List<ImageDto> Images { get; set; }
        public string MerchantOrderId { get; set; }
        public ShippingMethod PreferredShippingMethod { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ErrorMessage { get; set; }
        public int InvoiceAmountNet { get; set; }
        public int InvoiceTax { get; set; }
        public string InvoiceCurrency { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
