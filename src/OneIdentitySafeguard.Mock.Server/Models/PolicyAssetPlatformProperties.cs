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
    /// Platform properties for policy asset
    /// </summary>
    [DataContract]
    public partial class PolicyAssetPlatformProperties : IEquatable<PolicyAssetPlatformProperties>
    { 
        /// <summary>
        /// The database ID of the type of platform (Read-only)
        /// </summary>
        /// <value>The database ID of the type of platform (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets PlatformType
        /// </summary>

        [DataMember(Name="PlatformType")]
        public PlatformType PlatformType { get; set; }

        /// <summary>
        /// The display name of the type of platform (Read-only)
        /// </summary>
        /// <value>The display name of the type of platform (Read-only)</value>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Whether this asset supports session access
        /// </summary>
        /// <value>Whether this asset supports session access</value>

        [DataMember(Name="SupportsSessionManagement")]
        public bool? SupportsSessionManagement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAssetPlatformProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SupportsSessionManagement: ").Append(SupportsSessionManagement).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PolicyAssetPlatformProperties)obj);
        }

        /// <summary>
        /// Returns true if PolicyAssetPlatformProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyAssetPlatformProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyAssetPlatformProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    PlatformType == other.PlatformType ||
                    PlatformType != null &&
                    PlatformType.Equals(other.PlatformType)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    SupportsSessionManagement == other.SupportsSessionManagement ||
                    SupportsSessionManagement != null &&
                    SupportsSessionManagement.Equals(other.SupportsSessionManagement)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (PlatformType != null)
                    hashCode = hashCode * 59 + PlatformType.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (SupportsSessionManagement != null)
                    hashCode = hashCode * 59 + SupportsSessionManagement.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PolicyAssetPlatformProperties left, PolicyAssetPlatformProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PolicyAssetPlatformProperties left, PolicyAssetPlatformProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
