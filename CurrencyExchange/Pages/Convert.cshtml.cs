using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyExchange.Pages
{
    public class ConvertModel : PageModel
    {
        public ExchangeData ExchangeData { get; set; }

        public ConvertModel(ExchangeData exchangeData)
        {
            ExchangeData = exchangeData;
        }

        public void OnGet()
        {
            
        }
    }
}