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
    ///  Class for testing EmailDeliveryReceiptRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailDeliveryReceiptRulesApiTests
    {
        private EmailDeliveryReceiptRulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailDeliveryReceiptRulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailDeliveryReceiptRulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailDeliveryReceiptRulesApi
            //Assert.IsInstanceOfType(typeof(EmailDeliveryReceiptRulesApi), instance, "instance is a EmailDeliveryReceiptRulesApi");
        }

        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationDelete
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.EmailDeliveryReceiptAutomationDelete(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationGet
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.EmailDeliveryReceiptAutomationGet(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationPost
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.EmailDeliveryReceiptAutomationPost(deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationPut
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.EmailDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationsGet
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailDeliveryReceiptAutomationsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
