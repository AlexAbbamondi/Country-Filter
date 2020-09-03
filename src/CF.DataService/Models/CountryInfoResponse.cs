using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CF.DataService.Models
{
    class CountryInfoResponse
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryAlt")]
        public string CountryAlt { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("topRegion")]
        public string TopRegion { get; set; }

        [JsonProperty("subRegion")]
        public string SubRegion { get; set; }

        [JsonProperty("countriesTop")]
        public List<string> CountriesTop { get; set; }

        [JsonProperty("probabilityCalibrated")]
        public double ProbabilityCalibrated { get; set; }

        [JsonProperty("probabilityAltCalibrated")]
        public double ProbabilityAltCalibrated { get; set; }
    }
}
