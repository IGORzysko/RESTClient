using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTClient.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTClient.Classes.Tests
{
    [TestClass()]
    public class RESTClientTests
    {
        [TestMethod()]
        public void MakePostRequestTest()
        {
            var restClient = new RESTClient();
            restClient.Endpoint = "";

            var response = restClient.MakePostRequest(new Dictionary<string, dynamic>
            {

            });

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void MakeGetRequestTest()
        {
            var restClient = new RESTClient();
            restClient.Endpoint = "";

            var response = restClient.MakeGetRequest(new Dictionary<string, dynamic>
            {

            });

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void BuildUriTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SerializeToJsonTest()
        {
            Assert.Fail();
        }
    }
}