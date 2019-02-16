using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class ExchangeModel
    {
        public CurrencyType Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string,double> Rates { get; set; }
    }
}
