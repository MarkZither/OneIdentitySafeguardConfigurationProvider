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
    /// Settings related to session access requests
    /// </summary>
    [DataContract]
    public partial class PlatformCustomScriptProperties : IEquatable<PlatformCustomScriptProperties>
    { 
        /// <summary>
        /// Whether a script has been uploaded for this custom platform (Read-only)
        /// </summary>
        /// <value>Whether a script has been uploaded for this custom platform (Read-only)</value>

        [DataMember(Name="HasScript")]
        public bool? HasScript { get; set; }

        /// <summary>
        /// A list of parameters that should be provided to the custom platform script when invoked
        /// </summary>
        /// <value>A list of parameters that should be provided to the custom platform script when invoked</value>

        [DataMember(Name="Parameters")]
        public List<CustomScriptParameter> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformCustomScriptProperties {\n");
            sb.Append("  HasScript: ").Append(HasScript).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PlatformCustomScriptProperties)obj);
        }

        /// <summary>
        /// Returns true if PlatformCustomScriptProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of PlatformCustomScriptProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformCustomScriptProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HasScript == other.HasScript ||
                    HasScript != null &&
                    HasScript.Equals(other.HasScript)
                ) && 
                (
                    Parameters == other.Parameters ||
                    Parameters != null &&
                    Parameters.SequenceEqual(other.Parameters)
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
                    if (HasScript != null)
                    hashCode = hashCode * 59 + HasScript.GetHashCode();
                    if (Parameters != null)
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PlatformCustomScriptProperties left, PlatformCustomScriptProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlatformCustomScriptProperties left, PlatformCustomScriptProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
