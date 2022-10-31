using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    class DangerousObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool Is_potentially_hazardous_asteroid { get; set; }

        [JsonProperty("close_approach_date")]
        public string ApproachDate { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string Nasa_jpl_url { get; set; }


        public override string ToString()
        {
            return $"Id: {Id} \n" +
                $"Jméno: {Name.Substring(0, (Name.Length > 20 ? 20 : Name.Length)),-20} \n" +
                $"Nebezpečný: {Is_potentially_hazardous_asteroid,-20} \n" +
                $"Datum: {ApproachDate} \n " + 
                $"Nasa: {Nasa_jpl_url}";
        }
    }
}
