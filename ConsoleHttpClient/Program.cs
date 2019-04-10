using ApiAndHttpClient.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text");
            var results = ApiService.CallWebAPIAsync();

        }
    }
}
