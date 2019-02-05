using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class IndexViewModel
    {
        public CurrencyType InitialType { get; set; }
        public double InitialAmount { get; set; }
        public CurrencyType ReturnType { get; set; }
    }
}
