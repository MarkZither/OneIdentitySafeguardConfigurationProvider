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
    /// Represents a system with accounts that can be managed
    /// </summary>
    [DataContract]
    public partial class Asset : IEquatable<Asset>
    { 
        /// <summary>
        /// Database ID of system (Read-only)
        /// </summary>
        /// <value>Database ID of system (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Description of the system
        /// </summary>
        /// <value>Description of the system</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Database ID of platform type / version
        /// </summary>
        /// <value>Database ID of platform type / version</value>
        [Required]

        [DataMember(Name="PlatformId")]
        public int? PlatformId { get; set; }

        /// <summary>
        /// Display name platform (Read-only)
        /// </summary>
        /// <value>Display name platform (Read-only)</value>

        [DataMember(Name="PlatformDisplayName")]
        public string PlatformDisplayName { get; set; }

        /// <summary>
        /// Whether this asset is a directory platform (Read-only)
        /// </summary>
        /// <value>Whether this asset is a directory platform (Read-only)</value>

        [DataMember(Name="IsDirectory")]
        public bool? IsDirectory { get; set; }

        /// <summary>
        /// Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.
        /// </summary>
        /// <value>Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.</value>

        [DataMember(Name="ManagedNetworkId")]
        public int? ManagedNetworkId { get; set; }

        /// <summary>
        /// Name of the managed network (Read-only)
        /// </summary>
        /// <value>Name of the managed network (Read-only)</value>

        [DataMember(Name="ManagedNetworkName")]
        public string ManagedNetworkName { get; set; }

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
        /// The name of the system. (Read-only for directories)
        /// </summary>
        /// <value>The name of the system. (Read-only for directories)</value>
        [Required]

        [StringLength(100, MinimumLength=1)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Network DNS name or IP address used to connect to the machine over the network
        /// </summary>
        /// <value>Network DNS name or IP address used to connect to the machine over the network</value>

        [MaxLength(255)]
        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Database ID of the asset partition this asset belongs to
        /// </summary>
        /// <value>Database ID of the asset partition this asset belongs to</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition this asset belongs to
        /// </summary>
        /// <value>Name of the asset partition this asset belongs to</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Gets or Sets LicenseClass
        /// </summary>

        [DataMember(Name="LicenseClass")]
        public LicenseClass LicenseClass { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryProperties
        /// </summary>

        [DataMember(Name="DirectoryProperties")]
        public DirectoryObjectProperties DirectoryProperties { get; set; }

        /// <summary>
        /// Gets or Sets TaskProperties
        /// </summary>

        [DataMember(Name="TaskProperties")]
        public AssetTaskProperties TaskProperties { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryAssetProperties
        /// </summary>

        [DataMember(Name="DirectoryAssetProperties")]
        public DirectoryAssetProperties DirectoryAssetProperties { get; set; }

        /// <summary>
        /// Gets or Sets SessionAccessProperties
        /// </summary>

        [DataMember(Name="SessionAccessProperties")]
        public AssetSessionAccessProperties SessionAccessProperties { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>

        [DataMember(Name="Platform")]
        public AssetPlatform Platform { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredConnector
        /// </summary>

        [DataMember(Name="RegisteredConnector")]
        public StarlingRegisteredConnector RegisteredConnector { get; set; }

        /// <summary>
        /// List of Identities that manage this asset
        /// </summary>
        /// <value>List of Identities that manage this asset</value>

        [DataMember(Name="ManagedBy")]
        public List<Identity> ManagedBy { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>

        [DataMember(Name="Tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Whether this asset and its accounts are disabled and prevented from running platform tasks
        /// </summary>
        /// <value>Whether this asset and its accounts are disabled and prevented from running platform tasks</value>

        [DataMember(Name="Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Database ID of asset discovery job that added this asset (Read-only)
        /// </summary>
        /// <value>Database ID of asset discovery job that added this asset (Read-only)</value>

        [DataMember(Name="AssetDiscoveryJobId")]
        public int? AssetDiscoveryJobId { get; set; }

        /// <summary>
        /// Name of asset discovery job that added this asset (Read-only)
        /// </summary>
        /// <value>Name of asset discovery job that added this asset (Read-only)</value>

        [DataMember(Name="AssetDiscoveryJobName")]
        public string AssetDiscoveryJobName { get; set; }

        /// <summary>
        /// Database ID of account discovery schedule assigned to this asset
        /// </summary>
        /// <value>Database ID of account discovery schedule assigned to this asset</value>

        [DataMember(Name="AccountDiscoveryScheduleId")]
        public int? AccountDiscoveryScheduleId { get; set; }

        /// <summary>
        /// Name of account discovery schedule assigned to this asset (Read-only)
        /// </summary>
        /// <value>Name of account discovery schedule assigned to this asset (Read-only)</value>

        [DataMember(Name="AccountDiscoveryScheduleName")]
        public string AccountDiscoveryScheduleName { get; set; }

        /// <summary>
        /// Set of parameters to pass to custom platform script
        /// </summary>
        /// <value>Set of parameters to pass to custom platform script</value>

        [DataMember(Name="CustomScriptParameters")]
        public List<AssetCustomScriptParameter> CustomScriptParameters { get; set; }

        /// <summary>
        /// Directory groups this asset is a member of
        /// </summary>
        /// <value>Directory groups this asset is a member of</value>

        [DataMember(Name="DiscoveredDirectoryGroups")]
        public List<DiscoveredGroup> DiscoveredDirectoryGroups { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>

        [DataMember(Name="ConnectionProperties")]
        public AssetConnectionProperties ConnectionProperties { get; set; }

        /// <summary>
        /// Gets or Sets SshHostKey
        /// </summary>

        [DataMember(Name="SshHostKey")]
        public AssetSshHostKey SshHostKey { get; set; }

        /// <summary>
        /// Gets or Sets PasswordProfile
        /// </summary>

        [DataMember(Name="PasswordProfile")]
        public AssetPasswordProfileProperties PasswordProfile { get; set; }

        /// <summary>
        /// Gets or Sets SshKeyProfile
        /// </summary>

        [DataMember(Name="SshKeyProfile")]
        public AssetSshKeyProfileProperties SshKeyProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
            sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
            sb.Append("  IsDirectory: ").Append(IsDirectory).Append("\n");
            sb.Append("  ManagedNetworkId: ").Append(ManagedNetworkId).Append("\n");
            sb.Append("  ManagedNetworkName: ").Append(ManagedNetworkName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  LicenseClass: ").Append(LicenseClass).Append("\n");
            sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
            sb.Append("  TaskProperties: ").Append(TaskProperties).Append("\n");
            sb.Append("  DirectoryAssetProperties: ").Append(DirectoryAssetProperties).Append("\n");
            sb.Append("  SessionAccessProperties: ").Append(SessionAccessProperties).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  RegisteredConnector: ").Append(RegisteredConnector).Append("\n");
            sb.Append("  ManagedBy: ").Append(ManagedBy).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  AssetDiscoveryJobId: ").Append(AssetDiscoveryJobId).Append("\n");
            sb.Append("  AssetDiscoveryJobName: ").Append(AssetDiscoveryJobName).Append("\n");
            sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
            sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
            sb.Append("  CustomScriptParameters: ").Append(CustomScriptParameters).Append("\n");
            sb.Append("  DiscoveredDirectoryGroups: ").Append(DiscoveredDirectoryGroups).Append("\n");
            sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
            sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
            sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
            sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Asset)obj);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="other">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    PlatformId == other.PlatformId ||
                    PlatformId != null &&
                    PlatformId.Equals(other.PlatformId)
                ) && 
                (
                    PlatformDisplayName == other.PlatformDisplayName ||
                    PlatformDisplayName != null &&
                    PlatformDisplayName.Equals(other.PlatformDisplayName)
                ) && 
                (
                    IsDirectory == other.IsDirectory ||
                    IsDirectory != null &&
                    IsDirectory.Equals(other.IsDirectory)
                ) && 
                (
                    ManagedNetworkId == other.ManagedNetworkId ||
                    ManagedNetworkId != null &&
                    ManagedNetworkId.Equals(other.ManagedNetworkId)
                ) && 
                (
                    ManagedNetworkName == other.ManagedNetworkName ||
                    ManagedNetworkName != null &&
                    ManagedNetworkName.Equals(other.ManagedNetworkName)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    LicenseClass == other.LicenseClass ||
                    LicenseClass != null &&
                    LicenseClass.Equals(other.LicenseClass)
                ) && 
                (
                    DirectoryProperties == other.DirectoryProperties ||
                    DirectoryProperties != null &&
                    DirectoryProperties.Equals(other.DirectoryProperties)
                ) && 
                (
                    TaskProperties == other.TaskProperties ||
                    TaskProperties != null &&
                    TaskProperties.Equals(other.TaskProperties)
                ) && 
                (
                    DirectoryAssetProperties == other.DirectoryAssetProperties ||
                    DirectoryAssetProperties != null &&
                    DirectoryAssetProperties.Equals(other.DirectoryAssetProperties)
                ) && 
                (
                    SessionAccessProperties == other.SessionAccessProperties ||
                    SessionAccessProperties != null &&
                    SessionAccessProperties.Equals(other.SessionAccessProperties)
                ) && 
                (
                    Platform == other.Platform ||
                    Platform != null &&
                    Platform.Equals(other.Platform)
                ) && 
                (
                    RegisteredConnector == other.RegisteredConnector ||
                    RegisteredConnector != null &&
                    RegisteredConnector.Equals(other.RegisteredConnector)
                ) && 
                (
                    ManagedBy == other.ManagedBy ||
                    ManagedBy != null &&
                    ManagedBy.SequenceEqual(other.ManagedBy)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
                ) && 
                (
                    AssetDiscoveryJobId == other.AssetDiscoveryJobId ||
                    AssetDiscoveryJobId != null &&
                    AssetDiscoveryJobId.Equals(other.AssetDiscoveryJobId)
                ) && 
                (
                    AssetDiscoveryJobName == other.AssetDiscoveryJobName ||
                    AssetDiscoveryJobName != null &&
                    AssetDiscoveryJobName.Equals(other.AssetDiscoveryJobName)
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
                    CustomScriptParameters == other.CustomScriptParameters ||
                    CustomScriptParameters != null &&
                    CustomScriptParameters.SequenceEqual(other.CustomScriptParameters)
                ) && 
                (
                    DiscoveredDirectoryGroups == other.DiscoveredDirectoryGroups ||
                    DiscoveredDirectoryGroups != null &&
                    DiscoveredDirectoryGroups.SequenceEqual(other.DiscoveredDirectoryGroups)
                ) && 
                (
                    ConnectionProperties == other.ConnectionProperties ||
                    ConnectionProperties != null &&
                    ConnectionProperties.Equals(other.ConnectionProperties)
                ) && 
                (
                    SshHostKey == other.SshHostKey ||
                    SshHostKey != null &&
                    SshHostKey.Equals(other.SshHostKey)
                ) && 
                (
                    PasswordProfile == other.PasswordProfile ||
                    PasswordProfile != null &&
                    PasswordProfile.Equals(other.PasswordProfile)
                ) && 
                (
                    SshKeyProfile == other.SshKeyProfile ||
                    SshKeyProfile != null &&
                    SshKeyProfile.Equals(other.SshKeyProfile)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (PlatformId != null)
                    hashCode = hashCode * 59 + PlatformId.GetHashCode();
                    if (PlatformDisplayName != null)
                    hashCode = hashCode * 59 + PlatformDisplayName.GetHashCode();
                    if (IsDirectory != null)
                    hashCode = hashCode * 59 + IsDirectory.GetHashCode();
                    if (ManagedNetworkId != null)
                    hashCode = hashCode * 59 + ManagedNetworkId.GetHashCode();
                    if (ManagedNetworkName != null)
                    hashCode = hashCode * 59 + ManagedNetworkName.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (LicenseClass != null)
                    hashCode = hashCode * 59 + LicenseClass.GetHashCode();
                    if (DirectoryProperties != null)
                    hashCode = hashCode * 59 + DirectoryProperties.GetHashCode();
                    if (TaskProperties != null)
                    hashCode = hashCode * 59 + TaskProperties.GetHashCode();
                    if (DirectoryAssetProperties != null)
                    hashCode = hashCode * 59 + DirectoryAssetProperties.GetHashCode();
                    if (SessionAccessProperties != null)
                    hashCode = hashCode * 59 + SessionAccessProperties.GetHashCode();
                    if (Platform != null)
                    hashCode = hashCode * 59 + Platform.GetHashCode();
                    if (RegisteredConnector != null)
                    hashCode = hashCode * 59 + RegisteredConnector.GetHashCode();
                    if (ManagedBy != null)
                    hashCode = hashCode * 59 + ManagedBy.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (AssetDiscoveryJobId != null)
                    hashCode = hashCode * 59 + AssetDiscoveryJobId.GetHashCode();
                    if (AssetDiscoveryJobName != null)
                    hashCode = hashCode * 59 + AssetDiscoveryJobName.GetHashCode();
                    if (AccountDiscoveryScheduleId != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleId.GetHashCode();
                    if (AccountDiscoveryScheduleName != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleName.GetHashCode();
                    if (CustomScriptParameters != null)
                    hashCode = hashCode * 59 + CustomScriptParameters.GetHashCode();
                    if (DiscoveredDirectoryGroups != null)
                    hashCode = hashCode * 59 + DiscoveredDirectoryGroups.GetHashCode();
                    if (ConnectionProperties != null)
                    hashCode = hashCode * 59 + ConnectionProperties.GetHashCode();
                    if (SshHostKey != null)
                    hashCode = hashCode * 59 + SshHostKey.GetHashCode();
                    if (PasswordProfile != null)
                    hashCode = hashCode * 59 + PasswordProfile.GetHashCode();
                    if (SshKeyProfile != null)
                    hashCode = hashCode * 59 + SshKeyProfile.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Asset left, Asset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Asset left, Asset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
