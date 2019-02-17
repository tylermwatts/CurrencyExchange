using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyExchange.Services
{
    public class CurrencyExchangeService : ICurrencyExchangeService
    {
        private readonly HttpClient client;

        public CurrencyExchangeService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<ExchangeData> GetExchangeDataAsync (double initialAmount, CurrencyType initialType, CurrencyType returnType, DateTime? chosenDate = null )
        {
            string dateString = chosenDate.HasValue ? chosenDate.Value.ToString("yyyy-MM-dd") : null;
            string url = chosenDate.HasValue
                ? $"https://api.exchangeratesapi.io/{dateString}?base={initialType}&symbols={returnType}"
                : $"https://api.exchangeratesapi.io/latest?base={initialType}&symbols={returnType}";
            var stringResponse = await client.GetStringAsync(url);
            var exchangeModel = JsonConvert.DeserializeObject<ExchangeModel>(stringResponse);
            var exchangeData = new ExchangeData
            {
                InitialAmount = initialAmount,
                InitialCurrency = initialType,
                ReturnCurrency = returnType,
                ReturnAmount = exchangeModel.Rates[returnType.ToString()],
                Date = exchangeModel.Date,
            };
            return exchangeData;
        }
    }
}
