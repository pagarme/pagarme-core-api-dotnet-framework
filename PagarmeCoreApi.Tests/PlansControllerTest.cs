/*
 * PagarmeCoreApi.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities; 
using PagarmeCoreApi.PCL.Http.Client;
using PagarmeCoreApi.PCL.Http.Response;
using PagarmeCoreApi.Tests.Helpers;
using NUnit.Framework;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Controllers;
using PagarmeCoreApi.PCL.Exceptions;

namespace PagarmeCoreApi.Tests
{
    [TestFixture]
    public class PlansControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IPlansController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Plans;
        }

        /// <summary>
        /// Gets all plans 
        /// </summary>
        [Test]
        public async Task TestTestGetPlans() 
        {
            // Parameters for the API call
            int? page = null;
            int? size = null;
            string name = null;
            string status = null;
            string billingType = null;
            DateTime? createdSince = null;
            DateTime? createdUntil = null;

            // Perform API call
            PCL.Models.ListPlansResponse result = null;

            try
            {
                result = await controller.GetPlansAsync(page, size, name, status, billingType, createdSince, createdUntil);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}