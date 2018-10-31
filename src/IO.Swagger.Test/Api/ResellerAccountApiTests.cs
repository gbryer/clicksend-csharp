/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ResellerAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ResellerAccountApiTests
    {
        private ResellerAccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResellerAccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResellerAccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ResellerAccountApi
            //Assert.IsInstanceOfType(typeof(ResellerAccountApi), instance, "instance is a ResellerAccountApi");
        }

        
        /// <summary>
        /// Test ResellerAccountsByClientUserIdGet
        /// </summary>
        [Test]
        public void ResellerAccountsByClientUserIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? clientUserId = null;
            //var response = instance.ResellerAccountsByClientUserIdGet(clientUserId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ResellerAccountsByClientUserIdPut
        /// </summary>
        [Test]
        public void ResellerAccountsByClientUserIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? clientUserId = null;
            //ResellerAccount resellerAccount = null;
            //var response = instance.ResellerAccountsByClientUserIdPut(clientUserId, resellerAccount);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ResellerAccountsGet
        /// </summary>
        [Test]
        public void ResellerAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.ResellerAccountsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ResellerAccountsPost
        /// </summary>
        [Test]
        public void ResellerAccountsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ResellerAccount resellerAccount = null;
            //var response = instance.ResellerAccountsPost(resellerAccount);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
