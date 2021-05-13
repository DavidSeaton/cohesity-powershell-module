// Copyright 2019 Cohesity Inc.

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

namespace Cohesity.Private.Model
{
    /// <summary>
    /// SqlEntity
    /// </summary>
    [DataContract]
    public partial class SqlEntity :  IEquatable<SqlEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEntity" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="sqlId">sqlId.</param>
        public SqlEntity(int type = default(int), SqlId sqlId = default(SqlId))
        {
            this.Type = type;
            this.SqlId = sqlId;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int Type { get; set; }

        /// <summary>
        /// Gets or Sets SqlId
        /// </summary>
        [DataMember(Name="sqlId", EmitDefaultValue=false)]
        public SqlId SqlId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
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
            return this.Equals(input as SqlEntity);
        }

        /// <summary>
        /// Returns true if SqlEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SqlId == input.SqlId ||
                    (this.SqlId != null &&
                    this.SqlId.Equals(input.SqlId))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SqlId != null)
                    hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                return hashCode;
            }
        }

    }

}

