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
    /// Parameters for checking uniqueness of entity names
    /// </summary>
    [DataContract]
    public partial class UniqueNameParameters : IEquatable<UniqueNameParameters>
    { 
        /// <summary>
        /// Name to check for uniqueness
        /// </summary>
        /// <value>Name to check for uniqueness</value>
        [Required]

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Id of existing entity to exclude from check (for updates)
        /// </summary>
        /// <value>Id of existing entity to exclude from check (for updates)</value>

        [DataMember(Name="ExcludeId")]
        public int? ExcludeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UniqueNameParameters {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExcludeId: ").Append(ExcludeId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UniqueNameParameters)obj);
        }

        /// <summary>
        /// Returns true if UniqueNameParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UniqueNameParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniqueNameParameters other)
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
                    ExcludeId == other.ExcludeId ||
                    ExcludeId != null &&
                    ExcludeId.Equals(other.ExcludeId)
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
                    if (ExcludeId != null)
                    hashCode = hashCode * 59 + ExcludeId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UniqueNameParameters left, UniqueNameParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UniqueNameParameters left, UniqueNameParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
