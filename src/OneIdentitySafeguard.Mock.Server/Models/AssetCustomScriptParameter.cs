/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneIdentitySafeguard.Mock.Server.Models
{ 
    /// <summary>
    /// Parameters passed to custom platform script
    /// </summary>
    [DataContract]
    public partial class AssetCustomScriptParameter : IEquatable<AssetCustomScriptParameter>
    { 
        /// <summary>
        /// Name of the parameter
        /// </summary>
        /// <value>Name of the parameter</value>
        [Required]

        [StringLength(50, MinimumLength=1)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of the parameter. If not specified (or set to null) the existing value will be retained (or set to default type value for create, e.g. empty string)
        /// </summary>
        /// <value>Value of the parameter. If not specified (or set to null) the existing value will be retained (or set to default type value for create, e.g. empty string)</value>

        [MaxLength(8000)]
        [DataMember(Name="Value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="Type")]
        public CustomScriptParameterType Type { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [Required]

        [DataMember(Name="TaskName")]
        public TaskNames TaskName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetCustomScriptParameter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AssetCustomScriptParameter)obj);
        }

        /// <summary>
        /// Returns true if AssetCustomScriptParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetCustomScriptParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetCustomScriptParameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    TaskName == other.TaskName ||
                    TaskName != null &&
                    TaskName.Equals(other.TaskName)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (TaskName != null)
                    hashCode = hashCode * 59 + TaskName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetCustomScriptParameter left, AssetCustomScriptParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetCustomScriptParameter left, AssetCustomScriptParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
