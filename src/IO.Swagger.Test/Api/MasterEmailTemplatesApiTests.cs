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

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MasterEmailTemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MasterEmailTemplatesApiTests
    {
        private MasterEmailTemplatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MasterEmailTemplatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MasterEmailTemplatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MasterEmailTemplatesApi
            //Assert.IsInstanceOfType(typeof(MasterEmailTemplatesApi), instance, "instance is a MasterEmailTemplatesApi");
        }

        
        /// <summary>
        /// Test MasterEmailTemplateCategoriesGet
        /// </summary>
        [Test]
        public void MasterEmailTemplateCategoriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.MasterEmailTemplateCategoriesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MasterEmailTemplateCategoryGet
        /// </summary>
        [Test]
        public void MasterEmailTemplateCategoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? categoryId = null;
            //var response = instance.MasterEmailTemplateCategoryGet(categoryId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MasterEmailTemplateGet
        /// </summary>
        [Test]
        public void MasterEmailTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //var response = instance.MasterEmailTemplateGet(templateId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MasterEmailTemplatesGet
        /// </summary>
        [Test]
        public void MasterEmailTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.MasterEmailTemplatesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MasterEmailTemplatesInCategoryGet
        /// </summary>
        [Test]
        public void MasterEmailTemplatesInCategoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? categoryId = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.MasterEmailTemplatesInCategoryGet(categoryId, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
