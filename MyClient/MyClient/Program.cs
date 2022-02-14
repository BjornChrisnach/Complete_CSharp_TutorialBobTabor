using MyCodeLibrary;
using System;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://docs.microsoft.com");
            Console.WriteLine(value);

            //Console.ReadLine();
        }
    }
}
