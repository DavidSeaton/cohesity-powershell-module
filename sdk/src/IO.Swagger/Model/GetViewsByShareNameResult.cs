/* 
 * Cohesity REST API
 *
 * This API provides operations for interfacing with the Cohesity Cluster. NOTE: To view the documentation on the responses, click 'Model' next to 'Example Value' and keep clicking to expand the hierarchy.
 *
 * OpenAPI spec version: 1.0
 * 
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Specifies the list of Views and Aliases by share name that matched the specified filter criteria.
    /// </summary>
    [DataContract]
    public partial class GetViewsByShareNameResult :  IEquatable<GetViewsByShareNameResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewsByShareNameResult" /> class.
        /// </summary>
        /// <param name="paginationCookie">If set, i.e. there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetViewsByShare..</param>
        /// <param name="sharesList">Specifies the list of Views returned in this response..</param>
        public GetViewsByShareNameResult(string paginationCookie = default(string), List<Share> sharesList = default(List<Share>))
        {
            this.PaginationCookie = paginationCookie;
            this.SharesList = sharesList;
        }
        
        /// <summary>
        /// If set, i.e. there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetViewsByShare.
        /// </summary>
        /// <value>If set, i.e. there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetViewsByShare.</value>
        [DataMember(Name="paginationCookie", EmitDefaultValue=false)]
        public string PaginationCookie { get; set; }

        /// <summary>
        /// Specifies the list of Views returned in this response.
        /// </summary>
        /// <value>Specifies the list of Views returned in this response.</value>
        [DataMember(Name="sharesList", EmitDefaultValue=false)]
        public List<Share> SharesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetViewsByShareNameResult {\n");
            sb.Append("  PaginationCookie: ").Append(PaginationCookie).Append("\n");
            sb.Append("  SharesList: ").Append(SharesList).Append("\n");
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
            return this.Equals(input as GetViewsByShareNameResult);
        }

        /// <summary>
        /// Returns true if GetViewsByShareNameResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetViewsByShareNameResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetViewsByShareNameResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaginationCookie == input.PaginationCookie ||
                    (this.PaginationCookie != null &&
                    this.PaginationCookie.Equals(input.PaginationCookie))
                ) && 
                (
                    this.SharesList == input.SharesList ||
                    this.SharesList != null &&
                    this.SharesList.SequenceEqual(input.SharesList)
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
                if (this.PaginationCookie != null)
                    hashCode = hashCode * 59 + this.PaginationCookie.GetHashCode();
                if (this.SharesList != null)
                    hashCode = hashCode * 59 + this.SharesList.GetHashCode();
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
            yield break;
        }
    }

}
