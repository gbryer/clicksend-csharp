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
    ///  Class for testing PostLetterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PostLetterApiTests
    {
        private PostLetterApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PostLetterApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostLetterApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PostLetterApi
            //Assert.IsInstanceOfType(typeof(PostLetterApi), instance, "instance is a PostLetterApi");
        }

        
        /// <summary>
        /// Test PostLettersExportGet
        /// </summary>
        [Test]
        public void PostLettersExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.PostLettersExportGet(filename);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PostLettersHistoryGet
        /// </summary>
        [Test]
        public void PostLettersHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostLettersHistoryGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostLettersPricePost
        /// </summary>
        [Test]
        public void PostLettersPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostLetter postLetter = null;
            //var response = instance.PostLettersPricePost(postLetter);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostLettersSendPost
        /// </summary>
        [Test]
        public void PostLettersSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostLetter postLetter = null;
            //var response = instance.PostLettersSendPost(postLetter);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
