using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;
using System.Net;

namespace RESTClient.Classes
{
    internal class RESTClient : IRESTClient
    {
        private string endpoint;

        string Endpoint
        {
            get
            {
                return endpoint;
            }
            set
            {
                endpoint = value;
            }
        }

        private HttpMethodEnum httpMethod;

        HttpMethodEnum HttpMethod
        {
            get
            {
                return httpMethod;
            }
            set
            {
                httpMethod = value;
            }
        }
        
        public string MakeRequest (HttpMethod)
        {
            var request = (HttpWebRequest) WebRequest.Create(Endpoint);
            request.Method = httpMethod.ToString();

            // implement logic here ...

            return string.Empty;
        }

    }
}
