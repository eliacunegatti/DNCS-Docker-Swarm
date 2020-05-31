using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace myapp.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;
        public string Time { get; set; }
        DateTime ClockInfoFromSystem = DateTime.Now;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            Time = ClockInfoFromSystem.Month.ToString();
            if (Time == "5")
            {
                Time = "Maggio";
            }
            if (Time == "6")
            {
                Time = "Giugno";
            }

        }
    }
}
