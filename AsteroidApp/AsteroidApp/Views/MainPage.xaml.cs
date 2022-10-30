using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AsteroidApp.Models;

namespace AsteroidApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void SortButton_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?" +
                "start_date=2020-11-18&end_date=2020-11-19" +
                "&api_key=QK36Tn9laJtbIDk2hO2PFuU9JiAxnubncCq7nF6f").Result.Content.ReadAsStringAsync().Result;

            JObject asteroids = JObject.Parse(response);
            string asteroidsDataForAllDates = ((JObject)asteroids["near_earth_objects"]).ToString();
            Dictionary<string, DangerousObject[]> nearEarthObjects =
                JsonConvert.DeserializeObject<Dictionary<string, DangerousObject[]>>(asteroidsDataForAllDates);

            foreach (var v in nearEarthObjects)
            {
                asteroidsLabel.Text += $"{v.Key}: ";
                foreach (var t in v.Value)
                {
                    asteroidsLabel.Text += t;
                }
            }
        }
    }
}
