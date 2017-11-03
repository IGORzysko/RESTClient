using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTClient.Classes
{
    class ResponseStream
    {
        public static string GetResponseStream(HttpWebRequest request)
        {
            var responseResult = string.Empty;

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
                            responseResult = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return responseResult; 
        }
    }
}
