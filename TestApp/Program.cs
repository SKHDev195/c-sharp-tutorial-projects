// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;

HtmlWeb toFundraiser = new HtmlWeb();
HtmlDocument fundraiserResult = new HtmlDocument();
ArrayList propertiesList = new ArrayList();
//fundraiserResult = toFundraiser.Load("https://www.withukraine.org/");

//var nodes = fundraiserResult.DocumentNode.Descendants(0).Where(n =>
//n.HasClass("text-primary-blue"));
//string result = nodes.ElementAt(1).InnerText;

//var description = fundraiserResult.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "")
//.Contains("bg-primary-blue/10 rounded-lg p-4 text-xs mt-6 relative")).ToList();
//var nodesCurrentFunds = fundraiserResult.DocumentNode.Descendants("div")
//.Where(node => node.GetAttributeValue("class", "").Contains("text-primary-blue")).ToList();
//var nodesTotalFunds = fundraiserResult.DocumentNode.Descendants("div")
//.Where(node => node.GetAttributeValue("class", "").Contains("text-sm")).ToList();

//Console.WriteLine(result);
//Console.WriteLine(description[0].InnerText.Substring(116,64));
//Console.WriteLine(Convert.ToDouble(nodesCurrentFunds[0].InnerText.Substring(1,10)));
//Console.WriteLine(Convert.ToDouble(nodesTotalFunds[3].InnerText.Substring(16,12)));

//fundraiserResult = toFundraiser.Load("https://www.ukrainecrisisappeal.org/");
//var nodesCurrentFunds = fundraiserResult.DocumentNode.Descendants("div").Where(node =>
//node.GetAttributeValue("class", "").Contains("_2Hij5 _3bcaz") &&
//node.GetAttributeValue("id", "").Contains("comp-l4m4lxk5") &&
//node.GetAttributeValue("data-testid", "").Contains("richTextElement")).ToList();
//Console.WriteLine(Convert.ToDouble(nodesCurrentFunds[0].InnerText.Substring(1,10)));
//Console.WriteLine(Convert.ToDouble(nodesCurrentFunds[0].InnerText.Substring(26, 10)));

//fundraiserResult = toFundraiser.Load("https://donate.chooselove.org/campaigns/ukraine-appeal/");
//var nodesCurrentFunds = fundraiserResult.DocumentNode.Descendants("p")
//.Where(node => node.GetAttributeValue("class", "").Contains("campaign__raised")).ToList();
//var nodesTotalFunds = fundraiserResult.DocumentNode.Descendants("p")
//.Where(node => node.GetAttributeValue("class", "").Contains("campaign__target")).ToList();
//Console.WriteLine(Convert.ToDouble(nodesCurrentFunds[0].InnerText.Substring(37)));
//Console.WriteLine(Convert.ToDouble(nodesTotalFunds[0].InnerText.Substring(9)));
//Console.ReadLine();

//fundraiserResult = toFundraiser.Load("https://www.withukraine.org/");
//var descriptionZero = fundraiserResult.DocumentNode.Descendants("div")
    //.Where(node => node.GetAttributeValue("class", "")
        //.Contains("bg-primary-blue/10 rounded-lg p-4 text-xs mt-6 relative"))
    //.ToList();
//var nodesCurrentFundsZero = fundraiserResult.DocumentNode.Descendants("div")
    //.Where(node => node.GetAttributeValue("class", "")
        //.Contains("text-primary-blue"))
    //.ToList();
//var nodesTotalFundsZero = fundraiserResult.DocumentNode.Descendants("div")
    //.Where(node => node.GetAttributeValue("class", "")
        //.Contains("text-sm"))
    //.ToList();

//fundraiserResult = toFundraiser.Load("https://donorbox.org/ukraine-crisis-fundraiser");
//string descriptionThree = "We need your help to provide practical support for the 2.7 million Ukrainian children and adults with documented disabilities, and other vulnerable members of society.";
//var nodesCurrentFundsThree = fundraiserResult.DocumentNode.Descendants("p").Where(node => node.GetAttributeValue("id", "").Contains("total-raised")).ToList();
//var nodesTotalFundsThree = fundraiserResult.DocumentNode.Descendants("p").Where(node => node.GetAttributeValue("class", "").Contains("bold")).ToList();

//fundraiserResult = toFundraiser.Load("https://www.justgiving.com/campaign/UNICEFUKRAINE");
//string descriptionFour =
    //"Help UNICEF ensure that child health and protection services are sustained and families have clean water and nutritious food.";
//var nodesCurrentFundsFour = fundraiserResult.DocumentNode.Descendants("dd")
    //.Where(node => node.GetAttributeValue("data-qa", "").Contains("totalValue")).ToList();

//Console.WriteLine(Convert.ToDouble(nodesCurrentFundsFour[0].InnerText.Substring(1,12)));

fundraiserResult = toFundraiser.Load("https://www.koloua.com/en");
var nodesCurrentFundsSixteen = fundraiserResult.DocumentNode.Descendants("p").Where(node => node.GetAttributeValue("class", "").Contains("achievements__value")).ToList();

Console.WriteLine(Convert.ToDouble(nodesCurrentFundsSixteen[0].InnerText.Substring(1, 3) + "00,000"));
Console.WriteLine(String.Format("{0:n}",Convert.ToDouble(nodesCurrentFundsSixteen[0].InnerText.Substring(1, 3) + "00,000")));

//fundraiserResult = toFundraiser.Load("https://fundly.com/save-ukrainian-refugees");
//var nodesCurrentFundsEighteen = fundraiserResult.DocumentNode.Descendants("h3").ToList();
//var nodesTotalFudnsEighteen = fundraiserResult.DocumentNode.Descendants("span")
    //.Where(node => node.GetAttributeValue("class", "").Contains("js-campaign-goal-target")).ToList();
//Console.WriteLine(Convert.ToDouble(nodesCurrentFundsEighteen[2].InnerText.Substring(2)));
//Console.WriteLine(Convert.ToDouble(nodesTotalFudnsEighteen[0].InnerText.Substring(2)));

Console.ReadLine();