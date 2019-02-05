using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class LatestModel
    {
        public CurrencyType Base { get; set; }
        public DateTime Date { get; set; }
        public Rates Rates { get; set; }
    }

    public class Rates
    {
        public double GBP { get; set; }
        public double USD { get; set; }
        public double Euro { get; set; }
    }
}
