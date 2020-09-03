using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.DataService.Models;

namespace CF.DataService
{
    public class CountryInfoService
    {
        private string countryFilterUrl;
        private string countryFilterApiKey;
        private const string apiKeyHeader = "X-API-KEY";
        private RestDataService dataService;

        public CountryInfoService()
        {
            this.dataService = new RestDataService();
            this.countryFilterUrl = ConfigurationManager.AppSettings["CountryFilterServiceUrl"];
            this.countryFilterApiKey = ConfigurationManager.AppSettings["CountryFilterApiKey"];
        }

        public string GetCountryFromName(string fullName)
        {
            const string action = "country";
            var headers = new Dictionary<string, string> {{ apiKeyHeader, this.countryFilterApiKey}};

            var model = new RestServiceModel
            {
                Url = $"{this.countryFilterUrl}/{action}/{fullName}",
                Headers = headers,
                Type = "GET"
            };

            var result = this.dataService.GetResult<CountryInfoResponse>(model);
            return result.Country;
        }
    }
}
