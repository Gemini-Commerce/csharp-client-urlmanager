/*
 * Url Manager Service
 *
 * The URL Manager service provides a set of APIs for managing URL rewrites within your application. URL rewriting is a technique used to modify the appearance or structure of URLs while maintaining the functionality and accessibility of the underlying resources.  The URL Manager service offers various operations to create, retrieve, update, and delete URL rewrite configurations. These configurations allow you to define rules that map incoming URLs to different paths or destinations based on specific criteria. By using URL rewriting, you can enhance the user experience, improve SEO (Search Engine Optimization), and manage complex URL structures effectively.  To get started with the URL Manager service, you need to integrate the provided Proto API into your application. The API supports various programming languages and frameworks, making it easy to incorporate URL rewriting functionality into your existing codebase.  Once integrated, you can utilize the different API methods to create, manage, and query URL rewrite configurations based on your application's requirements.  Refer to the API documentation for detailed information on the request and response formats, authentication requirements, and example usage of each API method.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = urlmanager.Client.OpenAPIDateConverter;

namespace urlmanager.Model
{
    /// <summary>
    /// UrlmanagerListUrlRewritesRequest
    /// </summary>
    [DataContract(Name = "urlmanagerListUrlRewritesRequest")]
    public partial class UrlmanagerListUrlRewritesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlmanagerListUrlRewritesRequest" /> class.
        /// </summary>
        /// <param name="tenantId">Required..</param>
        /// <param name="filter">filter.</param>
        /// <param name="pageSize">The maximum number of url rewrites to return. The service may return fewer than this value. If unspecified, at most 10 url rewrites will be returned. The maximum value is 200; values above 200 will be coerced to 200..</param>
        /// <param name="pageToken">A page token, received from a previous &#x60;ListUrlRewrites&#x60; call. Provide this to retrieve the subsequent page.   When paginating, all other parameters provided to &#x60;ListUrlRewrites&#x60; must match the call that provided the page token..</param>
        public UrlmanagerListUrlRewritesRequest(string tenantId = default(string), ListUrlRewritesRequestFilter filter = default(ListUrlRewritesRequestFilter), long pageSize = default(long), string pageToken = default(string))
        {
            this.TenantId = tenantId;
            this.Filter = filter;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Required.
        /// </summary>
        /// <value>Required.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public ListUrlRewritesRequestFilter Filter { get; set; }

        /// <summary>
        /// The maximum number of url rewrites to return. The service may return fewer than this value. If unspecified, at most 10 url rewrites will be returned. The maximum value is 200; values above 200 will be coerced to 200.
        /// </summary>
        /// <value>The maximum number of url rewrites to return. The service may return fewer than this value. If unspecified, at most 10 url rewrites will be returned. The maximum value is 200; values above 200 will be coerced to 200.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous &#x60;ListUrlRewrites&#x60; call. Provide this to retrieve the subsequent page.   When paginating, all other parameters provided to &#x60;ListUrlRewrites&#x60; must match the call that provided the page token.
        /// </summary>
        /// <value>A page token, received from a previous &#x60;ListUrlRewrites&#x60; call. Provide this to retrieve the subsequent page.   When paginating, all other parameters provided to &#x60;ListUrlRewrites&#x60; must match the call that provided the page token.</value>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UrlmanagerListUrlRewritesRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}