using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Serilog;

namespace Serilog_NetCore_Azure.Pages
{
    public class IndexModel : PageModel
    {

        public string Message = "Default";

        public void OnGet()
        {
            Message = "Start sending logs...";
            Debug.WriteLine("Page loaded.");
        }

        public void OnPostInformation()
        {
            Message = "Info logged to text";

            Log.Information("Information!");
            Debug.WriteLine("Info logged.");
        }

        public void OnPostWarning()
        {
            Message = "Warn logged to text";

            Log.Warning("Warning!!");
            Debug.WriteLine("Warning logged.");
        }
        public void OnPostFatal()
        {
            Message = "Fatal logged to text";

            Log.Fatal("FATAL!!!!");
            Debug.WriteLine("Fatal logged.");

        }
    }
}
