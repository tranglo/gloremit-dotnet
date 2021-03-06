/* 
 * GloRemit - REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
    ///  Class for testing ForexApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ForexApiTests
    {
        private ForexApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForexApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ForexApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ForexApi
            //Assert.IsInstanceOfType(typeof(ForexApi), instance, "instance is a ForexApi");
        }

        
        /// <summary>
        /// Test V1PaymentsForexNextratesGet
        /// </summary>
        [Test]
        public void V1PaymentsForexNextratesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currFrom = null;
            //string currTo = null;
            //var response = instance.V1PaymentsForexNextratesGet(currFrom, currTo);
            //Assert.IsInstanceOf<GetForexModelResponse> (response, "response is GetForexModelResponse");
        }
        
        /// <summary>
        /// Test V1PaymentsForexRatesGet
        /// </summary>
        [Test]
        public void V1PaymentsForexRatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currFrom = null;
            //string currTo = null;
            //var response = instance.V1PaymentsForexRatesGet(currFrom, currTo);
            //Assert.IsInstanceOf<GetForexModelResponse> (response, "response is GetForexModelResponse");
        }
        
    }

}
