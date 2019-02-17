using CurrencyExchange.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Test
{
    [TestClass]
    public class HistoricalUnitTests
    {
        [TestMethod]
        public async Task ExchangeModel_Returns_Correct_Date()
        {
            var client = new HttpClient();
            var exchangeService = new CurrencyExchangeService(client);
            var expected = new DateTime(2014, 6, 6);

            var exchangeData = await exchangeService.GetExchangeDataAsync(1, CurrencyType.USD, CurrencyType.GBP, expected);

            Assert.AreEqual(expected, exchangeData.Date);
        }
    }
}
