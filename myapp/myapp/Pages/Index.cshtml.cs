using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myapp.Pages
{
    public class IndexModel : PageModel
    {
        public DayOfWeek DayOfWeek { get; }
        public string Time { get; set; }
        DateTime ClockInfoFromSystem = DateTime.Now;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Time = ClockInfoFromSystem.DayOfWeek.ToString() + "   " + ClockInfoFromSystem.Day.ToString()+ "/" + ClockInfoFromSystem.Month.ToString() +"/" + ClockInfoFromSystem.Year.ToString();

        }
    }
}
