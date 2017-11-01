using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;
using System.Net;
using System.IO;
using Newtonsoft.Json;

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

        private string _contentType;

        string ContentType
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

        public string MakeRequest()
        {
            var responseString = string.Empty;

            var request = (HttpWebRequest)WebRequest.Create(Endpoint);
            request.ContentType = ContentType;
            request.Method = HttpMethod.ToString();

            if (request.Method == "POST")
            {
                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {

                    // add logic here ...

                    var jsonContent = JsonConvert.SerializeObject("");

                    streamWriter.Write(jsonContent);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

            else
            {
                // add logic here ...
            }

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

        public string AddGETParameters ()
        {
            // add logic here ...

            return string.Empty;
        }

        public string AddPOSTParameters ()
        {
            // add logic here ...

            return string.Empty;
        }
    }
}