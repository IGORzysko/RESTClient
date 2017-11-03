using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTClient.Classes;

namespace RESTClient
{
    interface IRESTClient
    {
        string MakePostRequest(Dictionary<string, dynamic> bodyParameters);
        string MakeGetRequest(Dictionary<string, dynamic> parameters);
    }
}
