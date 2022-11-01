using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    public class CloseApproachData
    {
        [JsonProperty("close_approach_date")]
        public DateTime ApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public DateTime ApproachFullDate { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public long ApproachEpoch { get; set; }

        [JsonProperty("relative_velocity")]
        public Velocity Velocity { get; set; }

        [JsonProperty("miss_distance")]
        public Distance MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }

        public override string ToString()
        {
            return $"Data: ((ApproachDate: {ApproachDate}); (ApproachFullDate: {ApproachFullDate}); " +
                $"(ApproachEpoch: {ApproachEpoch}); (RelativeVelocity: {Velocity}); " +
                $"(MissDistance: {MissDistance}); (OrbitingBody: {OrbitingBody}))";
        }
    }
}
