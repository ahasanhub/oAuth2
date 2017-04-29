using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Serilog;

namespace Simplest.OAuth.IdSrv
{
    class Program
    {
        static void Main(string[] args)
        {
            //logging
            Log.Logger =
                new LoggerConfiguration().WriteTo.LiterateConsole(
                        outputTemplate: "{Timestamp:HH:mm} [{Level}] ({Name:l}){NewLine} {Message}{NewLine}{Exception}")
                    .CreateLogger();
            //hosting identity server
            using (WebApp.Start<Startup>("http://localhost:5000"))
            {
                Console.WriteLine("Server running...");
                Console.ReadLine();
            }
        }
    }
}
