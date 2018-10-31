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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PostPostcard model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class PostPostcard :  IEquatable<PostPostcard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPostcard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostPostcard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPostcard" /> class.
        /// </summary>
        /// <param name="fileUrls">Postcard file URLs (required).</param>
        /// <param name="recipients">Array of recipients (required).</param>
        public PostPostcard(List<string> fileUrls = default(List<string>), List<PostRecipient> recipients = default(List<PostRecipient>))
        {
            // to ensure "fileUrls" is required (not null)
            if (fileUrls == null)
            {
                throw new InvalidDataException("fileUrls is a required property for PostPostcard and cannot be null");
            }
            else
            {
                this.FileUrls = fileUrls;
            }
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for PostPostcard and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
        }
        
        /// <summary>
        /// Postcard file URLs
        /// </summary>
        /// <value>Postcard file URLs</value>
        [DataMember(Name="file_urls", EmitDefaultValue=false)]
        public List<string> FileUrls { get; set; }

        /// <summary>
        /// Array of recipients
        /// </summary>
        /// <value>Array of recipients</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<PostRecipient> Recipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPostcard {\n");
            sb.Append("  FileUrls: ").Append(FileUrls).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPostcard);
        }

        /// <summary>
        /// Returns true if PostPostcard instances are equal
        /// </summary>
        /// <param name="input">Instance of PostPostcard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostPostcard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileUrls == input.FileUrls ||
                    this.FileUrls != null &&
                    this.FileUrls.SequenceEqual(input.FileUrls)
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FileUrls != null)
                    hashCode = hashCode * 59 + this.FileUrls.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
