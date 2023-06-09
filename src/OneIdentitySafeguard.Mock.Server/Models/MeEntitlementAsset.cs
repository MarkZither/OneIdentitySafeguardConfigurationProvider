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
    /// 
    /// </summary>
    [DataContract]
    public partial class MeEntitlementAsset : IEquatable<MeEntitlementAsset>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DomainName
        /// </summary>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAddress
        /// </summary>

        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Gets or Sets PlatformDisplayName
        /// </summary>

        [DataMember(Name="PlatformDisplayName")]
        public string PlatformDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets PlatformType
        /// </summary>

        [DataMember(Name="PlatformType")]
        public PlatformType PlatformType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeEntitlementAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeEntitlementAsset)obj);
        }

        /// <summary>
        /// Returns true if MeEntitlementAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of MeEntitlementAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeEntitlementAsset other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    PlatformDisplayName == other.PlatformDisplayName ||
                    PlatformDisplayName != null &&
                    PlatformDisplayName.Equals(other.PlatformDisplayName)
                ) && 
                (
                    PlatformType == other.PlatformType ||
                    PlatformType != null &&
                    PlatformType.Equals(other.PlatformType)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (PlatformDisplayName != null)
                    hashCode = hashCode * 59 + PlatformDisplayName.GetHashCode();
                    if (PlatformType != null)
                    hashCode = hashCode * 59 + PlatformType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeEntitlementAsset left, MeEntitlementAsset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeEntitlementAsset left, MeEntitlementAsset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
