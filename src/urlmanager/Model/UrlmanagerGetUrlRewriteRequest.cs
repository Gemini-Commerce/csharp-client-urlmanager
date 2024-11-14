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
    /// UrlmanagerGetUrlRewriteRequest
    /// </summary>
    [DataContract(Name = "urlmanagerGetUrlRewriteRequest")]
    public partial class UrlmanagerGetUrlRewriteRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlmanagerGetUrlRewriteRequest" /> class.
        /// </summary>
        /// <param name="tenantId">Required..</param>
        /// <param name="id">id.</param>
        /// <param name="compoundIdentifier">compoundIdentifier.</param>
        public UrlmanagerGetUrlRewriteRequest(string tenantId = default(string), string id = default(string), GetUrlRewriteRequestCompoundIdentifier compoundIdentifier = default(GetUrlRewriteRequestCompoundIdentifier))
        {
            this.TenantId = tenantId;
            this.Id = id;
            this.CompoundIdentifier = compoundIdentifier;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Required.
        /// </summary>
        /// <value>Required.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CompoundIdentifier
        /// </summary>
        [DataMember(Name = "compoundIdentifier", EmitDefaultValue = false)]
        public GetUrlRewriteRequestCompoundIdentifier CompoundIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UrlmanagerGetUrlRewriteRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompoundIdentifier: ").Append(CompoundIdentifier).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
