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
    /// Specifies a file or a directory to protect in a Physical Server. If a directory is specified, all of its descendants are also backed up. Optionally, files or subdirectories can be explicitly excluded.
    /// </summary>
    [DataContract]
    public partial class FilePathParameters :  IEquatable<FilePathParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePathParameters" /> class.
        /// </summary>
        /// <param name="backupFilePath">Specifies absolute path to a file or a directory in a Physical Server to protect..</param>
        /// <param name="excludedFilePaths">Specifies absolute paths to descendant files or subdirectories of backupFilePath that should not be protected..</param>
        /// <param name="skipNestedVolumes">Specifies if any subdirectories under backupFilePath, where local or network volumes are mounted, should be excluded from being protected. If true, the volumes are not protected..</param>
        public FilePathParameters(string backupFilePath = default(string), List<string> excludedFilePaths = default(List<string>), bool? skipNestedVolumes = default(bool?))
        {
            this.BackupFilePath = backupFilePath;
            this.ExcludedFilePaths = excludedFilePaths;
            this.SkipNestedVolumes = skipNestedVolumes;
        }
        
        /// <summary>
        /// Specifies absolute path to a file or a directory in a Physical Server to protect.
        /// </summary>
        /// <value>Specifies absolute path to a file or a directory in a Physical Server to protect.</value>
        [DataMember(Name="backupFilePath", EmitDefaultValue=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// Specifies absolute paths to descendant files or subdirectories of backupFilePath that should not be protected.
        /// </summary>
        /// <value>Specifies absolute paths to descendant files or subdirectories of backupFilePath that should not be protected.</value>
        [DataMember(Name="excludedFilePaths", EmitDefaultValue=false)]
        public List<string> ExcludedFilePaths { get; set; }

        /// <summary>
        /// Specifies if any subdirectories under backupFilePath, where local or network volumes are mounted, should be excluded from being protected. If true, the volumes are not protected.
        /// </summary>
        /// <value>Specifies if any subdirectories under backupFilePath, where local or network volumes are mounted, should be excluded from being protected. If true, the volumes are not protected.</value>
        [DataMember(Name="skipNestedVolumes", EmitDefaultValue=false)]
        public bool? SkipNestedVolumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilePathParameters {\n");
            sb.Append("  BackupFilePath: ").Append(BackupFilePath).Append("\n");
            sb.Append("  ExcludedFilePaths: ").Append(ExcludedFilePaths).Append("\n");
            sb.Append("  SkipNestedVolumes: ").Append(SkipNestedVolumes).Append("\n");
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
            return this.Equals(input as FilePathParameters);
        }

        /// <summary>
        /// Returns true if FilePathParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of FilePathParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilePathParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupFilePath == input.BackupFilePath ||
                    (this.BackupFilePath != null &&
                    this.BackupFilePath.Equals(input.BackupFilePath))
                ) && 
                (
                    this.ExcludedFilePaths == input.ExcludedFilePaths ||
                    this.ExcludedFilePaths != null &&
                    this.ExcludedFilePaths.SequenceEqual(input.ExcludedFilePaths)
                ) && 
                (
                    this.SkipNestedVolumes == input.SkipNestedVolumes ||
                    (this.SkipNestedVolumes != null &&
                    this.SkipNestedVolumes.Equals(input.SkipNestedVolumes))
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
                if (this.BackupFilePath != null)
                    hashCode = hashCode * 59 + this.BackupFilePath.GetHashCode();
                if (this.ExcludedFilePaths != null)
                    hashCode = hashCode * 59 + this.ExcludedFilePaths.GetHashCode();
                if (this.SkipNestedVolumes != null)
                    hashCode = hashCode * 59 + this.SkipNestedVolumes.GetHashCode();
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
