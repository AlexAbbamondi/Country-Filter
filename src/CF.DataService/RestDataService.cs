using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.DataService.Models;
using System.Net;
using Newtonsoft.Json;

namespace CF.DataService
{
    public class RestDataService
    {
        /// <summary>
        /// send request return json and deserialize into a given type, T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public T GetResult<T>(RestServiceModel model)
        {
            var request = (HttpWebRequest) WebRequest.Create(model.Url);
            this.SetRequestHeaders(request, model.Headers);
            request.Method = model.Type;

            var response = request.GetResponse();
            var responseBody = string.Empty;
            using (var responseStream = response.GetResponseStream())
            {
                if (responseStream != null)
                {
                    using (var responseReader = new StreamReader(responseStream))
                    {
                        responseBody = responseReader.ReadToEnd();
                    }
                }
            }

            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        /// <summary>
        /// Loop through each header and add key and value
        /// </summary>
        /// <param name="request"></param>
        /// <param name="headers"></param>
        private void SetRequestHeaders(HttpWebRequest request, Dictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }



    }
}
