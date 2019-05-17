using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             string inputUrl= Console.ReadLine();
            var output = WebUtility.UrlDecode(inputUrl);
            Console.WriteLine(output);
        }
    }
}
