using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.DataService.Models
{
    public class RestServiceModel
    {
        public string Url { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Type { get; set; }
    }
}
