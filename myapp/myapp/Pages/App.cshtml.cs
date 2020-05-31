using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myapp.Pages
{
    public class AppModel : PageModel
    {
        public string Time { get; set; }

        public void OnGet()
        {
            Time = "Questa è la nostra applicazione Web creata con .NET";
        }
    }
}
