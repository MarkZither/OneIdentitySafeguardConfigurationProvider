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
    /// Represents an remote asset available for request. A PolicyAsset is an   alternate view of an asset that is used for AccessPolicies, AssetGroups,  and UserFavorites. The asset must have a password and have AllowSessionRequests set to true  in order to be used in UserFavorites or to be able to request a session on the asset.
    /// </summary>
    [DataContract]
    public partial class PolicyAsset : IEquatable<PolicyAsset>
    { 
        /// <summary>
        /// A short description of the asset. (Read-only)
        /// </summary>
        /// <value>A short description of the asset. (Read-only)</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// The database key of the asset (Read-only)
        /// </summary>
        /// <value>The database key of the asset (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the asset (Read-only)
        /// </summary>
        /// <value>The name of the asset (Read-only)</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>

        [DataMember(Name="AssetType")]
        public AssetType AssetType { get; set; }

        /// <summary>
        /// The network address of the asset (Read-only)
        /// </summary>
        /// <value>The network address of the asset (Read-only)</value>

        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Database ID of partition asset belongs to
        /// </summary>
        /// <value>Database ID of partition asset belongs to</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of partition asset belongs to
        /// </summary>
        /// <value>Name of partition asset belongs to</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// The domain name that the asset belongs to. (Read-only)
        /// </summary>
        /// <value>The domain name that the asset belongs to. (Read-only)</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this asset has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
        /// </summary>
        /// <value>Whether this asset has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>

        [DataMember(Name="Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>

        [DataMember(Name="Platform")]
        public PolicyAssetPlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or Sets SshHostKey
        /// </summary>

        [DataMember(Name="SshHostKey")]
        public AssetSshHostKey SshHostKey { get; set; }

        /// <summary>
        /// Gets or Sets SessionAccessProperties
        /// </summary>

        [DataMember(Name="SessionAccessProperties")]
        public AssetSessionAccessProperties SessionAccessProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAsset {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
            sb.Append("  SessionAccessProperties: ").Append(SessionAccessProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PolicyAsset)obj);
        }

        /// <summary>
        /// Returns true if PolicyAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyAsset other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
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
                    AssetType == other.AssetType ||
                    AssetType != null &&
                    AssetType.Equals(other.AssetType)
                ) && 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    AssetPartitionId == other.AssetPartitionId ||
                    AssetPartitionId != null &&
                    AssetPartitionId.Equals(other.AssetPartitionId)
                ) && 
                (
                    AssetPartitionName == other.AssetPartitionName ||
                    AssetPartitionName != null &&
                    AssetPartitionName.Equals(other.AssetPartitionName)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
                ) && 
                (
                    Platform == other.Platform ||
                    Platform != null &&
                    Platform.Equals(other.Platform)
                ) && 
                (
                    SshHostKey == other.SshHostKey ||
                    SshHostKey != null &&
                    SshHostKey.Equals(other.SshHostKey)
                ) && 
                (
                    SessionAccessProperties == other.SessionAccessProperties ||
                    SessionAccessProperties != null &&
                    SessionAccessProperties.Equals(other.SessionAccessProperties)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AssetType != null)
                    hashCode = hashCode * 59 + AssetType.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (Platform != null)
                    hashCode = hashCode * 59 + Platform.GetHashCode();
                    if (SshHostKey != null)
                    hashCode = hashCode * 59 + SshHostKey.GetHashCode();
                    if (SessionAccessProperties != null)
                    hashCode = hashCode * 59 + SessionAccessProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PolicyAsset left, PolicyAsset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PolicyAsset left, PolicyAsset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
