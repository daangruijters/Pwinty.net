using Pwinty.Net.Clients;
using System;
using System.Configuration;

namespace Printy.Net.Tests
{
    /// <summary>
    /// Base class for all tests.
    /// </summary>
    public class TestBase
    {
        public TestBase()
        {
            string merchantId = ConfigurationManager.AppSettings["Pwinty-MerchantId"];
            string apiKey = ConfigurationManager.AppSettings["Pwinty-REST-API-Key"];

            if (string.IsNullOrEmpty(merchantId) || string.IsNullOrEmpty(apiKey))
            {
                throw new ConfigurationErrorsException("Configure merchantId and apiKey in the app.config file in " +
                    "order to run tests");
            }

            this.PwintyClient = new PwintyClient(merchantId, apiKey);
        }

        internal PwintyClient PwintyClient { get; private set; }
    }
}
