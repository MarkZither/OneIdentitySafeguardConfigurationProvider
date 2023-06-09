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
    public partial class MeEntitlementAccount : IEquatable<MeEntitlementAccount>
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
        /// Gets or Sets HasPassword
        /// </summary>

        [DataMember(Name="HasPassword")]
        public bool? HasPassword { get; set; }

        /// <summary>
        /// Gets or Sets HasSshKey
        /// </summary>

        [DataMember(Name="HasSshKey")]
        public bool? HasSshKey { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>

        [DataMember(Name="Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Gets or Sets AssetName
        /// </summary>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Gets or Sets AssetNetworkAddress
        /// </summary>

        [DataMember(Name="AssetNetworkAddress")]
        public string AssetNetworkAddress { get; set; }

        /// <summary>
        /// Gets or Sets AllowPasswordRequest
        /// </summary>

        [DataMember(Name="AllowPasswordRequest")]
        public bool? AllowPasswordRequest { get; set; }

        /// <summary>
        /// Gets or Sets AllowSessionRequest
        /// </summary>

        [DataMember(Name="AllowSessionRequest")]
        public bool? AllowSessionRequest { get; set; }

        /// <summary>
        /// Gets or Sets AllowSshKeyRequest
        /// </summary>

        [DataMember(Name="AllowSshKeyRequest")]
        public bool? AllowSshKeyRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeEntitlementAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
            sb.Append("  HasSshKey: ").Append(HasSshKey).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
            sb.Append("  AllowPasswordRequest: ").Append(AllowPasswordRequest).Append("\n");
            sb.Append("  AllowSessionRequest: ").Append(AllowSessionRequest).Append("\n");
            sb.Append("  AllowSshKeyRequest: ").Append(AllowSshKeyRequest).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeEntitlementAccount)obj);
        }

        /// <summary>
        /// Returns true if MeEntitlementAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of MeEntitlementAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeEntitlementAccount other)
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
                    HasPassword == other.HasPassword ||
                    HasPassword != null &&
                    HasPassword.Equals(other.HasPassword)
                ) && 
                (
                    HasSshKey == other.HasSshKey ||
                    HasSshKey != null &&
                    HasSshKey.Equals(other.HasSshKey)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    AssetName == other.AssetName ||
                    AssetName != null &&
                    AssetName.Equals(other.AssetName)
                ) && 
                (
                    AssetNetworkAddress == other.AssetNetworkAddress ||
                    AssetNetworkAddress != null &&
                    AssetNetworkAddress.Equals(other.AssetNetworkAddress)
                ) && 
                (
                    AllowPasswordRequest == other.AllowPasswordRequest ||
                    AllowPasswordRequest != null &&
                    AllowPasswordRequest.Equals(other.AllowPasswordRequest)
                ) && 
                (
                    AllowSessionRequest == other.AllowSessionRequest ||
                    AllowSessionRequest != null &&
                    AllowSessionRequest.Equals(other.AllowSessionRequest)
                ) && 
                (
                    AllowSshKeyRequest == other.AllowSshKeyRequest ||
                    AllowSshKeyRequest != null &&
                    AllowSshKeyRequest.Equals(other.AllowSshKeyRequest)
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
                    if (HasPassword != null)
                    hashCode = hashCode * 59 + HasPassword.GetHashCode();
                    if (HasSshKey != null)
                    hashCode = hashCode * 59 + HasSshKey.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (AssetNetworkAddress != null)
                    hashCode = hashCode * 59 + AssetNetworkAddress.GetHashCode();
                    if (AllowPasswordRequest != null)
                    hashCode = hashCode * 59 + AllowPasswordRequest.GetHashCode();
                    if (AllowSessionRequest != null)
                    hashCode = hashCode * 59 + AllowSessionRequest.GetHashCode();
                    if (AllowSshKeyRequest != null)
                    hashCode = hashCode * 59 + AllowSshKeyRequest.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeEntitlementAccount left, MeEntitlementAccount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeEntitlementAccount left, MeEntitlementAccount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
