using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;

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

        private HttpMethodEnum httpMethodEnum;

        HttpMethodEnum HttpMethodEnum
        {
            get
            {
                return httpMethodEnum;
            }
            set
            {
                httpMethodEnum = value;
            }
        }

        public RESTClient ()
        {

        }
        
        public string MakeRequest ()
        {
            // implement logic here ...

            return "";
        }

    }
}
