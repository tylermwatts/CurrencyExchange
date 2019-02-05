using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyExchange.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IndexViewModel IndexViewModel { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            // fetch $"https://api.exchangeratesapi.io/latest?base={IndexViewModel.InitialType}&symbols={IndexViewModel.ReturnType}"
            // populate Convert view
            // pass it as TempData???
            return RedirectToPage("./Convert")
        }
    }
}
