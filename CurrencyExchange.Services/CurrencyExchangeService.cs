using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Services
{
    public class CurrencyExchangeService : ICurrencyExchangeService
    {
        public async Task<ExchangeData> GetExchangeDataAsync (double initialAmount, CurrencyType initialType, CurrencyType returnType)
        {
            var httpClient = new HttpClient();
            var stringResponse = await httpClient.GetStringAsync($"https://api.exchangeratesapi.io/latest?base={initialType}&symbols={returnType}");
            var latestModel = JsonConvert.DeserializeObject<LatestModel>(stringResponse);
            var exchangeData = new ExchangeData
            {
                InitialAmount = initialAmount,
                InitialCurrency = initialType,
                ReturnCurrency = returnType,
                ReturnAmount = latestModel.Rates[returnType.ToString()]
            };
            return exchangeData;
        }
    }
}
