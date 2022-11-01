using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    public class Distance
    {
        [JsonProperty("astronomical")]
        public double Astronomical { get; set; }

        [JsonProperty("lunar")]
        public double Lunar { get; set; }

        [JsonProperty("kilometers")]
        public double Kilometers { get; set; }

        [JsonProperty("miles")]
        public double Miles { get; set; }

        public override string ToString()
        {
            return $"Distance: (Astronomical: {Astronomical}; (Lunar: {Lunar}); " +
                $"(Kilometers: {Kilometers}); (Miles: {Miles}))";
        }
    }
}
