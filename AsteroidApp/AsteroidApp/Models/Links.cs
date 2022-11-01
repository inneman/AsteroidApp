using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    public class Links
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        public override string ToString()
        {
            return $"Links: ((Next: {Next}); (Previous: {Previous}); (Self: {Self}))";
        }
    }
}
