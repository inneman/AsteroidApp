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
        public DateTime ApproachDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \t Jméno: {Name.Substring(0, (Name.Length > 20 ? 20 : Name.Length)),-20} " +
                $"\t Nebezpečný: {Is_potentially_hazardous_asteroid,-20}" +
                $"Datum: {ApproachDate} \n \n \n";
        }
    }
}
