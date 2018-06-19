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


namespace Cohesity.Models
{
    /// <summary>
    /// ProtectionStats
    /// </summary>
    [DataContract]
    public partial class ProtectionStats :  IEquatable<ProtectionStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionStats" /> class.
        /// </summary>
        /// <param name="numFailed">Number of Failed Objects..</param>
        /// <param name="numObjects">Number of Objects..</param>
        /// <param name="sizeBytes">Size in Bytes..</param>
        public ProtectionStats(int? numFailed = default(int?), int? numObjects = default(int?), long? sizeBytes = default(long?))
        {
            this.NumFailed = numFailed;
            this.NumObjects = numObjects;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Number of Failed Objects.
        /// </summary>
        /// <value>Number of Failed Objects.</value>
        [DataMember(Name="numFailed", EmitDefaultValue=false)]
        public int? NumFailed { get; set; }

        /// <summary>
        /// Number of Objects.
        /// </summary>
        /// <value>Number of Objects.</value>
        [DataMember(Name="numObjects", EmitDefaultValue=false)]
        public int? NumObjects { get; set; }

        /// <summary>
        /// Size in Bytes.
        /// </summary>
        /// <value>Size in Bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectionStats {\n");
            sb.Append("  NumFailed: ").Append(NumFailed).Append("\n");
            sb.Append("  NumObjects: ").Append(NumObjects).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
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
            return this.Equals(input as ProtectionStats);
        }

        /// <summary>
        /// Returns true if ProtectionStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumFailed == input.NumFailed ||
                    (this.NumFailed != null &&
                    this.NumFailed.Equals(input.NumFailed))
                ) && 
                (
                    this.NumObjects == input.NumObjects ||
                    (this.NumObjects != null &&
                    this.NumObjects.Equals(input.NumObjects))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                if (this.NumFailed != null)
                    hashCode = hashCode * 59 + this.NumFailed.GetHashCode();
                if (this.NumObjects != null)
                    hashCode = hashCode * 59 + this.NumObjects.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}
