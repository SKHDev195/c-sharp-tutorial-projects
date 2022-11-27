using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fundraisers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            this.KeyDown += MainWindow_KeyDown;

            List<int> fundraiserIdentifiers = GetUniqueIdentifiers();

            Fundraiser fundraiserOne = new Fundraiser(fundraiserIdentifiers[0]);
            Fundraiser fundraiserTwo = new Fundraiser(fundraiserIdentifiers[1]);
            Fundraiser fundraiserThree = new Fundraiser(fundraiserIdentifiers[2]);

            InitializeComponent();

            this.Height = SystemParameters.PrimaryScreenHeight * 0.7;
            this.Width = SystemParameters.PrimaryScreenWidth * 0.7;

            this.FOneTitle.Text = fundraiserOne.Title;
            this.FOneDescription.Text = fundraiserOne.Description;

            if (fundraiserOne.TotalFunds != Convert.ToDouble(0) && fundraiserOne.CurrentFunds != Convert.ToDouble(0))
            {
                this.FOneFunds.Text = $"Current funds / total funds: {String.Format("{0:n}", fundraiserOne.CurrentFunds)} / {String.Format("{0:n}", fundraiserOne.TotalFunds)} {fundraiserOne.Currency}";
                this.ProgressFOne.Maximum = fundraiserOne.TotalFunds;
                this.ProgressFOne.Value = fundraiserOne.CurrentFunds;
            }

            else if (fundraiserOne.CurrentFunds == Convert.ToDouble(0))
            {
                this.FOneFunds.Text = "This fundraiser does not have a funds tracker. We cannot track its progress.";
                this.FundraiserOne.Children.Remove(ProgressFOne);
            }

            else
            {
                this.FOneFunds.Text =
                    $"Current funds: {String.Format("{0:n}", fundraiserOne.CurrentFunds)} {fundraiserOne.Currency}. This fundraiser does not have a specific target and we cannot track its progress.";
                this.FundraiserOne.Children.Remove(ProgressFOne);
            }

            this.HyperlinkOne.NavigateUri = fundraiserOne.Website;
            this.HyperlinkOne.RequestNavigate += LinkOnRequestNavigate;

            this.FTwoTitle.Text = fundraiserTwo.Title;
            this.FTwoDescription.Text = fundraiserTwo.Description;

            if (fundraiserTwo.TotalFunds != Convert.ToDouble(0) && fundraiserTwo.CurrentFunds != Convert.ToDouble(0))
            {
                this.FTwoFunds.Text = $"Current funds / target: {String.Format("{0:n}", fundraiserTwo.CurrentFunds)} / {String.Format("{0:n}", fundraiserTwo.TotalFunds)} {fundraiserTwo.Currency}";
                this.ProgressFTwo.Maximum = fundraiserTwo.TotalFunds;
                this.ProgressFTwo.Value = fundraiserTwo.CurrentFunds;
            }

            else if (fundraiserTwo.CurrentFunds == Convert.ToDouble(0))
            {
                this.FTwoFunds.Text = "This fundraiser does not have a funds tracker. We cannot track its progress.";
                this.FundraiserTwo.Children.Remove(ProgressFTwo);
            }

            else
            {
                this.FTwoFunds.Text =
                    $"Current funds: {String.Format("{0:n}", fundraiserTwo.CurrentFunds)} {fundraiserTwo.Currency}. This fundraiser does not have a specific target and we cannot track its progress.";
                this.FundraiserTwo.Children.Remove(ProgressFTwo);
            }

            this.HyperlinkTwo.NavigateUri = fundraiserTwo.Website;
            this.HyperlinkTwo.RequestNavigate += LinkOnRequestNavigate;

            this.FThreeTitle.Text = fundraiserThree.Title;
            this.FThreeDescription.Text = fundraiserThree.Description;

            if (fundraiserThree.TotalFunds != Convert.ToDouble(0) && fundraiserThree.CurrentFunds != Convert.ToDouble(0))
            {
                this.FThreeFunds.Text = $"Current funds / total funds: {String.Format("{0:n}", fundraiserThree.CurrentFunds)} / {String.Format("{0:n}", fundraiserThree.TotalFunds)} {fundraiserThree.Currency}";
                this.ProgressFThree.Maximum = fundraiserThree.TotalFunds;
                this.ProgressFThree.Value = fundraiserThree.CurrentFunds;
            }

            else if (fundraiserThree.CurrentFunds == Convert.ToDouble(0))
            {
                this.FThreeFunds.Text = "This fundraiser does not have a funds tracker. We cannot track its progress.";
                this.FundraiserThree.Children.Remove(ProgressFThree);
            }

            else
            {
                this.FThreeFunds.Text =
                    $"Current funds: {String.Format("{0:n}", fundraiserThree.CurrentFunds)} {fundraiserThree.Currency}. This fundraiser does not have a specific target and we cannot track its progress.";
                this.FundraiserThree.Children.Remove(ProgressFThree);
            }

            this.HyperlinkThree.NavigateUri = fundraiserThree.Website;
            this.HyperlinkThree.RequestNavigate += LinkOnRequestNavigate;

        }

        /// <summary>
        /// Using Random.Next(), gets a list with three unique identifiers.
        /// </summary>
        /// <returns>A List<int> containing unique Fundraiser identifiers.</int></returns>
        private List<int> GetUniqueIdentifiers()
        {
            List<int> identifiers = new List<int>();

            while (identifiers.Count <= 2)
            {
                int identifier = Random.Shared.Next(0, 21);

                if (!identifiers.Contains(identifier))
                {
                    identifiers.Add(identifier);
                }
            }

            return identifiers;
        }

        /// <summary>
        /// Processes a navigate request for a 'Visit website' hyperlink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkOnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {e.Uri.ToString()}") { CreateNoWindow = true });
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {

                MainWindow newWindow = new MainWindow();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                this.Close();

            }
        }
    }
}
