using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pwinty.Net.Clients;
using System.Linq;

namespace Printy.Net.Tests
{
    [TestClass]
    public class CountryClientTests : TestBase
    {
        [TestMethod]
        public void ListAll_Success()
        {
            var countries = PwintyClient.Countries.ListAllAsync().GetAwaiter().GetResult();

            Assert.IsNotNull(countries, "Returned object is null");
            Assert.IsTrue(countries.Any(), "Returned object is empty");
        }
    }
}
