using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    public class Estimate
    {
        [JsonProperty("estimated_diameter_min")]
        public double Min { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double Max { get; set; }

        public override string ToString()
        {
            return $"Estimate: ((Min diameter: {Min}); (Max diameter: {Max}))";
        }
    }
}
