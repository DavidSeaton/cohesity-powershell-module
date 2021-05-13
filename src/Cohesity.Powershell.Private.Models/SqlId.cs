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
    /// SqlId
    /// </summary>
    [DataContract]
    public partial class SqlId :  IEquatable<SqlId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlId" /> class.
        /// </summary>
        /// <param name="databaseId">databaseId.</param>
        /// <param name="createDateMsecs">createDateMsecs.</param>
        public SqlId(int databaseId = default(int), decimal createDateMsecs = default(decimal))
        {
            this.DatabaseId = databaseId;
            this.CreateDateMsecs = createDateMsecs;
        }
        
        /// <summary>
        /// Gets or Sets DatabaseId
        /// </summary>
        [DataMember(Name="databaseId", EmitDefaultValue=false)]
        public int DatabaseId { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateMsecs
        /// </summary>
        [DataMember(Name="createDateMsecs", EmitDefaultValue=false)]
        public decimal CreateDateMsecs { get; set; }

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
            return this.Equals(input as SqlId);
        }

        /// <summary>
        /// Returns true if SqlId instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseId == input.DatabaseId ||
                    this.DatabaseId.Equals(input.DatabaseId)
                ) && 
                (
                    this.CreateDateMsecs == input.CreateDateMsecs ||
                    this.CreateDateMsecs.Equals(input.CreateDateMsecs)
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
                hashCode = hashCode * 59 + this.DatabaseId.GetHashCode();
                hashCode = hashCode * 59 + this.CreateDateMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

