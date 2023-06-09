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
    /// Properties mapping the entity to an object in a directory
    /// </summary>
    [DataContract]
    public partial class DirectoryAssetProperties : IEquatable<DirectoryAssetProperties>
    { 
        /// <summary>
        /// The name of the forest root domain (Read-only)
        /// </summary>
        /// <value>The name of the forest root domain (Read-only)</value>

        [DataMember(Name="ForestRootDomain")]
        public string ForestRootDomain { get; set; }

        /// <summary>
        /// Restrict this asset to a specific domain. This cannot be modified to exclude managed accounts from this asset. Only applicable to Active Directory.
        /// </summary>
        /// <value>Restrict this asset to a specific domain. This cannot be modified to exclude managed accounts from this asset. Only applicable to Active Directory.</value>

        [StringLength(255, MinimumLength=1)]
        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this directory asset is visible to and can be used for searches by any partition owner. Can be used in asset discovery.
        /// </summary>
        /// <value>Whether this directory asset is visible to and can be used for searches by any partition owner. Can be used in asset discovery.</value>

        [DataMember(Name="AllowSharedSearch")]
        public bool? AllowSharedSearch { get; set; }

        /// <summary>
        /// Whether this directory asset manages password hashing itself.
        /// </summary>
        /// <value>Whether this directory asset manages password hashing itself.</value>

        [DataMember(Name="UsePasswordHash")]
        public bool? UsePasswordHash { get; set; }

        /// <summary>
        /// How frequently data imported from this directory should be synchronized with changes made in AD (in minutes)
        /// </summary>
        /// <value>How frequently data imported from this directory should be synchronized with changes made in AD (in minutes)</value>

        [Range(1, 2147483647)]
        [DataMember(Name="SynchronizationIntervalMinutes")]
        public int? SynchronizationIntervalMinutes { get; set; }

        /// <summary>
        /// How frequently this directory should be checked for deleted objects in AD (in minutes)
        /// </summary>
        /// <value>How frequently this directory should be checked for deleted objects in AD (in minutes)</value>

        [Range(1, 2147483647)]
        [DataMember(Name="DeleteSyncIntervalMinutes")]
        public int? DeleteSyncIntervalMinutes { get; set; }

        /// <summary>
        /// List of available domains that can be searched from this directory. This will be discovered using connection properties (Read-only)
        /// </summary>
        /// <value>List of available domains that can be searched from this directory. This will be discovered using connection properties (Read-only)</value>

        [DataMember(Name="Domains")]
        public List<AssetDomainInfo> Domains { get; set; }

        /// <summary>
        /// List of available domain controllers. If this list is empty then DNS will be used instead.
        /// </summary>
        /// <value>List of available domain controllers. If this list is empty then DNS will be used instead.</value>

        [DataMember(Name="DomainControllers")]
        public List<DomainController> DomainControllers { get; set; }

        /// <summary>
        /// The time this directory was last synchronized and account discovery was ran (Read-only)
        /// </summary>
        /// <value>The time this directory was last synchronized and account discovery was ran (Read-only)</value>

        [DataMember(Name="LastSynchronizedDate")]
        public DateTime? LastSynchronizedDate { get; set; }

        /// <summary>
        /// The time this directory last successfully synchronized (Read-only)
        /// </summary>
        /// <value>The time this directory last successfully synchronized (Read-only)</value>

        [DataMember(Name="LastSuccessSynchronizedDate")]
        public DateTime? LastSuccessSynchronizedDate { get; set; }

        /// <summary>
        /// The time this directory last failed to synchronize (Read-only)
        /// </summary>
        /// <value>The time this directory last failed to synchronize (Read-only)</value>

        [DataMember(Name="LastFailureSynchronizedDate")]
        public DateTime? LastFailureSynchronizedDate { get; set; }

        /// <summary>
        /// Number of subsequent failed sync attempts since last success (Read-only)
        /// </summary>
        /// <value>Number of subsequent failed sync attempts since last success (Read-only)</value>

        [DataMember(Name="FailedSyncAttempts")]
        public int? FailedSyncAttempts { get; set; }

        /// <summary>
        /// The task audit log ID of the last directory sync (Read-only)
        /// </summary>
        /// <value>The task audit log ID of the last directory sync (Read-only)</value>

        [DataMember(Name="LastDirectorySyncTaskId")]
        public string LastDirectorySyncTaskId { get; set; }

        /// <summary>
        /// The next time this directory will synchronize and run account discovery (Read-only)
        /// </summary>
        /// <value>The next time this directory will synchronize and run account discovery (Read-only)</value>

        [DataMember(Name="NextSynchronizedDate")]
        public DateTime? NextSynchronizedDate { get; set; }

        /// <summary>
        /// The last time the directory was last checked for deleted objects (Read-only)
        /// </summary>
        /// <value>The last time the directory was last checked for deleted objects (Read-only)</value>

        [DataMember(Name="LastDeleteSyncDate")]
        public DateTime? LastDeleteSyncDate { get; set; }

        /// <summary>
        /// The time this directory last successfully synchronized deletions (Read-only)
        /// </summary>
        /// <value>The time this directory last successfully synchronized deletions (Read-only)</value>

        [DataMember(Name="LastSuccessDeleteSyncDate")]
        public DateTime? LastSuccessDeleteSyncDate { get; set; }

        /// <summary>
        /// The time this directory last failed to synchronize deletions (Read-only)
        /// </summary>
        /// <value>The time this directory last failed to synchronize deletions (Read-only)</value>

        [DataMember(Name="LastFailureDeleteSyncDate")]
        public DateTime? LastFailureDeleteSyncDate { get; set; }

        /// <summary>
        /// Number of subsequent failed delete sync attempts since last success (Read-only)
        /// </summary>
        /// <value>Number of subsequent failed delete sync attempts since last success (Read-only)</value>

        [DataMember(Name="FailedDeleteSyncAttempts")]
        public int? FailedDeleteSyncAttempts { get; set; }

        /// <summary>
        /// The task audit log ID of the last delete directory sync (Read-only)
        /// </summary>
        /// <value>The task audit log ID of the last delete directory sync (Read-only)</value>

        [DataMember(Name="LastDirectoryDeleteSyncTaskId")]
        public string LastDirectoryDeleteSyncTaskId { get; set; }

        /// <summary>
        /// The time this directory will synchronize deletions (Read-only)
        /// </summary>
        /// <value>The time this directory will synchronize deletions (Read-only)</value>

        [DataMember(Name="NextDeleteSyncDate")]
        public DateTime? NextDeleteSyncDate { get; set; }

        /// <summary>
        /// Gets or Sets SchemaProperties
        /// </summary>

        [DataMember(Name="SchemaProperties")]
        public AssetLdapSchema SchemaProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectoryAssetProperties {\n");
            sb.Append("  ForestRootDomain: ").Append(ForestRootDomain).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  AllowSharedSearch: ").Append(AllowSharedSearch).Append("\n");
            sb.Append("  UsePasswordHash: ").Append(UsePasswordHash).Append("\n");
            sb.Append("  SynchronizationIntervalMinutes: ").Append(SynchronizationIntervalMinutes).Append("\n");
            sb.Append("  DeleteSyncIntervalMinutes: ").Append(DeleteSyncIntervalMinutes).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  DomainControllers: ").Append(DomainControllers).Append("\n");
            sb.Append("  LastSynchronizedDate: ").Append(LastSynchronizedDate).Append("\n");
            sb.Append("  LastSuccessSynchronizedDate: ").Append(LastSuccessSynchronizedDate).Append("\n");
            sb.Append("  LastFailureSynchronizedDate: ").Append(LastFailureSynchronizedDate).Append("\n");
            sb.Append("  FailedSyncAttempts: ").Append(FailedSyncAttempts).Append("\n");
            sb.Append("  LastDirectorySyncTaskId: ").Append(LastDirectorySyncTaskId).Append("\n");
            sb.Append("  NextSynchronizedDate: ").Append(NextSynchronizedDate).Append("\n");
            sb.Append("  LastDeleteSyncDate: ").Append(LastDeleteSyncDate).Append("\n");
            sb.Append("  LastSuccessDeleteSyncDate: ").Append(LastSuccessDeleteSyncDate).Append("\n");
            sb.Append("  LastFailureDeleteSyncDate: ").Append(LastFailureDeleteSyncDate).Append("\n");
            sb.Append("  FailedDeleteSyncAttempts: ").Append(FailedDeleteSyncAttempts).Append("\n");
            sb.Append("  LastDirectoryDeleteSyncTaskId: ").Append(LastDirectoryDeleteSyncTaskId).Append("\n");
            sb.Append("  NextDeleteSyncDate: ").Append(NextDeleteSyncDate).Append("\n");
            sb.Append("  SchemaProperties: ").Append(SchemaProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DirectoryAssetProperties)obj);
        }

        /// <summary>
        /// Returns true if DirectoryAssetProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DirectoryAssetProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectoryAssetProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ForestRootDomain == other.ForestRootDomain ||
                    ForestRootDomain != null &&
                    ForestRootDomain.Equals(other.ForestRootDomain)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    AllowSharedSearch == other.AllowSharedSearch ||
                    AllowSharedSearch != null &&
                    AllowSharedSearch.Equals(other.AllowSharedSearch)
                ) && 
                (
                    UsePasswordHash == other.UsePasswordHash ||
                    UsePasswordHash != null &&
                    UsePasswordHash.Equals(other.UsePasswordHash)
                ) && 
                (
                    SynchronizationIntervalMinutes == other.SynchronizationIntervalMinutes ||
                    SynchronizationIntervalMinutes != null &&
                    SynchronizationIntervalMinutes.Equals(other.SynchronizationIntervalMinutes)
                ) && 
                (
                    DeleteSyncIntervalMinutes == other.DeleteSyncIntervalMinutes ||
                    DeleteSyncIntervalMinutes != null &&
                    DeleteSyncIntervalMinutes.Equals(other.DeleteSyncIntervalMinutes)
                ) && 
                (
                    Domains == other.Domains ||
                    Domains != null &&
                    Domains.SequenceEqual(other.Domains)
                ) && 
                (
                    DomainControllers == other.DomainControllers ||
                    DomainControllers != null &&
                    DomainControllers.SequenceEqual(other.DomainControllers)
                ) && 
                (
                    LastSynchronizedDate == other.LastSynchronizedDate ||
                    LastSynchronizedDate != null &&
                    LastSynchronizedDate.Equals(other.LastSynchronizedDate)
                ) && 
                (
                    LastSuccessSynchronizedDate == other.LastSuccessSynchronizedDate ||
                    LastSuccessSynchronizedDate != null &&
                    LastSuccessSynchronizedDate.Equals(other.LastSuccessSynchronizedDate)
                ) && 
                (
                    LastFailureSynchronizedDate == other.LastFailureSynchronizedDate ||
                    LastFailureSynchronizedDate != null &&
                    LastFailureSynchronizedDate.Equals(other.LastFailureSynchronizedDate)
                ) && 
                (
                    FailedSyncAttempts == other.FailedSyncAttempts ||
                    FailedSyncAttempts != null &&
                    FailedSyncAttempts.Equals(other.FailedSyncAttempts)
                ) && 
                (
                    LastDirectorySyncTaskId == other.LastDirectorySyncTaskId ||
                    LastDirectorySyncTaskId != null &&
                    LastDirectorySyncTaskId.Equals(other.LastDirectorySyncTaskId)
                ) && 
                (
                    NextSynchronizedDate == other.NextSynchronizedDate ||
                    NextSynchronizedDate != null &&
                    NextSynchronizedDate.Equals(other.NextSynchronizedDate)
                ) && 
                (
                    LastDeleteSyncDate == other.LastDeleteSyncDate ||
                    LastDeleteSyncDate != null &&
                    LastDeleteSyncDate.Equals(other.LastDeleteSyncDate)
                ) && 
                (
                    LastSuccessDeleteSyncDate == other.LastSuccessDeleteSyncDate ||
                    LastSuccessDeleteSyncDate != null &&
                    LastSuccessDeleteSyncDate.Equals(other.LastSuccessDeleteSyncDate)
                ) && 
                (
                    LastFailureDeleteSyncDate == other.LastFailureDeleteSyncDate ||
                    LastFailureDeleteSyncDate != null &&
                    LastFailureDeleteSyncDate.Equals(other.LastFailureDeleteSyncDate)
                ) && 
                (
                    FailedDeleteSyncAttempts == other.FailedDeleteSyncAttempts ||
                    FailedDeleteSyncAttempts != null &&
                    FailedDeleteSyncAttempts.Equals(other.FailedDeleteSyncAttempts)
                ) && 
                (
                    LastDirectoryDeleteSyncTaskId == other.LastDirectoryDeleteSyncTaskId ||
                    LastDirectoryDeleteSyncTaskId != null &&
                    LastDirectoryDeleteSyncTaskId.Equals(other.LastDirectoryDeleteSyncTaskId)
                ) && 
                (
                    NextDeleteSyncDate == other.NextDeleteSyncDate ||
                    NextDeleteSyncDate != null &&
                    NextDeleteSyncDate.Equals(other.NextDeleteSyncDate)
                ) && 
                (
                    SchemaProperties == other.SchemaProperties ||
                    SchemaProperties != null &&
                    SchemaProperties.Equals(other.SchemaProperties)
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
                    if (ForestRootDomain != null)
                    hashCode = hashCode * 59 + ForestRootDomain.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (AllowSharedSearch != null)
                    hashCode = hashCode * 59 + AllowSharedSearch.GetHashCode();
                    if (UsePasswordHash != null)
                    hashCode = hashCode * 59 + UsePasswordHash.GetHashCode();
                    if (SynchronizationIntervalMinutes != null)
                    hashCode = hashCode * 59 + SynchronizationIntervalMinutes.GetHashCode();
                    if (DeleteSyncIntervalMinutes != null)
                    hashCode = hashCode * 59 + DeleteSyncIntervalMinutes.GetHashCode();
                    if (Domains != null)
                    hashCode = hashCode * 59 + Domains.GetHashCode();
                    if (DomainControllers != null)
                    hashCode = hashCode * 59 + DomainControllers.GetHashCode();
                    if (LastSynchronizedDate != null)
                    hashCode = hashCode * 59 + LastSynchronizedDate.GetHashCode();
                    if (LastSuccessSynchronizedDate != null)
                    hashCode = hashCode * 59 + LastSuccessSynchronizedDate.GetHashCode();
                    if (LastFailureSynchronizedDate != null)
                    hashCode = hashCode * 59 + LastFailureSynchronizedDate.GetHashCode();
                    if (FailedSyncAttempts != null)
                    hashCode = hashCode * 59 + FailedSyncAttempts.GetHashCode();
                    if (LastDirectorySyncTaskId != null)
                    hashCode = hashCode * 59 + LastDirectorySyncTaskId.GetHashCode();
                    if (NextSynchronizedDate != null)
                    hashCode = hashCode * 59 + NextSynchronizedDate.GetHashCode();
                    if (LastDeleteSyncDate != null)
                    hashCode = hashCode * 59 + LastDeleteSyncDate.GetHashCode();
                    if (LastSuccessDeleteSyncDate != null)
                    hashCode = hashCode * 59 + LastSuccessDeleteSyncDate.GetHashCode();
                    if (LastFailureDeleteSyncDate != null)
                    hashCode = hashCode * 59 + LastFailureDeleteSyncDate.GetHashCode();
                    if (FailedDeleteSyncAttempts != null)
                    hashCode = hashCode * 59 + FailedDeleteSyncAttempts.GetHashCode();
                    if (LastDirectoryDeleteSyncTaskId != null)
                    hashCode = hashCode * 59 + LastDirectoryDeleteSyncTaskId.GetHashCode();
                    if (NextDeleteSyncDate != null)
                    hashCode = hashCode * 59 + NextDeleteSyncDate.GetHashCode();
                    if (SchemaProperties != null)
                    hashCode = hashCode * 59 + SchemaProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DirectoryAssetProperties left, DirectoryAssetProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DirectoryAssetProperties left, DirectoryAssetProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
