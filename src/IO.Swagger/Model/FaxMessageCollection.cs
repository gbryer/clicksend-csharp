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
    /// Array of FaxMessage items
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class FaxMessageCollection :  IEquatable<FaxMessageCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxMessageCollection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaxMessageCollection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxMessageCollection" /> class.
        /// </summary>
        /// <param name="messages">Array of FaxMessage items (required).</param>
        /// <param name="fileUrl">URL of file to send (required).</param>
        public FaxMessageCollection(List<FaxMessage> messages = default(List<FaxMessage>), string fileUrl = default(string))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new InvalidDataException("messages is a required property for FaxMessageCollection and cannot be null");
            }
            else
            {
                this.Messages = messages;
            }
            // to ensure "fileUrl" is required (not null)
            if (fileUrl == null)
            {
                throw new InvalidDataException("fileUrl is a required property for FaxMessageCollection and cannot be null");
            }
            else
            {
                this.FileUrl = fileUrl;
            }
        }
        
        /// <summary>
        /// Array of FaxMessage items
        /// </summary>
        /// <value>Array of FaxMessage items</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<FaxMessage> Messages { get; set; }

        /// <summary>
        /// URL of file to send
        /// </summary>
        /// <value>URL of file to send</value>
        [DataMember(Name="file_url", EmitDefaultValue=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaxMessageCollection {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
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
            return this.Equals(input as FaxMessageCollection);
        }

        /// <summary>
        /// Returns true if FaxMessageCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of FaxMessageCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxMessageCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.FileUrl != null)
                    hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
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
