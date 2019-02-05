using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class ExchangeData
    {
        public CurrencyType InitialCurrency { get; set; }
        public double InitialAmount { get; set; }
        public CurrencyType ReturnCurrency { get; set; }
        public double ReturnAmount { get; set; }
        public double ConvertedAmount
        {
            get
            {
                return ConvertedAmount;
            }
            set
            {
                ConvertedAmount = (InitialAmount * ReturnAmount);
            }
        }
    }
}
