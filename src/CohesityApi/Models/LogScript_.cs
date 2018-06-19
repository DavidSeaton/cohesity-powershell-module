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
    /// Specifies the script that should run for the Log backup schedule of a Remote Adapter &#39;kPuppeteer&#39; Job. This field is mandatory if the Policy associated with this Job has a Log backup schedule and this is Remote Adapter &#39;kPuppeteer&#39; Job.
    /// </summary>
    [DataContract]
    public partial class LogScript_ :  IEquatable<LogScript_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogScript_" /> class.
        /// </summary>
        /// <param name="scriptParams">Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;..</param>
        /// <param name="scriptPath">Specifies the path to the script on the remote host..</param>
        public LogScript_(string scriptParams = default(string), string scriptPath = default(string))
        {
            this.ScriptParams = scriptParams;
            this.ScriptPath = scriptPath;
        }
        
        /// <summary>
        /// Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.
        /// </summary>
        /// <value>Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.</value>
        [DataMember(Name="scriptParams", EmitDefaultValue=false)]
        public string ScriptParams { get; set; }

        /// <summary>
        /// Specifies the path to the script on the remote host.
        /// </summary>
        /// <value>Specifies the path to the script on the remote host.</value>
        [DataMember(Name="scriptPath", EmitDefaultValue=false)]
        public string ScriptPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogScript_ {\n");
            sb.Append("  ScriptParams: ").Append(ScriptParams).Append("\n");
            sb.Append("  ScriptPath: ").Append(ScriptPath).Append("\n");
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
            return this.Equals(input as LogScript_);
        }

        /// <summary>
        /// Returns true if LogScript_ instances are equal
        /// </summary>
        /// <param name="input">Instance of LogScript_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogScript_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScriptParams == input.ScriptParams ||
                    (this.ScriptParams != null &&
                    this.ScriptParams.Equals(input.ScriptParams))
                ) && 
                (
                    this.ScriptPath == input.ScriptPath ||
                    (this.ScriptPath != null &&
                    this.ScriptPath.Equals(input.ScriptPath))
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
                if (this.ScriptParams != null)
                    hashCode = hashCode * 59 + this.ScriptParams.GetHashCode();
                if (this.ScriptPath != null)
                    hashCode = hashCode * 59 + this.ScriptPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}
