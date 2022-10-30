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

namespace AsteroidApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetJson();
        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void SortButton_Clicked(object sender, EventArgs e)
        {
            
        }

        public void GetJson()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?" +
                "start_date=2020-11-18&end_date=2020-11-19" +
                "&api_key=QK36Tn9laJtbIDk2hO2PFuU9JiAxnubncCq7nF6f").Result.Content.ReadAsStringAsync().Result;
            JObject asteroids = JObject.Parse(response);
            JArray asteroidsData = (JArray)asteroids["near_earth_objects"]["2020-11-19"];

            List<DangerousObject> dangerousList = new List<DangerousObject>();
            for (int i = 0; i < asteroidsData.Count; i++)
            {
                DangerousObject dObj = asteroidsData[i].ToObject<DangerousObject>();
                dangerousList.Add(dObj);
            }

            objectListView.ItemsSource = dangerousList;
        }

        //List<DangerousObject> asteroidList = new List<DangerousObject>();
        //public async Task GetJsonAsync()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?start_date=2022-10-28&end_date=2022-10-29&api_key=xPz49IiOTyqp1kgy1R4YLga6vRJXt89x9lbsLgkh");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var content = await response.Content.ReadAsStringAsync();
        //        var jsonObject = JObject.Parse(content);
        //        //asteroidsLabel.Text = jsonObject.ToString();
        //        //var nearEarthObjects = jsonObject["near_earth_objects"];
        //        JArray asteroidsData = (JArray)jsonObject["near_earth_objects"].ToString();
        //        for (int i = 0; i < asteroidsData.Count; i++)
        //        {
        //            DangerousObject dObj = asteroidsData[i].ToObject<DangerousObject>();
        //            asteroidList.Add(dObj);
        //        }

        //        //foreach (var token in jsonArray)
        //        //{
        //        //    DangerousObject asteroid = new DangerousObject();
        //        //    string id = token["id"].ToString();
        //        //    string name = token["name"].ToString();
        //        //    asteroid.Id = id;
        //        //    asteroid.Name = name;

        //        //    asteroidList.Add(asteroid);
        //        //}
        //    }

        //    testListView.ItemsSource = asteroidList;
        //}
    }
}
