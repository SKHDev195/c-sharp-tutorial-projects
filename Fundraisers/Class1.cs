using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.IO;
using HtmlAgilityPack;

namespace Fundraisers
{

    internal class Class1
    {

        public string Funds { get; set; }
        
        public Class1()
        {
            this.Funds = GetInformation();
        }

        public string GetInformation()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument();
            doc = web.Load("https://www.withukraine.org/");


            var nodes = doc.DocumentNode.Descendants(0).Where(n =>
                n.HasClass("text-primary-blue"));

            return nodes.ElementAt(2).InnerText;

        }

    }
}
