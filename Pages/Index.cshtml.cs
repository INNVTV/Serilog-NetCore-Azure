using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Serilog_NetCore_Azure.Pages
{
    public class IndexModel : PageModel
    {
        public string Message = "Default";

        public void OnGet()
        {
            Message = "Get started...";

            Trace.WriteLine("Page gotten.");
            Debug.WriteLine("Page gotten.");
            Console.WriteLine("Page gotten.");
        }

        public void OnPostInfoText()
        {
            Message = "Info logged to text";

            Trace.WriteLine("Info logged.");
            Debug.WriteLine("Info logged.");
            Console.WriteLine("Info logged.");
        }

        public void OnPostWarnText()
        {
            Message = "Warn logged to text";

            Trace.WriteLine("Info logged.");
            Debug.WriteLine("Info logged.");
            Console.WriteLine("Info logged.");
        }
        public void OnPostCriticalText()
        {
            Message = "Critical logged to text";

            Trace.WriteLine("Info logged.");
            Debug.WriteLine("Info logged.");
            Console.WriteLine("Info logged.");
        }
    }
}
