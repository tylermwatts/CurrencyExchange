using CurrencyExchange.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyExchange.Test
{
    [TestClass]
    public class LatestUnitTests
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
        public async Task CurrencyExchangeService_Returns_ExchangeData()
        {
            var client = new HttpClient();
            CurrencyExchangeService exchangeService = new CurrencyExchangeService(client);

            var exchangeData = await exchangeService.GetExchangeDataAsync(5, CurrencyType.USD, CurrencyType.GBP);

            Assert.IsInstanceOfType(exchangeData, typeof(ExchangeData));
        }
        [TestMethod]
        public void ExchangeData_Calculates_ReturnAmount()
        {
            ExchangeData exchangeData = new ExchangeData
            {
                InitialAmount = 5,
                InitialCurrency = CurrencyType.USD,
                ReturnAmount = 0.5,
                ReturnCurrency = CurrencyType.GBP
            };

            double expected = 2.5;
            double result = exchangeData.ConvertedAmount;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ExchangeModel_Maps_Json_Data()
        {
            string testString = "{\"base\":\"USD\",\"date\":\"2019-02-15\",\"rates\":{\"EUR\":0.8880994671}}";

            ExchangeModel exchangeModel = JsonConvert.DeserializeObject<ExchangeModel>(testString);

            Assert.AreEqual(CurrencyType.USD, exchangeModel.Base);
            Assert.AreEqual(new System.DateTime(2019, 2, 15), exchangeModel.Date);
            Assert.IsTrue(exchangeModel.Rates.ContainsKey(CurrencyType.EUR.ToString()));
            Assert.AreEqual(0.8880994671, exchangeModel.Rates[CurrencyType.EUR.ToString()]);
        }
    }
}
