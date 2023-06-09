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
    public partial class DiscoveredAssetAccount : IEquatable<DiscoveredAssetAccount>
    { 
        /// <summary>
        /// Name of the discovered account
        /// </summary>
        /// <value>Name of the discovered account</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name="Status")]
        public DiscoveredAccountStatus Status { get; set; }

        /// <summary>
        /// The User ID discovered on the target system
        /// </summary>
        /// <value>The User ID discovered on the target system</value>

        [DataMember(Name="DiscoveredUserId")]
        public string DiscoveredUserId { get; set; }

        /// <summary>
        /// The date the account was discovered
        /// </summary>
        /// <value>The date the account was discovered</value>

        [DataMember(Name="DiscoveredDate")]
        public DateTime? DiscoveredDate { get; set; }

        /// <summary>
        /// Name of the asset on which this account was discovered
        /// </summary>
        /// <value>Name of the asset on which this account was discovered</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Database ID of the asset on which this account was discovered
        /// </summary>
        /// <value>Database ID of the asset on which this account was discovered</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Database identifier for the asset partition on which this account was discovered
        /// </summary>
        /// <value>Database identifier for the asset partition on which this account was discovered</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition on which this account was discovered
        /// </summary>
        /// <value>Name of the asset partition on which this account was discovered</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Database Id of the account discovery schedule used to discover the account
        /// </summary>
        /// <value>Database Id of the account discovery schedule used to discover the account</value>

        [DataMember(Name="AccountDiscoveryScheduleId")]
        public int? AccountDiscoveryScheduleId { get; set; }

        /// <summary>
        /// Name of account discovery schedule used to discover the account
        /// </summary>
        /// <value>Name of account discovery schedule used to discover the account</value>

        [DataMember(Name="AccountDiscoveryScheduleName")]
        public string AccountDiscoveryScheduleName { get; set; }

        /// <summary>
        /// Domain name where the account was discovered
        /// </summary>
        /// <value>Domain name where the account was discovered</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// The rule that discovered this account
        /// </summary>
        /// <value>The rule that discovered this account</value>

        [DataMember(Name="RuleName")]
        public string RuleName { get; set; }

        /// <summary>
        /// The groups on the target system the user is a member of
        /// </summary>
        /// <value>The groups on the target system the user is a member of</value>

        [DataMember(Name="DiscoveredGroups")]
        public List<DiscoveredGroup> DiscoveredGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveredAssetAccount {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
            sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
            sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  DiscoveredGroups: ").Append(DiscoveredGroups).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DiscoveredAssetAccount)obj);
        }

        /// <summary>
        /// Returns true if DiscoveredAssetAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscoveredAssetAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveredAssetAccount other)
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
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    DiscoveredUserId == other.DiscoveredUserId ||
                    DiscoveredUserId != null &&
                    DiscoveredUserId.Equals(other.DiscoveredUserId)
                ) && 
                (
                    DiscoveredDate == other.DiscoveredDate ||
                    DiscoveredDate != null &&
                    DiscoveredDate.Equals(other.DiscoveredDate)
                ) && 
                (
                    AssetName == other.AssetName ||
                    AssetName != null &&
                    AssetName.Equals(other.AssetName)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
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
                    AccountDiscoveryScheduleId == other.AccountDiscoveryScheduleId ||
                    AccountDiscoveryScheduleId != null &&
                    AccountDiscoveryScheduleId.Equals(other.AccountDiscoveryScheduleId)
                ) && 
                (
                    AccountDiscoveryScheduleName == other.AccountDiscoveryScheduleName ||
                    AccountDiscoveryScheduleName != null &&
                    AccountDiscoveryScheduleName.Equals(other.AccountDiscoveryScheduleName)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    RuleName == other.RuleName ||
                    RuleName != null &&
                    RuleName.Equals(other.RuleName)
                ) && 
                (
                    DiscoveredGroups == other.DiscoveredGroups ||
                    DiscoveredGroups != null &&
                    DiscoveredGroups.SequenceEqual(other.DiscoveredGroups)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (DiscoveredUserId != null)
                    hashCode = hashCode * 59 + DiscoveredUserId.GetHashCode();
                    if (DiscoveredDate != null)
                    hashCode = hashCode * 59 + DiscoveredDate.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (AccountDiscoveryScheduleId != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleId.GetHashCode();
                    if (AccountDiscoveryScheduleName != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleName.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (RuleName != null)
                    hashCode = hashCode * 59 + RuleName.GetHashCode();
                    if (DiscoveredGroups != null)
                    hashCode = hashCode * 59 + DiscoveredGroups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DiscoveredAssetAccount left, DiscoveredAssetAccount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiscoveredAssetAccount left, DiscoveredAssetAccount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
