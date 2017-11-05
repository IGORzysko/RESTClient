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
            Assert.Fail();
        }

        [TestMethod()]
        public void MakeGetRequestTest()
        {
            #region Arrange

            var responseResult = new object();
            var restClient = new RESTClient();
            restClient.Endpoint = "http://api.nbp.pl/api/exchangerates/rates/C/EUR";

            #endregion

            #region Act

            var response = restClient.MakeGetRequest(new Dictionary<string, dynamic>
            {
                { "format", "json"}
            });

            responseResult = RESTClient.DeserializeFromJson(response);

            #endregion

            #region Assert

            Console.WriteLine(responseResult);
            Assert.IsNotNull(response);

            #endregion


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