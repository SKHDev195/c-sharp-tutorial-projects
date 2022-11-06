using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Weather_Report_Limassol
{

    public partial class Form1 : Form
    {
        
        WeatherInfo dayOne = new WeatherInfo(0);
        WeatherInfo dayTwo = new WeatherInfo(1);
        WeatherInfo dayThree = new WeatherInfo(2);

        public Form1()
        {

            InitializeComponent();

            //StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            this.textReportDayOne.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textReportDayTwo.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textReportDayThree.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textReportDayOne.Text = $"Temperature: {dayOne.Temperature};\r\nMax Temperature: {dayOne.Temperature};\r\nHumidity: {dayOne.Humidity};\r\nConditions: {dayOne.Conditions}";
            this.textReportDayTwo.Text = $"Temperature: {dayTwo.Temperature};\r\nMax Temperature: {dayTwo.Temperature};\r\nHumidity: {dayTwo.Humidity};\r\nConditions: {dayTwo.Conditions}";
            this.textReportDayThree.Text = $"Temperature: {dayThree.Temperature};\r\nMax Temperature: {dayThree.Temperature};\r\nHumidity: {dayThree.Humidity};\r\nConditions: {dayThree.Conditions}";
            this.textDateDayTwo.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textDateDayOne.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textDateDayThree.Font = new Font(textReportDayOne.Font.FontFamily, 16);
            this.textDateDayTwo.Text = dayOne.Date.Substring(0,9);
            this.textDateDayOne.Text = dayTwo.Date.Substring(0,9);
            this.textDateDayThree.Text = dayThree.Date.Substring(0,9);



            //this.Load += Form1_Load;
        }



    }
}
