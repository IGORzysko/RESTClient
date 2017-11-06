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
    public class RESTClientMethodsTests
    {
        [TestMethod()]
        public void MakePostRequestTest()
        {
            #region Arrange

            var responseResult = new object();
            var restClient = new RESTClientMethods();

            restClient.Endpoint = "https://jsonplaceholder.typicode.com/posts";

            #endregion

            #region Act

            var response = restClient.MakePostRequest();

            responseResult = RESTClientMethods.DeserializeFromJson(response);

            #endregion

            #region Assert

            Console.WriteLine(responseResult);
            Assert.IsNotNull(responseResult);

            #endregion

        }

        [TestMethod()]
        public void MakeGetRequestTest()
        {
            #region Arrange

            var responseResult = new object();
            var restClient = new RESTClientMethods();
            restClient.Endpoint = "http://api.nbp.pl/api/exchangerates/rates/C/EUR";

            #endregion

            #region Act

            var response = restClient.MakeGetRequest(new Dictionary<string, dynamic>
            {
                { "format", "json"}
            });

            responseResult = RESTClientMethods.DeserializeFromJson(response);

            #endregion

            #region Assert

            Console.WriteLine(responseResult);
            Assert.IsNotNull(response);

            #endregion


        }
    }
}