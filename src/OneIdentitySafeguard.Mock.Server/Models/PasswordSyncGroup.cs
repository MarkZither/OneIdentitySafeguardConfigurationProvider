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
    /// Represents a group of accounts in a profile whose passwords must be the same. All accounts will be updated in priority order  when a password change is requested.
    /// </summary>
    [DataContract]
    public partial class PasswordSyncGroup : IEquatable<PasswordSyncGroup>
    { 
        /// <summary>
        /// Unique ID of the sync group (Read-Only)
        /// </summary>
        /// <value>Unique ID of the sync group (Read-Only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the sync group
        /// </summary>
        /// <value>Name of the sync group</value>
        [Required]

        [MaxLength(100)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the sync group
        /// </summary>
        /// <value>Description of the sync group</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique ID of the profile this sync group belongs to
        /// </summary>
        /// <value>Unique ID of the profile this sync group belongs to</value>

        [DataMember(Name="ProfileId")]
        public int? ProfileId { get; set; }

        /// <summary>
        /// Name of the profile this sync group belongs to
        /// </summary>
        /// <value>Name of the profile this sync group belongs to</value>

        [DataMember(Name="ProfileName")]
        public string ProfileName { get; set; }

        /// <summary>
        /// Whether platform tasks can run against this sync group
        /// </summary>
        /// <value>Whether platform tasks can run against this sync group</value>

        [DataMember(Name="Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Unique ID of the asset partition this sync group belongs to
        /// </summary>
        /// <value>Unique ID of the asset partition this sync group belongs to</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the partition this sync group belongs to
        /// </summary>
        /// <value>Name of the partition this sync group belongs to</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Date this entity was created (Read-only)
        /// </summary>
        /// <value>Date this entity was created (Read-only)</value>

        [DataMember(Name="CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The database ID of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserId")]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserDisplayName")]
        public string CreatedByUserDisplayName { get; set; }

        /// <summary>
        /// The date/time of the last password change (Read-only)
        /// </summary>
        /// <value>The date/time of the last password change (Read-only)</value>

        [DataMember(Name="LastSyncAccountsDate")]
        public DateTime? LastSyncAccountsDate { get; set; }

        /// <summary>
        /// The date/time of the last successful password change (Read-only)
        /// </summary>
        /// <value>The date/time of the last successful password change (Read-only)</value>

        [DataMember(Name="LastSuccessSyncAccountsDate")]
        public DateTime? LastSuccessSyncAccountsDate { get; set; }

        /// <summary>
        /// The date/time of the last failed password change (Read-only)
        /// </summary>
        /// <value>The date/time of the last failed password change (Read-only)</value>

        [DataMember(Name="LastFailureSyncAccountsDate")]
        public DateTime? LastFailureSyncAccountsDate { get; set; }

        /// <summary>
        /// The task audit log ID of the last password change (Read-only)
        /// </summary>
        /// <value>The task audit log ID of the last password change (Read-only)</value>

        [DataMember(Name="LastSyncAccountsTaskId")]
        public string LastSyncAccountsTaskId { get; set; }

        /// <summary>
        /// Number of subsequent failed password change attempts since last success (Read-only)
        /// </summary>
        /// <value>Number of subsequent failed password change attempts since last success (Read-only)</value>

        [DataMember(Name="FailedSyncAccountsAttempts")]
        public int? FailedSyncAccountsAttempts { get; set; }

        /// <summary>
        /// The date/time of the next password change, if this account is enabled for automatic password management (Read-only)
        /// </summary>
        /// <value>The date/time of the next password change, if this account is enabled for automatic password management (Read-only)</value>

        [DataMember(Name="NextSyncAccountsDate")]
        public DateTime? NextSyncAccountsDate { get; set; }

        /// <summary>
        /// Whether all of the accounts for this sync group are currently synchronized
        /// </summary>
        /// <value>Whether all of the accounts for this sync group are currently synchronized</value>

        [DataMember(Name="IsSynchronized")]
        public bool? IsSynchronized { get; set; }

        /// <summary>
        /// Set of accounts that are assigned to this sync group
        /// </summary>
        /// <value>Set of accounts that are assigned to this sync group</value>

        [DataMember(Name="Accounts")]
        public List<SyncGroupAccount> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordSyncGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
            sb.Append("  LastSyncAccountsDate: ").Append(LastSyncAccountsDate).Append("\n");
            sb.Append("  LastSuccessSyncAccountsDate: ").Append(LastSuccessSyncAccountsDate).Append("\n");
            sb.Append("  LastFailureSyncAccountsDate: ").Append(LastFailureSyncAccountsDate).Append("\n");
            sb.Append("  LastSyncAccountsTaskId: ").Append(LastSyncAccountsTaskId).Append("\n");
            sb.Append("  FailedSyncAccountsAttempts: ").Append(FailedSyncAccountsAttempts).Append("\n");
            sb.Append("  NextSyncAccountsDate: ").Append(NextSyncAccountsDate).Append("\n");
            sb.Append("  IsSynchronized: ").Append(IsSynchronized).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PasswordSyncGroup)obj);
        }

        /// <summary>
        /// Returns true if PasswordSyncGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of PasswordSyncGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordSyncGroup other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ProfileId == other.ProfileId ||
                    ProfileId != null &&
                    ProfileId.Equals(other.ProfileId)
                ) && 
                (
                    ProfileName == other.ProfileName ||
                    ProfileName != null &&
                    ProfileName.Equals(other.ProfileName)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
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
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedByUserId == other.CreatedByUserId ||
                    CreatedByUserId != null &&
                    CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    CreatedByUserDisplayName == other.CreatedByUserDisplayName ||
                    CreatedByUserDisplayName != null &&
                    CreatedByUserDisplayName.Equals(other.CreatedByUserDisplayName)
                ) && 
                (
                    LastSyncAccountsDate == other.LastSyncAccountsDate ||
                    LastSyncAccountsDate != null &&
                    LastSyncAccountsDate.Equals(other.LastSyncAccountsDate)
                ) && 
                (
                    LastSuccessSyncAccountsDate == other.LastSuccessSyncAccountsDate ||
                    LastSuccessSyncAccountsDate != null &&
                    LastSuccessSyncAccountsDate.Equals(other.LastSuccessSyncAccountsDate)
                ) && 
                (
                    LastFailureSyncAccountsDate == other.LastFailureSyncAccountsDate ||
                    LastFailureSyncAccountsDate != null &&
                    LastFailureSyncAccountsDate.Equals(other.LastFailureSyncAccountsDate)
                ) && 
                (
                    LastSyncAccountsTaskId == other.LastSyncAccountsTaskId ||
                    LastSyncAccountsTaskId != null &&
                    LastSyncAccountsTaskId.Equals(other.LastSyncAccountsTaskId)
                ) && 
                (
                    FailedSyncAccountsAttempts == other.FailedSyncAccountsAttempts ||
                    FailedSyncAccountsAttempts != null &&
                    FailedSyncAccountsAttempts.Equals(other.FailedSyncAccountsAttempts)
                ) && 
                (
                    NextSyncAccountsDate == other.NextSyncAccountsDate ||
                    NextSyncAccountsDate != null &&
                    NextSyncAccountsDate.Equals(other.NextSyncAccountsDate)
                ) && 
                (
                    IsSynchronized == other.IsSynchronized ||
                    IsSynchronized != null &&
                    IsSynchronized.Equals(other.IsSynchronized)
                ) && 
                (
                    Accounts == other.Accounts ||
                    Accounts != null &&
                    Accounts.SequenceEqual(other.Accounts)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ProfileId != null)
                    hashCode = hashCode * 59 + ProfileId.GetHashCode();
                    if (ProfileName != null)
                    hashCode = hashCode * 59 + ProfileName.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                    if (LastSyncAccountsDate != null)
                    hashCode = hashCode * 59 + LastSyncAccountsDate.GetHashCode();
                    if (LastSuccessSyncAccountsDate != null)
                    hashCode = hashCode * 59 + LastSuccessSyncAccountsDate.GetHashCode();
                    if (LastFailureSyncAccountsDate != null)
                    hashCode = hashCode * 59 + LastFailureSyncAccountsDate.GetHashCode();
                    if (LastSyncAccountsTaskId != null)
                    hashCode = hashCode * 59 + LastSyncAccountsTaskId.GetHashCode();
                    if (FailedSyncAccountsAttempts != null)
                    hashCode = hashCode * 59 + FailedSyncAccountsAttempts.GetHashCode();
                    if (NextSyncAccountsDate != null)
                    hashCode = hashCode * 59 + NextSyncAccountsDate.GetHashCode();
                    if (IsSynchronized != null)
                    hashCode = hashCode * 59 + IsSynchronized.GetHashCode();
                    if (Accounts != null)
                    hashCode = hashCode * 59 + Accounts.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PasswordSyncGroup left, PasswordSyncGroup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PasswordSyncGroup left, PasswordSyncGroup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}