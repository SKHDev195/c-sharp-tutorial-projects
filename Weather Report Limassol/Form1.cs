using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;


namespace Weather_Report_Limassol
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            RestClient weatherClient = new RestClient("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/weatherdata");

            var args = new
            {
                forecast = "forecast",
                locations = "limassol",
                aggregateHours = "24",
                forecastDays = "3",
                unitGroup = "metric",
                shortColumnNames = "false",
                contentType = "json",
                iconSet = "icons1",
                key = "3KQTHQWBFGAD4PQY32S4592N3",
            };

            var weatherResponse = weatherClient.GetJsonAsync<RestResponse>("{forecast}", args);



            InitializeComponent();

            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

            textReportDayOne.Text = weatherResponse.ToString(); 
        }



    }
}
