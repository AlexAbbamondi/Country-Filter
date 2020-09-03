using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CF.DataService;

namespace CF.API.Controllers
{
    public class CountryFilterAPIController : Controller
    {
        private CountryInfoService countryInfoService;
        public CountryFilterAPIController()
        {
            this.countryInfoService = new CountryInfoService();
        }

        public string GetOrigin(string input)
        {
            return this.countryInfoService.GetCountryFromName(input);
        }
    }
}
