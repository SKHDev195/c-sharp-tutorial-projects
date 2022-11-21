using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Weather_Report_Limassol.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Weather_Report_Limassol
{

    public partial class Form1 : Form
    {

        private WeatherInfo dayOne = new WeatherInfo(0);
        private WeatherInfo dayTwo = new WeatherInfo(1);
        private WeatherInfo dayThree = new WeatherInfo(2);

        public Form1()
        {

            InitializeComponent();

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 4;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 4;
            this.Location = new Point((screen.Width - w) / 4, (screen.Height - h) / 4);
            this.Size = new Size(w, h);

            Font generalFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            Bitmap iconOne = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{dayOne.Icon}");
            this.weatherPicDayOne.Image = iconOne;
            this.weatherPicDayOne.SizeMode = PictureBoxSizeMode.CenterImage;
            Bitmap iconTwo = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{dayTwo.Icon}");
            this.weatherPicDayTwo.Image = iconTwo;
            this.weatherPicDayTwo.SizeMode = PictureBoxSizeMode.CenterImage;
            Bitmap iconThree = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{dayThree.Icon}");
            this.weatherPicDayThree.Image = iconThree;
            this.weatherPicDayThree.SizeMode = PictureBoxSizeMode.CenterImage;

            this.textReportDayOne.Font = generalFont;
            this.textReportDayOne.ForeColor = Color.AntiqueWhite;
            this.textReportDayTwo.Font = generalFont;
            this.textReportDayTwo.ForeColor = Color.AntiqueWhite;
            this.textReportDayThree.Font = generalFont;
            this.textReportDayThree.ForeColor = Color.AntiqueWhite;

            this.textReportDayOne.Text = $"Temperature: {dayOne.Temperature};\r\nMax Temperature: {dayOne.Temperature};\r\nHumidity: {dayOne.Humidity};\r\nConditions: {dayOne.Conditions}";
            this.textReportDayTwo.Text = $"Temperature: {dayTwo.Temperature};\r\nMax Temperature: {dayTwo.Temperature};\r\nHumidity: {dayTwo.Humidity};\r\nConditions: {dayTwo.Conditions}";
            this.textReportDayThree.Text = $"Temperature: {dayThree.Temperature};\r\nMax Temperature: {dayThree.Temperature};\r\nHumidity: {dayThree.Humidity};\r\nConditions: {dayThree.Conditions}";
            
            this.textDateDayOne.Font = generalFont;
            this.textDateDayOne.ForeColor = Color.AntiqueWhite;
            this.textDateDayTwo.Font = generalFont;
            this.textDateDayTwo.ForeColor = Color.AntiqueWhite;
            this.textDateDayThree.Font = generalFont;
            this.textDateDayThree.ForeColor = Color.AntiqueWhite;

            this.textDateDayOne.Text = dayOne.Date.Substring(0,10);
            this.textDateDayTwo.Text = dayTwo.Date.Substring(0,10);
            this.textDateDayThree.Text = dayThree.Date.Substring(0,10);



        }


    }
}
