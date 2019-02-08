using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CurrencyExchange.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace CurrencyExchange.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICurrencyExchangeService exchangeService;

        public IndexModel(ICurrencyExchangeService exchangeService)
        {
            this.exchangeService = exchangeService;
        }

        [BindProperty]
        public IndexViewModel IndexViewModel { get; set; }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            ExchangeData data = await exchangeService.GetExchangeDataAsync(IndexViewModel.InitialAmount, IndexViewModel.InitialType, IndexViewModel.ReturnType);
            return RedirectToPage("Convert", "Convert", data);
        }

        
    }
}
