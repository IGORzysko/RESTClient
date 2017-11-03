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
    public class RESTClient : IRESTClient
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

        public string MakePostRequest(Dictionary<string, dynamic> bodyParameters)
        {
            try
            {
                var responseString = string.Empty;

                var request = (HttpWebRequest)WebRequest.Create(Endpoint);
                request.ContentType = ContentType;

                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    var jsonContent = SerializeToJson(bodyParameters);

                    streamWriter.Write(jsonContent);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                responseString = ResponseStream.GetResponseStream(request);

                return responseString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public string MakeGetRequest(Dictionary<string, dynamic> parameters)
        {
            try
            {
                var responseString = string.Empty;

                Endpoint = BuildUri(Endpoint, parameters);

                var request = (HttpWebRequest)WebRequest.Create(Endpoint);
                request.ContentType = ContentType;

                responseString = ResponseStream.GetResponseStream(request);

                return responseString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        public string BuildUri (string Endpoint, Dictionary<string, dynamic> parameters)
        {

            var uriBuilder = new UriBuilder(Endpoint);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (var itemPair in parameters)
            {
                if (itemPair.Key is string)
                    query[itemPair.Key] = itemPair.Value;
                else
                    query[itemPair.Key] = itemPair.Value.ToString();
            }

            uriBuilder.Query = query.ToString();
            Endpoint = uriBuilder.ToString();

            return Endpoint;
        }

        public string SerializeToJson (Dictionary<string, dynamic> dictionary)
        {
            var jsonContent = JsonConvert.SerializeObject(dictionary);

            return jsonContent;
        }
    }
}