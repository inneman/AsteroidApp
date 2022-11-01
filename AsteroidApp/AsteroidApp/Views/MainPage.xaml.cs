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
using System.Diagnostics;
using AsteroidApp.Views;

namespace AsteroidApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetJsonAsync();
        }

        private void SortButton_Clicked(object sender, EventArgs e)
        {
            if (sortPicker.SelectedIndex == 0)
            {
                dangerousList = dangerousList.OrderBy(x => x.Name).ToList();
            }
            if (sortPicker.SelectedIndex == 1)
            {
                dangerousList = dangerousList.OrderByDescending(x => x.Is_potentially_hazardous_asteroid).ToList();
            }
            objectListView.ItemsSource = dangerousList;
        }

        List<DangerousObject> dangerousList = new List<DangerousObject>();
        public async Task GetJsonAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?" +
                "start_date=2020-11-18&end_date=2020-11-19" +
                "&api_key=QK36Tn9laJtbIDk2hO2PFuU9JiAxnubncCq7nF6f");
            var content = await response.Content.ReadAsStringAsync();
            JObject asteroids = JObject.Parse(content);
            JArray asteroidsData = (JArray)asteroids["near_earth_objects"]["2020-11-19"];

            for (int i = 0; i < asteroidsData.Count; i++)
            {
                DangerousObject dObj = asteroidsData[i].ToObject<DangerousObject>();
                dangerousList.Add(dObj);
            }

            objectListView.ItemsSource = dangerousList;
        }

        private void objectListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listVievIndex = objectListView.SelectedItem;

            Navigation.PushAsync(new ObjectPage(listVievIndex));
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            GetJsonAsync();
        }
    }
}
