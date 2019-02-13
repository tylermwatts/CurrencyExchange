using CurrencyExchange.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyExchange.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CurrencyInfoStatic_Returns_Correct_CurrencyInfo()
        {
            var expected = new CurrencyInfo { Name = "Euros", Symbol = "€" };
            var result = CurrencyInfoStatic.GetCurrencyInfo(CurrencyType.EUR);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Symbol, result.Symbol);
        }
        [TestMethod]
        public async Task CurrencyExchangeService_Gets_Correct_InitialType_and_ReturnType()
        {
            var client = new HttpClient();
            CurrencyExchangeService exchangeService = new CurrencyExchangeService(client);
            var exchangeData = await exchangeService.GetExchangeDataAsync(5, CurrencyType.USD, CurrencyType.GBP);

            Assert.AreEqual(exchangeData.InitialCurrency, CurrencyType.USD);
            Assert.AreEqual(exchangeData.ReturnCurrency, CurrencyType.GBP);
        }
    }
}
