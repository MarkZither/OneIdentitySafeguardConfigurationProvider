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
    /// Represents a task that may run on a remote machine
    /// </summary>
    [DataContract]
    public partial class PasswordActivityLog : IEquatable<PasswordActivityLog>
    { 
        /// <summary>
        /// ID of the task (Read-only)
        /// </summary>
        /// <value>ID of the task (Read-only)</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// The date the task was created
        /// </summary>
        /// <value>The date the task was created</value>

        [DataMember(Name="LogTime")]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// The database ID of the user that performed the activity
        /// </summary>
        /// <value>The database ID of the user that performed the activity</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

        /// <summary>
        /// Id of appliance
        /// </summary>
        /// <value>Id of appliance</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Name of appliance
        /// </summary>
        /// <value>Name of appliance</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        /// <value>Name of the event</value>

        [DataMember(Name="EventDisplayName")]
        public string EventDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]

        [DataMember(Name="Name")]
        public TaskNames Name { get; set; }

        /// <summary>
        /// Database ID of the asset or directory to execute this task on
        /// </summary>
        /// <value>Database ID of the asset or directory to execute this task on</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Name of the asset or directory the task was executed against (Read-only)
        /// </summary>
        /// <value>Name of the asset or directory the task was executed against (Read-only)</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// The database ID of the platform of the asset.
        /// </summary>
        /// <value>The database ID of the platform of the asset.</value>

        [DataMember(Name="PlatformId")]
        public int? PlatformId { get; set; }

        /// <summary>
        /// Gets or Sets PlatformType
        /// </summary>

        [DataMember(Name="PlatformType")]
        public PlatformType PlatformType { get; set; }

        /// <summary>
        /// Display Name of the platform of the asset (Read-only)
        /// </summary>
        /// <value>Display Name of the platform of the asset (Read-only)</value>

        [DataMember(Name="PlatformDisplayName")]
        public string PlatformDisplayName { get; set; }

        /// <summary>
        /// Network DNS name or IP address used to connect to the machine over the network.
        /// </summary>
        /// <value>Network DNS name or IP address used to connect to the machine over the network.</value>

        [MaxLength(255)]
        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Account to run this task for
        /// </summary>
        /// <value>Account to run this task for</value>

        [DataMember(Name="AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Name of the account this task is for (Read-only)
        /// </summary>
        /// <value>Name of the account this task is for (Read-only)</value>

        [DataMember(Name="AccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Domain name the account is from (Read-only)
        /// </summary>
        /// <value>Domain name the account is from (Read-only)</value>

        [DataMember(Name="AccountDomainName")]
        public string AccountDomainName { get; set; }

        /// <summary>
        /// Netbios name of the domain of the account (Read-only)
        /// </summary>
        /// <value>Netbios name of the domain of the account (Read-only)</value>

        [DataMember(Name="AccountNetBiosName")]
        public string AccountNetBiosName { get; set; }

        /// <summary>
        /// Distinguished name of the account (Read-only)
        /// </summary>
        /// <value>Distinguished name of the account (Read-only)</value>

        [DataMember(Name="AccountDistinguishedName")]
        public string AccountDistinguishedName { get; set; }

        /// <summary>
        /// Database ID of the sync group associated with this task (Read-only)
        /// </summary>
        /// <value>Database ID of the sync group associated with this task (Read-only)</value>

        [DataMember(Name="SyncGroupId")]
        public int? SyncGroupId { get; set; }

        /// <summary>
        /// Name of the sync group associated with this task (Read-only)
        /// </summary>
        /// <value>Name of the sync group associated with this task (Read-only)</value>

        [DataMember(Name="SyncGroupName")]
        public string SyncGroupName { get; set; }

        /// <summary>
        /// Database ID of the SSH key sync group associated with this task (Read-only)
        /// </summary>
        /// <value>Database ID of the SSH key sync group associated with this task (Read-only)</value>

        [DataMember(Name="SshKeySyncGroupId")]
        public int? SshKeySyncGroupId { get; set; }

        /// <summary>
        /// Name of the SSH key sync group associated with this task (Read-only)
        /// </summary>
        /// <value>Name of the SSH key sync group associated with this task (Read-only)</value>

        [DataMember(Name="SshKeySyncGroupName")]
        public string SshKeySyncGroupName { get; set; }

        /// <summary>
        /// The database ID of the asset partition this asset belongs to (Read-only)
        /// </summary>
        /// <value>The database ID of the asset partition this asset belongs to (Read-only)</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition this asset belongs to (Read-only)
        /// </summary>
        /// <value>Name of the asset partition this asset belongs to (Read-only)</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// The database ID of the profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)
        /// </summary>
        /// <value>The database ID of the profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)</value>

        [DataMember(Name="ProfileId")]
        public int? ProfileId { get; set; }

        /// <summary>
        /// Name of the profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)
        /// </summary>
        /// <value>Name of the profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)</value>

        [DataMember(Name="ProfileName")]
        public string ProfileName { get; set; }

        /// <summary>
        /// The database ID of the SSH key profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)
        /// </summary>
        /// <value>The database ID of the SSH key profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)</value>

        [DataMember(Name="SshKeyProfileId")]
        public int? SshKeyProfileId { get; set; }

        /// <summary>
        /// Name of the SSH key profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)
        /// </summary>
        /// <value>Name of the SSH key profile explicitly set on this asset or inherited from the AssetPartition this asset belongs to (Read-only)</value>

        [DataMember(Name="SshKeyProfileName")]
        public string SshKeyProfileName { get; set; }

        /// <summary>
        /// Thumbprint of SSH key to install
        /// </summary>
        /// <value>Thumbprint of SSH key to install</value>

        [DataMember(Name="InstallSshKeyFingerprint")]
        public string InstallSshKeyFingerprint { get; set; }

        /// <summary>
        /// Fingerprint of SSH key to install
        /// </summary>
        /// <value>Fingerprint of SSH key to install</value>

        [DataMember(Name="SshKeyFingerprint")]
        public string SshKeyFingerprint { get; set; }

        /// <summary>
        /// Gets or Sets RequestStatus
        /// </summary>

        [DataMember(Name="RequestStatus")]
        public RequestStatus RequestStatus { get; set; }

        /// <summary>
        /// Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)
        /// </summary>
        /// <value>Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)</value>

        [DataMember(Name="Log")]
        public List<TaskLog> Log { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>

        [DataMember(Name="ConnectionProperties")]
        public AssetConnectionProperties ConnectionProperties { get; set; }

        /// <summary>
        /// Set of parameters passed to custom platform script
        /// </summary>
        /// <value>Set of parameters passed to custom platform script</value>

        [DataMember(Name="CustomScriptParameters")]
        public List<TaskCustomScriptParameter> CustomScriptParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordActivityLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
            sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
            sb.Append("  AccountNetBiosName: ").Append(AccountNetBiosName).Append("\n");
            sb.Append("  AccountDistinguishedName: ").Append(AccountDistinguishedName).Append("\n");
            sb.Append("  SyncGroupId: ").Append(SyncGroupId).Append("\n");
            sb.Append("  SyncGroupName: ").Append(SyncGroupName).Append("\n");
            sb.Append("  SshKeySyncGroupId: ").Append(SshKeySyncGroupId).Append("\n");
            sb.Append("  SshKeySyncGroupName: ").Append(SshKeySyncGroupName).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  SshKeyProfileId: ").Append(SshKeyProfileId).Append("\n");
            sb.Append("  SshKeyProfileName: ").Append(SshKeyProfileName).Append("\n");
            sb.Append("  InstallSshKeyFingerprint: ").Append(InstallSshKeyFingerprint).Append("\n");
            sb.Append("  SshKeyFingerprint: ").Append(SshKeyFingerprint).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
            sb.Append("  CustomScriptParameters: ").Append(CustomScriptParameters).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PasswordActivityLog)obj);
        }

        /// <summary>
        /// Returns true if PasswordActivityLog instances are equal
        /// </summary>
        /// <param name="other">Instance of PasswordActivityLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordActivityLog other)
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
                    LogTime == other.LogTime ||
                    LogTime != null &&
                    LogTime.Equals(other.LogTime)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    ApplianceName == other.ApplianceName ||
                    ApplianceName != null &&
                    ApplianceName.Equals(other.ApplianceName)
                ) && 
                (
                    EventName == other.EventName ||
                    EventName != null &&
                    EventName.Equals(other.EventName)
                ) && 
                (
                    EventDisplayName == other.EventDisplayName ||
                    EventDisplayName != null &&
                    EventDisplayName.Equals(other.EventDisplayName)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    PlatformId == other.PlatformId ||
                    PlatformId != null &&
                    PlatformId.Equals(other.PlatformId)
                ) && 
                (
                    PlatformType == other.PlatformType ||
                    PlatformType != null &&
                    PlatformType.Equals(other.PlatformType)
                ) && 
                (
                    PlatformDisplayName == other.PlatformDisplayName ||
                    PlatformDisplayName != null &&
                    PlatformDisplayName.Equals(other.PlatformDisplayName)
                ) && 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    AccountName == other.AccountName ||
                    AccountName != null &&
                    AccountName.Equals(other.AccountName)
                ) && 
                (
                    AccountDomainName == other.AccountDomainName ||
                    AccountDomainName != null &&
                    AccountDomainName.Equals(other.AccountDomainName)
                ) && 
                (
                    AccountNetBiosName == other.AccountNetBiosName ||
                    AccountNetBiosName != null &&
                    AccountNetBiosName.Equals(other.AccountNetBiosName)
                ) && 
                (
                    AccountDistinguishedName == other.AccountDistinguishedName ||
                    AccountDistinguishedName != null &&
                    AccountDistinguishedName.Equals(other.AccountDistinguishedName)
                ) && 
                (
                    SyncGroupId == other.SyncGroupId ||
                    SyncGroupId != null &&
                    SyncGroupId.Equals(other.SyncGroupId)
                ) && 
                (
                    SyncGroupName == other.SyncGroupName ||
                    SyncGroupName != null &&
                    SyncGroupName.Equals(other.SyncGroupName)
                ) && 
                (
                    SshKeySyncGroupId == other.SshKeySyncGroupId ||
                    SshKeySyncGroupId != null &&
                    SshKeySyncGroupId.Equals(other.SshKeySyncGroupId)
                ) && 
                (
                    SshKeySyncGroupName == other.SshKeySyncGroupName ||
                    SshKeySyncGroupName != null &&
                    SshKeySyncGroupName.Equals(other.SshKeySyncGroupName)
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
                    SshKeyProfileId == other.SshKeyProfileId ||
                    SshKeyProfileId != null &&
                    SshKeyProfileId.Equals(other.SshKeyProfileId)
                ) && 
                (
                    SshKeyProfileName == other.SshKeyProfileName ||
                    SshKeyProfileName != null &&
                    SshKeyProfileName.Equals(other.SshKeyProfileName)
                ) && 
                (
                    InstallSshKeyFingerprint == other.InstallSshKeyFingerprint ||
                    InstallSshKeyFingerprint != null &&
                    InstallSshKeyFingerprint.Equals(other.InstallSshKeyFingerprint)
                ) && 
                (
                    SshKeyFingerprint == other.SshKeyFingerprint ||
                    SshKeyFingerprint != null &&
                    SshKeyFingerprint.Equals(other.SshKeyFingerprint)
                ) && 
                (
                    RequestStatus == other.RequestStatus ||
                    RequestStatus != null &&
                    RequestStatus.Equals(other.RequestStatus)
                ) && 
                (
                    Log == other.Log ||
                    Log != null &&
                    Log.SequenceEqual(other.Log)
                ) && 
                (
                    ConnectionProperties == other.ConnectionProperties ||
                    ConnectionProperties != null &&
                    ConnectionProperties.Equals(other.ConnectionProperties)
                ) && 
                (
                    CustomScriptParameters == other.CustomScriptParameters ||
                    CustomScriptParameters != null &&
                    CustomScriptParameters.SequenceEqual(other.CustomScriptParameters)
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
                    if (LogTime != null)
                    hashCode = hashCode * 59 + LogTime.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (PlatformId != null)
                    hashCode = hashCode * 59 + PlatformId.GetHashCode();
                    if (PlatformType != null)
                    hashCode = hashCode * 59 + PlatformType.GetHashCode();
                    if (PlatformDisplayName != null)
                    hashCode = hashCode * 59 + PlatformDisplayName.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (AccountName != null)
                    hashCode = hashCode * 59 + AccountName.GetHashCode();
                    if (AccountDomainName != null)
                    hashCode = hashCode * 59 + AccountDomainName.GetHashCode();
                    if (AccountNetBiosName != null)
                    hashCode = hashCode * 59 + AccountNetBiosName.GetHashCode();
                    if (AccountDistinguishedName != null)
                    hashCode = hashCode * 59 + AccountDistinguishedName.GetHashCode();
                    if (SyncGroupId != null)
                    hashCode = hashCode * 59 + SyncGroupId.GetHashCode();
                    if (SyncGroupName != null)
                    hashCode = hashCode * 59 + SyncGroupName.GetHashCode();
                    if (SshKeySyncGroupId != null)
                    hashCode = hashCode * 59 + SshKeySyncGroupId.GetHashCode();
                    if (SshKeySyncGroupName != null)
                    hashCode = hashCode * 59 + SshKeySyncGroupName.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (ProfileId != null)
                    hashCode = hashCode * 59 + ProfileId.GetHashCode();
                    if (ProfileName != null)
                    hashCode = hashCode * 59 + ProfileName.GetHashCode();
                    if (SshKeyProfileId != null)
                    hashCode = hashCode * 59 + SshKeyProfileId.GetHashCode();
                    if (SshKeyProfileName != null)
                    hashCode = hashCode * 59 + SshKeyProfileName.GetHashCode();
                    if (InstallSshKeyFingerprint != null)
                    hashCode = hashCode * 59 + InstallSshKeyFingerprint.GetHashCode();
                    if (SshKeyFingerprint != null)
                    hashCode = hashCode * 59 + SshKeyFingerprint.GetHashCode();
                    if (RequestStatus != null)
                    hashCode = hashCode * 59 + RequestStatus.GetHashCode();
                    if (Log != null)
                    hashCode = hashCode * 59 + Log.GetHashCode();
                    if (ConnectionProperties != null)
                    hashCode = hashCode * 59 + ConnectionProperties.GetHashCode();
                    if (CustomScriptParameters != null)
                    hashCode = hashCode * 59 + CustomScriptParameters.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PasswordActivityLog left, PasswordActivityLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PasswordActivityLog left, PasswordActivityLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
