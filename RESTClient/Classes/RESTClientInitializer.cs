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

        private string _endpoint;

        protected string Endpoint
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

        protected HttpMethodEnum HttpMethod
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

        private string _contentType;

        protected string ContentType
        {
            get
            {
                return _contentType;
            }
            set
            {
                _contentType = value;
            }
        }
    }
}