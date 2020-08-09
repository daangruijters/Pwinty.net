# Pwinty.<span>Net - A C# wrapper for the [Pwinty API](https://www.pwinty.com/api)

### [Pwinty](https://www.pwinty.com/) is a powerful image-printing API providing direct access to a global network of on-demand manufacturing partners.

---

[![Nuget](https://img.shields.io/nuget/v/Pwinty.net)](https://www.nuget.org/packages/Pwinty.Net/)


[![GitHub issues](https://img.shields.io/github/issues/daangruijters/Pwinty.net)](https://github.com/daangruijters/Pwinty.net/issues)

[![GitHub license](https://img.shields.io/github/license/daangruijters/Pwinty.net)](https://github.com/daangruijters/Pwinty.net/blob/master/LICENSE)

---

## Example use
```
// Create a new order object with required information.
Order orderToCreate = new Order(
   recipientName: "F. Prince",
   countryCode: new Country("US"),
   preferredShippingMethod: ShippingMethod.Express
);

// Add destination address.
orderToCreate.Address1 = "805 St Cloud Road";
orderToCreate.AddressTownOrCity = "Los Angeles";

PwintyClient client = new PwintyClient(merchantId, apiKey);

// Create the order
Order createdOrder = await client.Orders.CreateAsync(orderToCreate);

// Create a product
Image imageToAdd = new Image(
   sku: "123-product-sku",
   url: "https://i.imgur.com/image.jpg",
   copies: 1,
   sizing: ImageSizing.Crop
);

// Add the product to the order
Image addedImage = await client.Orders.AddImageAsync(createdOrder.Id, imageToAdd);

// Submit the order
await client.Orders.SubmitAsync(createdOrder.Id);
```