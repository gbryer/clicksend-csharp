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
    ///  Class for testing PostDirectMailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PostDirectMailApiTests
    {
        private PostDirectMailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PostDirectMailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostDirectMailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PostDirectMailApi
            //Assert.IsInstanceOfType(typeof(PostDirectMailApi), instance, "instance is a PostDirectMailApi");
        }

        
        /// <summary>
        /// Test PostDirectMailCampaignsGet
        /// </summary>
        [Test]
        public void PostDirectMailCampaignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostDirectMailCampaignsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostDirectMailCampaignsPricePost
        /// </summary>
        [Test]
        public void PostDirectMailCampaignsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostDirectMail postDirectMail = null;
            //var response = instance.PostDirectMailCampaignsPricePost(postDirectMail);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostDirectMailCampaignsSendPost
        /// </summary>
        [Test]
        public void PostDirectMailCampaignsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostDirectMail postDirectMail = null;
            //var response = instance.PostDirectMailCampaignsSendPost(postDirectMail);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostDirectMailLocationsSearchByCountryGet
        /// </summary>
        [Test]
        public void PostDirectMailLocationsSearchByCountryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostDirectMailLocationsSearchByCountryGet(country, q, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
