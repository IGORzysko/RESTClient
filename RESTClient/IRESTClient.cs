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
        string MakeRequest(HttpMethodEnum httpMethod);
    }
}
