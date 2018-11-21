using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Globalization;

namespace SimpleCrawler
{
    public class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string startUrl = "https://hao.360.cn/?src=lm&ls=n36a7f6a197";
            if (args.Length >= 1) startUrl = args[0];

            myCrawler.urls.Add(startUrl, false);

            new Thread(myCrawler.Crawl).Start();
        }
        
        
        private void Crawl()
        {
            Console.WriteLine("开始爬行了...");
                while(true)
                {
                    string current=null;
                    foreach(string url in urls.Keys)
                    {
                        if ((bool)urls[urls]) continue;
                        current = url;
                    }
                    if (current == null || count > 10) break;

                    Console.WriteLine("爬行" + current + "页面!");

                    string html = DownLoad(current);

                    urls[current] = true;
                    count++;

                    Parse(html);
                }
                Console.WriteLine("爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef=match.Value.Substring(match.Value.IndexOf('=')+1).Trim('"','\"','#','','>');
                if(strRef.Length==0)continue;

                if(urls[strRef]==null)urls[strRef]=false;
            }
        }
    }
}
