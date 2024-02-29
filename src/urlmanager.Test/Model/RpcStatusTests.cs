/*
 * Url Manager Service
 *
 * The URL Manager service provides a set of APIs for managing URL rewrites within your application. URL rewriting is a technique used to modify the appearance or structure of URLs while maintaining the functionality and accessibility of the underlying resources.  The URL Manager service offers various operations to create, retrieve, update, and delete URL rewrite configurations. These configurations allow you to define rules that map incoming URLs to different paths or destinations based on specific criteria. By using URL rewriting, you can enhance the user experience, improve SEO (Search Engine Optimization), and manage complex URL structures effectively.  To get started with the URL Manager service, you need to integrate the provided Proto API into your application. The API supports various programming languages and frameworks, making it easy to incorporate URL rewriting functionality into your existing codebase.  Once integrated, you can utilize the different API methods to create, manage, and query URL rewrite configurations based on your application's requirements.  Refer to the API documentation for detailed information on the request and response formats, authentication requirements, and example usage of each API method.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using urlmanager.Model;
using urlmanager.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace urlmanager.Test.Model
{
    /// <summary>
    ///  Class for testing RpcStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RpcStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RpcStatus
        //private RpcStatus instance;

        public RpcStatusTests()
        {
            // TODO uncomment below to create an instance of RpcStatus
            //instance = new RpcStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RpcStatus
        /// </summary>
        [Fact]
        public void RpcStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" RpcStatus
            //Assert.IsType<RpcStatus>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Fact]
        public void DetailsTest()
        {
            // TODO unit test for the property 'Details'
        }
    }
}
