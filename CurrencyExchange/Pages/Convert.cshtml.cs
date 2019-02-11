using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyExchange.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyExchange.Pages
{
    public class ConvertModel : PageModel
    {
        public ExchangeData ExchangeData { get; set; }
        public CurrencyInfo InitialCurrencyInfo { get; set; }
        public CurrencyInfo ReturnCurrencyInfo { get; set; }

        public IActionResult OnGetConvert(ExchangeData data)
        {
            ExchangeData = data;
            InitialCurrencyInfo = CurrencyInfoStatic.GetCurrencyInfo(ExchangeData.InitialCurrency);
            ReturnCurrencyInfo = CurrencyInfoStatic.GetCurrencyInfo(ExchangeData.ReturnCurrency);
            return Page();
        }
    }
}