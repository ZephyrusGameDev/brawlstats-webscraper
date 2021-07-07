using System;

namespace TestingWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player tag:");
            string tag = Console.ReadLine();

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://brawlstats.com/profile/" + tag);

            var trophies = doc.DocumentNode.SelectSingleNode("//div[@class='mo25VS9slOfRz6jng3WTf']").InnerText.ToString();

            int count = int.Parse(trophies);
        }
    }
}
