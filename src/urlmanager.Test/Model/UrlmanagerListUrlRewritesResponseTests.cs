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
    ///  Class for testing UrlmanagerListUrlRewritesResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UrlmanagerListUrlRewritesResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UrlmanagerListUrlRewritesResponse
        //private UrlmanagerListUrlRewritesResponse instance;

        public UrlmanagerListUrlRewritesResponseTests()
        {
            // TODO uncomment below to create an instance of UrlmanagerListUrlRewritesResponse
            //instance = new UrlmanagerListUrlRewritesResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UrlmanagerListUrlRewritesResponse
        /// </summary>
        [Fact]
        public void UrlmanagerListUrlRewritesResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" UrlmanagerListUrlRewritesResponse
            //Assert.IsType<UrlmanagerListUrlRewritesResponse>(instance);
        }

        /// <summary>
        /// Test the property 'UrlRewrites'
        /// </summary>
        [Fact]
        public void UrlRewritesTest()
        {
            // TODO unit test for the property 'UrlRewrites'
        }

        /// <summary>
        /// Test the property 'NextPageToken'
        /// </summary>
        [Fact]
        public void NextPageTokenTest()
        {
            // TODO unit test for the property 'NextPageToken'
        }
    }
}
