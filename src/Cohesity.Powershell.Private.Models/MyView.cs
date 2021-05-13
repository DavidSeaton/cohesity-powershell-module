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
    /// MyView
    /// </summary>
    [DataContract]
    public partial class MyView :  IEquatable<MyView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyView" /> class.
        /// </summary>
        /// <param name="createDateMsecs">createDateMsecs.</param>
        /// <param name="currentTime">currentTime.</param>
        public MyView(decimal createDateMsecs = default(decimal), string currentTime = default(string))
        {
            this.CreateDateMsecs = createDateMsecs;
            this.CurrentTime = currentTime;
        }
        
        /// <summary>
        /// Gets or Sets CreateDateMsecs
        /// </summary>
        [DataMember(Name="createDateMsecs", EmitDefaultValue=false)]
        public decimal CreateDateMsecs { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTime
        /// </summary>
        [DataMember(Name="currentTime", EmitDefaultValue=false)]
        public string CurrentTime { get { return (DateTime.Now.ToString()); } set { } }

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
            return this.Equals(input as MyView);
        }

        /// <summary>
        /// Returns true if MyView instances are equal
        /// </summary>
        /// <param name="input">Instance of MyView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MyView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateDateMsecs == input.CreateDateMsecs ||
                    this.CreateDateMsecs.Equals(input.CreateDateMsecs)
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
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
                hashCode = hashCode * 59 + this.CreateDateMsecs.GetHashCode();
                if (this.CurrentTime != null)
                    hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                return hashCode;
            }
        }

    }

}

