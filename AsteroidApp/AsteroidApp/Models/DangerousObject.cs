using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    class DangerousObject
    {
        [JsonProperty("links")]
        public Link Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool Is_potentially_hazardous_asteroid { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double Absolute_magnitude_h { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string Nasa_jpl_url { get; set; }

        [JsonProperty("estimated_diameter")]
        public EstimatedDiameter Estimated_diameter { get; set; }

        [JsonProperty("close_approach_data")]
        public CloseApproachData[] Close_approach_data { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool Is_sentry_object { get; set; }

        public override string ToString()
        {
            return $"DangerousObject: ((Links: {Links}); (ID: {Id});  (Name: {Name}); " +
                            $"(NasaJPLURL: {Nasa_jpl_url}); (AbsoluteMagnitude: {Absolute_magnitude_h}); " +
                            $"(EstimatedDiameter: {Estimated_diameter}); (PotenciallyHazardous: {Is_potentially_hazardous_asteroid}); " +
                            $"(Data: {string.Join<CloseApproachData>("; ", Close_approach_data)}); (IsSentryObject: {Is_sentry_object}))";
        }
    }
}
