using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Givemin5.HtmlAgilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = $"https://www.books.com.tw/products/0010553999";

            var web = new HtmlWeb();
            var doc = web.Load(url);
            var nameNode = doc.DocumentNode.SelectSingleNode("//h1[@itemprop='name']");

            Console.WriteLine(nameNode.InnerText);
            Console.ReadKey();
        }
    }
}
