using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CurrencyExchange.Services
{
    public static class CurrencyInfoStatic
    {
        public static CurrencyInfo GetCurrencyInfo(CurrencyType currencyType)
        {
            switch (currencyType)
            {
                case CurrencyType.EUR:
                    return new CurrencyInfo
                    {
                        Name = "Euros",
                        Symbol = "€"
                    };
                case CurrencyType.GBP:
                    return new CurrencyInfo
                    {
                        Name = "Pounds",
                        Symbol = "£"
                    };
                case CurrencyType.USD:
                    return new CurrencyInfo
                    {
                        Name = "Dollars",
                        Symbol = "$"
                    };
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }

    public class CurrencyInfo
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
