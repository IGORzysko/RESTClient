using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;
using System.Net;
using System.IO;

namespace RESTClient.Classes
{
    internal class RESTClient : IRESTClient
    {
        private string _endpoint;

        string Endpoint
        {
            get
            {
                return _endpoint;
            }
            set
            {
                _endpoint = value;
            }
        }

        private HttpMethodEnum _httpMethod;

        HttpMethodEnum HttpMethod
        {
            get
            {
                return _httpMethod;
            }
            set
            {
                _httpMethod = value;
            }
        }

        public string MakeRequest(HttpMethodEnum httpMethod)
        {
            var responseString = string.Empty;

            var request = (HttpWebRequest)WebRequest.Create(Endpoint);
            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException($"Error code: {response.StatusCode}");

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader streamReader = new StreamReader(responseStream))
                        {
                            responseString = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return responseString;
        }
    }
}