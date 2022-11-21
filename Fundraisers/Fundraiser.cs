using System;
using System.Collections.Generic;
using System.Collections;
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
    /// <summary>
    /// A class representing one fundraiser.
    /// </summary>
    internal class Fundraiser
    {

        public string Title { get; private set; }
        public string Description { get; private set; }
        public double CurrentFunds { get; private set; }
        public double TotalFunds { get; private set; }
        public string Currency { get; private set; }
        public Uri Website { get; private set; }
        
        public Fundraiser(int fundraiserID)
        {

            try
            {
                var fundraiserProperties = GetInformation(fundraiserID);
                this.Title = fundraiserProperties[0].ToString();
                this.Currency = fundraiserProperties[1].ToString();
                this.Description = fundraiserProperties[2].ToString();
                this.CurrentFunds = Convert.ToDouble(fundraiserProperties[3]);
                this.TotalFunds = Convert.ToDouble(fundraiserProperties[4]);
                this.Website = new Uri(fundraiserProperties[5].ToString());
            }

            catch
            {
                this.Title = "Fundraiser Unavailable";
                this.Currency = "";
                this.Description = "This fundraiser is currently unavailable. The link below leads to the United24 fundraiser.";
                this.CurrentFunds = Convert.ToDouble(0);
                this.TotalFunds = Convert.ToDouble(0);
                this.Website = new Uri("https://u24.gov.ua/");
            }

        }

        /// <summary>
        /// Returns an ArrayList containing data about a specific fundraiser.
        /// As fundaisers provide data in completely different formats, each fundraiser is processed differently.
        /// </summary>
        /// <param name="identifier">An integer denoting a specific fundraiser.</param>
        /// <returns></returns>
        public ArrayList GetInformation(int identifier)
        {
            HtmlWeb toFundraiser = new HtmlWeb();
            HtmlDocument fundraiserResult = new HtmlDocument();
            ArrayList propertiesList = new ArrayList();

            string eurCurrency = "EUR";
            string usdCurrency = "USD";
            string gbpCurrency = "GBP";

            switch (identifier)
            {

                // WithUkraine.org
                case 0:
                    fundraiserResult = toFundraiser.Load("https://www.withukraine.org/");
                    var descriptionZero = fundraiserResult.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("bg-primary-blue/10 rounded-lg p-4 text-xs mt-6 relative"))
                        .ToList();
                    var nodesCurrentFundsZero = fundraiserResult.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("text-primary-blue"))
                        .ToList();
                    var nodesTotalFundsZero = fundraiserResult.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("text-sm"))
                        .ToList();
                    string fundsZero = gbpCurrency;
                    string titleZero = "WithUkraine.org";
                    string websiteZero = "https://www.withukraine.org/";
                    propertiesList.Add(titleZero);
                    propertiesList.Add(fundsZero);
                    propertiesList.Add(descriptionZero[0].InnerText.Substring(116, 64));
                    propertiesList.Add(nodesCurrentFundsZero[0].InnerText.Substring(1, 10));
                    propertiesList.Add(nodesTotalFundsZero[3].InnerText.Substring(16, 12));
                    propertiesList.Add(websiteZero);
                    break;
                
                // Ukraine Crisis Appeal (Australia)
                case 1:
                    fundraiserResult = toFundraiser.Load("https://www.ukrainecrisisappeal.org/");
                    string descriptionOne =
                        "Ukraine Сrisis Appeal is the largest Australian tax-deductible fundraising effort for Ukraine";
                    var nodesFundsOne = fundraiserResult.DocumentNode.Descendants("div").Where(node =>
                        node.GetAttributeValue("class", "").Contains("_2Hij5 _3bcaz") &&
                        node.GetAttributeValue("id", "").Contains("comp-l4m4lxk5") &&
                        node.GetAttributeValue("data-testid", "").Contains("richTextElement")).ToList();
                    string fundsOne = usdCurrency;
                    string titleOne = "Ukraine Crisis Appeal";
                    string websiteOne = "https://www.ukrainecrisisappeal.org/";
                    propertiesList.Add(titleOne);
                    propertiesList.Add(fundsOne);
                    propertiesList.Add(descriptionOne);
                    propertiesList.Add(nodesFundsOne[0].InnerText.Substring(1, 10));
                    propertiesList.Add(nodesFundsOne[0].InnerText.Substring(26, 10));
                    propertiesList.Add(websiteOne);
                    break;

                // Choose Love Ukraine
                case 2:
                    fundraiserResult = toFundraiser.Load("https://donate.chooselove.org/campaigns/ukraine-appeal/");
                    string descriptionTwo =
                        "Thanks to your donations, we are now supporting over 90 projects who are providing vital aid and services to those still in and fleeing the country.";
                    var nodesCurrentFundsTwo = fundraiserResult.DocumentNode.Descendants("p")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("campaign__raised"))
                        .ToList();
                    var nodesTotalFundsTwo = fundraiserResult.DocumentNode.Descendants("p")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("campaign__target"))
                        .ToList();
                    string fundsTwo = eurCurrency;
                    string titleTwo = "Choose Love Ukraine";
                    string websiteTwo = "https://donate.chooselove.org/campaigns/ukraine-appeal/";
                    propertiesList.Add(titleTwo);
                    propertiesList.Add(fundsTwo);
                    propertiesList.Add(descriptionTwo);
                    propertiesList.Add(Convert.ToDouble(nodesCurrentFundsTwo[0].InnerText.Substring(37)));
                    propertiesList.Add(Convert.ToDouble(nodesTotalFundsTwo[0].InnerText.Substring(9)));
                    propertiesList.Add(websiteTwo);
                    break;

                // Legacy of War (Helping Disabled)
                case 3:
                    fundraiserResult = toFundraiser.Load("https://donorbox.org/ukraine-crisis-fundraiser");
                    string descriptionThree =
                        "We need your help to provide practical support for the 2.7 million Ukrainian children and adults with documented disabilities, and other vulnerable members of society.";
                    var nodesCurrentFundsThree = fundraiserResult.DocumentNode.Descendants("p")
                        .Where(node => node.GetAttributeValue("id", "")
                        .Contains("total-raised"))
                        .ToList();
                    var nodesTotalFundsThree = fundraiserResult.DocumentNode.Descendants("p")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("bold"))
                        .ToList();
                    string fundsThree = gbpCurrency;
                    string titleThree = "Legacy of War Foundation";
                    string websiteThree = "https://donorbox.org/ukraine-crisis-fundraiser";
                    propertiesList.Add(titleThree);
                    propertiesList.Add(fundsThree);
                    propertiesList.Add(descriptionThree);
                    propertiesList.Add(Convert.ToDouble(nodesCurrentFundsThree[0].InnerText.Substring(1)));
                    propertiesList.Add(Convert.ToDouble(nodesTotalFundsThree[2].InnerText.Substring(1)));
                    propertiesList.Add(websiteThree);
                    break;

                // Unicef Ukraine (No Target)
                case 4:
                    fundraiserResult = toFundraiser.Load("https://www.justgiving.com/campaign/UNICEFUKRAINE");
                    string descriptionFour =
                        "Help UNICEF ensure that child health and protection services are sustained and families have clean water and nutritious food.";
                    var nodesCurrentFundsFour = fundraiserResult.DocumentNode.Descendants("dd")
                        .Where(node => node.GetAttributeValue("data-qa", "").Contains("totalValue")).ToList();
                    string fundsFour = gbpCurrency;
                    string titleFour = "Unicef UK Fundraise for Ukraine";
                    string websiteFour = "https://www.justgiving.com/campaign/UNICEFUKRAINE";
                    propertiesList.Add(titleFour);
                    propertiesList.Add(fundsFour);
                    propertiesList.Add(descriptionFour);
                    propertiesList.Add(Convert.ToDouble(nodesCurrentFundsFour[0].InnerText.Substring(1, 12)));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteFour);
                    break;

                // UNHCR: Ukraine (No Current Funds, No Target)
                case 5:
                    fundraiserResult = toFundraiser.Load("https://donate.unhcr.org/int/en/ukraine-emergency");
                    string descriptionFive =
                        "UNHCR teams are on the ground providing winter supplies, emergency cash assistance for the most vulnerable and helping reinforce homes and shelters against the harsh weather.";
                    string fundsFive = eurCurrency;
                    string titleFive = "UNHCR: Ukraine";
                    string websiteFive = "https://donate.unhcr.org/int/en/ukraine-emergency";
                    propertiesList.Add(titleFive);
                    propertiesList.Add(fundsFive);
                    propertiesList.Add(descriptionFive);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteFive);
                    break;

                // Razom Foundation (No Current Funds, No Target)
                case 6:
                    fundraiserResult = toFundraiser.Load("https://www.razomforukraine.org/donate/");
                    string descriptionSix =
                        "Razom, which means “together” in Ukrainian, believes deeply in the enormous potential of dedicated volunteers around the world united by a single goal: to unlock the potential of Ukraine.";
                    string fundsSix = eurCurrency;
                    string titleSix = "Razom Foundation";
                    string websiteSix = "https://www.razomforukraine.org/donate/";
                    propertiesList.Add(titleSix);
                    propertiesList.Add(fundsSix);
                    propertiesList.Add(descriptionSix);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteSix);
                    break;

                // Caritas (No Current Funds, No Target)
                case 7:
                    fundraiserResult = toFundraiser.Load("https://www.caritas.org/ukraine-appeal-22-2/");
                    string descriptionSeven =
                        "Caritas staff and volunteers throughout eastern Europe are working tirelessly to go out and meet thousands of refugees fleeing Ukraine, providing them with food, medicine and temporary accommodation.";
                    string fundsSeven = eurCurrency;
                    string titleSeven = "Caritas";
                    string websiteSeven = "https://www.caritas.org/ukraine-appeal-22-2/";
                    propertiesList.Add(titleSeven);
                    propertiesList.Add(fundsSeven);
                    propertiesList.Add(descriptionSeven);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteSeven);
                    break;

                // Vostok SOS (No Current Funds, No Target)
                case 8:
                    fundraiserResult =
                        toFundraiser.Load("https://vostok-sos.org/en/i-wanna-help/rekvizyty-dlia-hroshovoho-perekazu/");
                    string descriptionEight =
                        "Comprehensive assistance to conflict-affected persons and IDPs, promoting democratic transformation and human rights values in Ukraine.";
                    string fundsEight = eurCurrency;
                    string titleEight = "Vostok SOS";
                    string websiteEight = "https://vostok-sos.org/en/i-wanna-help/rekvizyty-dlia-hroshovoho-perekazu/";
                    propertiesList.Add(titleEight);
                    propertiesList.Add(fundsEight);
                    propertiesList.Add(descriptionEight);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteEight);
                    break;

                // UN Crisis Relief (No Current Funds, No Target)
                case 9:
                    fundraiserResult = toFundraiser.Load("https://crisisrelief.un.org/t/ukraine");
                    string descriptionNine =
                        "The Ukraine Humanitarian Fund is one of the UN's country-based pooled funds.";
                    string fundsNine = usdCurrency;
                    string titleNine = "UN Crisis Relief";
                    string websiteNine = "https://crisisrelief.un.org/t/ukraine";
                    propertiesList.Add(titleNine);
                    propertiesList.Add(fundsNine);
                    propertiesList.Add(descriptionNine);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteNine);
                    break;

                // Insight (No Current Funds, No Target)
                case 10:
                    fundraiserResult = toFundraiser.Load("https://www.insight-ukraine.org/en/join-donate/");
                    string descriptionTen =
                        "Ukrainian LGBTQ+ and feminist NGO ‘Insight’ collects donations to support LGBTQI+ people during the war in Ukraine";
                    string fundsTen = eurCurrency;
                    string titleTen = "Insight Ukraine";
                    string websiteTen = "https://www.insight-ukraine.org/en/join-donate/";
                    propertiesList.Add(titleTen);
                    propertiesList.Add(fundsTen);
                    propertiesList.Add(descriptionTen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteTen);
                    break;

                // Voices of Children (No Current Funds, No Target)
                case 11:
                    fundraiserResult = toFundraiser.Load("https://voices.org.ua/en/donat/");
                    string descriptionEleven =
                        "With your help, we give psychological and psychosocial support to children who suffered as a result of war operations.";
                    string fundsEleven = eurCurrency;
                    string titleEleven = "Voices of Children";
                    string websiteEleven = "https://voices.org.ua/en/donat/";
                    propertiesList.Add(titleEleven);
                    propertiesList.Add(fundsEleven);
                    propertiesList.Add(descriptionEleven);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteEleven);
                    break;

                // NAIU (No Current Funds, No Target)
                case 12:
                    fundraiserResult =
                        toFundraiser.Load(
                            "https://naiu.org.ua/the-national-assembly-of-people-with-disabilities-continue-its-work/");
                    string descriptionTwelve =
                        "NAPD protects the rights of women and men with disabilities by implementing national and international programmes.";
                    string fundsTwelve = eurCurrency;
                    string titleTwelve = "National Assembly of Persons with Disabilities of Ukraine";
                    string websiteTwelve =
                        "https://naiu.org.ua/the-national-assembly-of-people-with-disabilities-continue-its-work/";
                    propertiesList.Add(titleTwelve);
                    propertiesList.Add(fundsTwelve);
                    propertiesList.Add(descriptionTwelve);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteTwelve);
                    break;

                // Come Back Alive (No Current Funds, No Target)
                case 13:
                    fundraiserResult =
                        toFundraiser.Load("https://savelife.in.ua/en/donate-en/#donate-army-card-monthly");
                    string descriptionThirteen =
                        "The mission of Come Back Alive is limited to supplying technology, trainings, and accouterments to help save lives of Ukrainians and help our warriors defend Ukraine";
                    string fundsThirteen = eurCurrency;
                    string titleThirteen = "Come Back Alive";
                    string websiteThirteen = "https://savelife.in.ua/en/donate-en/#donate-army-card-monthly";
                    propertiesList.Add(titleThirteen);
                    propertiesList.Add(fundsThirteen);
                    propertiesList.Add(descriptionThirteen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteThirteen);
                    break;

                // Unite With Ukraine (No Current Funds, No Target)
                case 14:
                    fundraiserResult = toFundraiser.Load("https://www.unitewithukraine.com/donate_today");
                    string descriptionFourteen =
                        "The UWC, with over 55 years of experience working with Ukrainians around the globe, is in a unique position to quickly and efficiently provide help to Ukraine’s defenders.";
                    string fundsFourteen = usdCurrency;
                    string titleFourteen = "Unite With Ukraine";
                    string websiteFourteen = "https://www.unitewithukraine.com/donate_today";
                    propertiesList.Add(titleFourteen);
                    propertiesList.Add(fundsFourteen);
                    propertiesList.Add(descriptionFourteen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteFourteen);
                    break;

                // Hell Rides (No Current Funds, No Target)
                case 15:
                    fundraiserResult = toFundraiser.Load("https://pekelnitachky.com/en");
                    string descriptionFifteen =
                        "Donate money to purchase SUVs, pickup trucks and ATVs for the Armed Forces, Territorial Defense units, National Guard, and other military units of the Ukrainian Army.";
                    string fundsFifteen = eurCurrency;
                    string titleFifteen = "Hell Rides";
                    string websiteFifteen = "https://pekelnitachky.com/en";
                    propertiesList.Add(titleFifteen);
                    propertiesList.Add(fundsFifteen);
                    propertiesList.Add(descriptionFifteen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteFifteen);
                    break;

                // Kolo UA (No Target)
                case 16:
                    fundraiserResult = toFundraiser.Load("https://www.koloua.com/en");
                    string descriptionSixteen =
                        "Technology can accelerate these efforts and prevent worsening of the humanitarian crisis. Help Ukrainians fight the cause of the crisis, not just its consequences.";
                    string fundsSixteen = usdCurrency;
                    string titleSixteen = "Kolo UA";
                    string websiteSixteen = "https://www.koloua.com/en";
                    var nodesCurrentFundsSixteen = fundraiserResult.DocumentNode.Descendants("p").Where(node => node.GetAttributeValue("class", "").Contains("achievements__value")).ToList();
                    propertiesList.Add(titleSixteen);
                    propertiesList.Add(fundsSixteen);
                    propertiesList.Add(descriptionSixteen);
                    propertiesList.Add(Convert.ToDouble(nodesCurrentFundsSixteen[0].InnerText.Substring(1, 3) + "00,000"));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteSixteen);
                    break;

                // Helping Hand (No Current Funds, No Target)
                case 17:
                    fundraiserResult = toFundraiser.Load("https://helpinghand.org.ua/en");
                    string descriptionSeventeen =
                        "Our organization takes care of oldies, trying to meet their needs for food, clothes, medicines, transpiration, and other basic amenities.";
                    string fundsSeventeen = usdCurrency;
                    string titleSeventeen = "Hold My Hand";
                    string websiteSeventeen = "https://helpinghand.org.ua/en";
                    propertiesList.Add(titleSeventeen);
                    propertiesList.Add(fundsSeventeen);
                    propertiesList.Add(descriptionSeventeen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteSeventeen);
                    break;

                // Bird of Light (Often Unavailable)
                case 18:
                    fundraiserResult = toFundraiser.Load("https://fundly.com/save-ukrainian-refugees");
                    string descriptionEighteen =
                        "A Ukraine-based initiative raising funds to purchase critically needed food, medical supplies, and other essential items to help those in need in Ukraine.";
                    string fundsEighteen = usdCurrency;
                    string titleEighteen = "Bird of Light";
                    string websiteEighteen = "https://fundly.com/save-ukrainian-refugees";
                    var nodesCurrentFundsEighteen = fundraiserResult.DocumentNode.Descendants("h3").ToList();
                    var nodesTotalFundsEighteen = fundraiserResult.DocumentNode.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "").Contains("js-campaign-goal-target")).ToList();
                    propertiesList.Add(titleEighteen);
                    propertiesList.Add(fundsEighteen);
                    propertiesList.Add(descriptionEighteen);
                    propertiesList.Add(Convert.ToDouble(nodesCurrentFundsEighteen[2].InnerText.Substring(2)));
                    propertiesList.Add(Convert.ToDouble(nodesTotalFundsEighteen[0].InnerText.Substring(2)));
                    propertiesList.Add(websiteEighteen);
                    break;

                // Support VSU (No Current Funds, No Target)
                case 19:
                    fundraiserResult = toFundraiser.Load("https://fondy.ua/uk/help-ukraine/");
                    string descriptionNineteen = "A Fondy platform for the Armed Forces of Ukraine.";
                    string fundsNineteen = usdCurrency;
                    string titleNineteen = "Support VSU";
                    string websiteNineteen = "https://fondy.ua/uk/help-ukraine/";
                    propertiesList.Add(titleNineteen);
                    propertiesList.Add(fundsNineteen);
                    propertiesList.Add(descriptionNineteen);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteNineteen);
                    break;

                // United24 (Cannot Pull Information)
                case 20:
                    fundraiserResult = toFundraiser.Load("https://u24.gov.ua/'");
                    string descriptionTwenty =
                        "UNITED24 was launched by the President of Ukraine Volodymyr Zelenskyy as the main venue for collecting charitable donations in support of Ukraine.";
                    string fundsTwenty = usdCurrency;
                    string titleTwenty = "United24";
                    string websiteTwenty = "https://u24.gov.ua/'";
                    propertiesList.Add(titleTwenty);
                    propertiesList.Add(fundsTwenty);
                    propertiesList.Add(descriptionTwenty);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteTwenty);
                    break;

                // Monobank
                case 21:
                    fundraiserResult = toFundraiser.Load("https://uahelp.monobank.ua/");
                    string descriptionTwentyOne =
                        "Once a day, Monobank transfers this money to the single account at the National Bank of Ukraine to help the Ukrainian army";
                    string fundsTwentyOne = usdCurrency;
                    string titleTwentyOne = "Monobank";
                    string websiteTwentyOne = "https://uahelp.monobank.ua/";
                    propertiesList.Add(titleTwentyOne);
                    propertiesList.Add(fundsTwentyOne);
                    propertiesList.Add(descriptionTwentyOne);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteTwentyOne);
                    break;

                // Default
                default:
                    string descriptionDefault = "Default description";
                    string fundsDefault = usdCurrency;
                    string titleDefault = "Default title";
                    string websiteDefault = "https://uahelp.monobank.ua/";
                    propertiesList.Add(titleDefault);
                    propertiesList.Add(fundsDefault);
                    propertiesList.Add(descriptionDefault);
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(Convert.ToDouble(0));
                    propertiesList.Add(websiteDefault);
                    break;


            }

            return propertiesList;


        }

    }
}
