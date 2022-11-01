using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    public class Link
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        public override string ToString() => $"Link: ((Self: {Self}))";

    }
}
