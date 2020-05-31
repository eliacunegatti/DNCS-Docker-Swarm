using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myapp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string Time { get; set; }
        DateTime ClockInfoFromSystem = DateTime.Now;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            Time = ClockInfoFromSystem.Hour.ToString() + ":" + ClockInfoFromSystem.Minute.ToString() + ":" + ClockInfoFromSystem.Second.ToString();

        }
    }
}
