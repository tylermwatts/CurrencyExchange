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
        private readonly HttpClient client;

        public CurrencyExchangeService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<ExchangeData> GetExchangeDataAsync (double initialAmount, CurrencyType initialType, CurrencyType returnType)
        {
            var stringResponse = await client.GetStringAsync($"https://api.exchangeratesapi.io/latest?base={initialType}&symbols={returnType}");
            var exchangeModel = JsonConvert.DeserializeObject<ExchangeModel>(stringResponse);
            var exchangeData = new ExchangeData
            {
                InitialAmount = initialAmount,
                InitialCurrency = initialType,
                ReturnCurrency = returnType,
                ReturnAmount = exchangeModel.Rates[returnType.ToString()]
            };
            return exchangeData;
        }
    }
}
