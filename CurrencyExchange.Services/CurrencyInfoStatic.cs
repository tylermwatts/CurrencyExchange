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
                        Name = "British Pounds",
                        Symbol = "£"
                    };
                case CurrencyType.USD:
                    return new CurrencyInfo
                    {
                        Name = "U.S. Dollars",
                        Symbol = "$"
                    };
                case CurrencyType.JPY:
                    return new CurrencyInfo
                    {
                        Name = "Japanese Yen",
                        Symbol = "¥"
                    };
                case CurrencyType.BGN:
                    return new CurrencyInfo
                    {
                        Name = "Bulgarian Leva",
                        Symbol = "лв"
                    };
                case CurrencyType.CZK:
                    return new CurrencyInfo
                    {
                        Name = "Czech Koruny",
                        Symbol = "Kč"
                    };
                case CurrencyType.DKK:
                    return new CurrencyInfo
                    {
                        Name = "Danish Kroner",
                        Symbol = "kr."
                    };
                case CurrencyType.HUF:
                    return new CurrencyInfo
                    {
                        Name = "Hungarian Forint",
                        Symbol = "Ft"
                    };
                case CurrencyType.PLN:
                    return new CurrencyInfo
                    {
                        Name = "Polish Zloty",
                        Symbol = "zł"
                    };
                case CurrencyType.RON:
                    return new CurrencyInfo
                    {
                        Name = "Romanian Lei",
                        Symbol = "L"
                    };
                case CurrencyType.SEK:
                    return new CurrencyInfo
                    {
                        Name = "Swedish Kronor",
                        Symbol = "kr"
                    };
                case CurrencyType.CHF:
                    return new CurrencyInfo
                    {
                        Name = "Swiss Francs",
                        Symbol = "Fr."
                    };
                case CurrencyType.ISK:
                    return new CurrencyInfo
                    {
                        Name = "Icelandic Króna",
                        Symbol = "kr"
                    };
                case CurrencyType.NOK:
                    return new CurrencyInfo
                    {
                        Name = "Norwegian Kroner",
                        Symbol = "kr"
                    };
                case CurrencyType.HRK:
                    return new CurrencyInfo
                    {
                        Name = "Croatian Kuna",
                        Symbol = "kn"
                    };
                case CurrencyType.RUB:
                    return new CurrencyInfo
                    {
                        Name = "Russian Rubles",
                        Symbol = "₽"
                    };
                case CurrencyType.TRY:
                    return new CurrencyInfo
                    {
                        Name = "Turkish Liras",
                        Symbol = "₺"
                    };
                case CurrencyType.AUD:
                    return new CurrencyInfo
                    {
                        Name = "Australian Dollars",
                        Symbol = "A$"
                    };
                case CurrencyType.BRL:
                    return new CurrencyInfo
                    {
                        Name = "Brazilian Reais",
                        Symbol = "R$"
                    };
                case CurrencyType.CAD:
                    return new CurrencyInfo
                    {
                        Name = "Canadian Dollars",
                        Symbol = "C$"
                    };
                case CurrencyType.CNY:
                    return new CurrencyInfo
                    {
                        Name = "Chinese Renminbi",
                        Symbol = "元"
                    };
                case CurrencyType.HKD:
                    return new CurrencyInfo
                    {
                        Name = "Hong Kong Dollars",
                        Symbol = "HK$"
                    };
                case CurrencyType.IDR:
                    return new CurrencyInfo
                    {
                        Name = "Indonesian Rupiah",
                        Symbol = "Rp"
                    };
                case CurrencyType.ILS:
                    return new CurrencyInfo
                    {
                        Symbol = "Israeli Shekels",
                        Name = "₪"
                    };
                case CurrencyType.INR:
                    return new CurrencyInfo
                    {
                        Name = "Indian Rupees",
                        Symbol = "₹"
                    };
                case CurrencyType.KRW:
                    return new CurrencyInfo
                    {
                        Name = "South Korean Won",
                        Symbol = "₩"
                    };
                case CurrencyType.MXN:
                    return new CurrencyInfo
                    {
                        Name = "Mexican Pesos",
                        Symbol = "Mex$"
                    };
                case CurrencyType.MYR:
                    return new CurrencyInfo
                    {
                        Name = "Malaysian Ringgit",
                        Symbol = "RM"
                    };
                case CurrencyType.NZD:
                    return new CurrencyInfo
                    {
                        Name = "New Zealand Dollars",
                        Symbol = "NZ$"
                    };
                case CurrencyType.PHP:
                    return new CurrencyInfo
                    {
                        Name = "Philippine Pesos",
                        Symbol = "₱"
                    };
                case CurrencyType.SGD:
                    return new CurrencyInfo
                    {
                        Name = "Singapore Dollars",
                        Symbol = "S$"
                    };
                case CurrencyType.THB:
                    return new CurrencyInfo
                    {
                        Name = "Thai Baht",
                        Symbol = "฿"
                    };
                case CurrencyType.ZAR:
                    return new CurrencyInfo
                    {
                        Name = "South African Rand",
                        Symbol = "R"
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
