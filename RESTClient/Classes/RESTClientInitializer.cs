using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web;

namespace RESTClient.Classes
{
    public class RESTClientInitializer
    {
        protected RESTClientInitializer()
        {

        }

        string _endpoint;

        public string Endpoint
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

        HttpMethodEnum _httpMethod;

        public HttpMethodEnum HttpMethod
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

        string _contentType;

        public string ContentType
        {
            get
            {
                return _contentType = "text / html";
            }
        }
    }
}