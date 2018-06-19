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
    /// PureStorageArray
    /// </summary>
    [DataContract]
    public partial class PureStorageArray :  IEquatable<PureStorageArray>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PureStorageArray" /> class.
        /// </summary>
        /// <param name="id">Specifies a unique id of a Pure Storage Array. The id is unique across Cohesity Clusters..</param>
        /// <param name="ports">ports.</param>
        /// <param name="revision">Specifies the revision of the Pure Storage Array..</param>
        /// <param name="version">Specifies the version of the Pure Storage Array..</param>
        public PureStorageArray(string id = default(string), List<IscsiSanPort> ports = default(List<IscsiSanPort>), string revision = default(string), string version = default(string))
        {
            this.Id = id;
            this.Ports = ports;
            this.Revision = revision;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies a unique id of a Pure Storage Array. The id is unique across Cohesity Clusters.
        /// </summary>
        /// <value>Specifies a unique id of a Pure Storage Array. The id is unique across Cohesity Clusters.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Ports
        /// </summary>
        [DataMember(Name="ports", EmitDefaultValue=false)]
        public List<IscsiSanPort> Ports { get; set; }

        /// <summary>
        /// Specifies the revision of the Pure Storage Array.
        /// </summary>
        /// <value>Specifies the revision of the Pure Storage Array.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public string Revision { get; set; }

        /// <summary>
        /// Specifies the version of the Pure Storage Array.
        /// </summary>
        /// <value>Specifies the version of the Pure Storage Array.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PureStorageArray {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PureStorageArray);
        }

        /// <summary>
        /// Returns true if PureStorageArray instances are equal
        /// </summary>
        /// <param name="input">Instance of PureStorageArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PureStorageArray input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
