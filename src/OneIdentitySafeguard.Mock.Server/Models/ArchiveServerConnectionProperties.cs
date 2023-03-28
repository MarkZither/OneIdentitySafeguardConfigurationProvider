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
    public partial class ArchiveServerConnectionProperties : IEquatable<ArchiveServerConnectionProperties>
    { 
        /// <summary>
        /// Gets or Sets TransferProtocolType
        /// </summary>
        [Required]

        [DataMember(Name="TransferProtocolType")]
        public TransferProtocolType TransferProtocolType { get; set; }

        /// <summary>
        /// Database ID of an asset account for connecting to the asset. Cannot be specified simultaneously with ServiceAccountName.
        /// </summary>
        /// <value>Database ID of an asset account for connecting to the asset. Cannot be specified simultaneously with ServiceAccountName.</value>

        [DataMember(Name="ServiceAccountId")]
        public int? ServiceAccountId { get; set; }

        /// <summary>
        /// The name of an account that is not being managed for connecting to the asset. Cannot be specified simultaneously with ServiceAccountId.
        /// </summary>
        /// <value>The name of an account that is not being managed for connecting to the asset. Cannot be specified simultaneously with ServiceAccountId.</value>

        [MaxLength(100)]
        [DataMember(Name="ServiceAccountName")]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// The name of the account for connecting to the asset whether the account is managed or not (Read-only)
        /// </summary>
        /// <value>The name of the account for connecting to the asset whether the account is managed or not (Read-only)</value>

        [DataMember(Name="EffectiveServiceAccountName")]
        public string EffectiveServiceAccountName { get; set; }

        /// <summary>
        /// The domain name of the service account if the task uses a Directory  or DirectoryAccount (Read-only)
        /// </summary>
        /// <value>The domain name of the service account if the task uses a Directory  or DirectoryAccount (Read-only)</value>

        [DataMember(Name="ServiceAccountDomainName")]
        public string ServiceAccountDomainName { get; set; }

        /// <summary>
        /// Distinguished name of service account (required for OpenLdap)
        /// </summary>
        /// <value>Distinguished name of service account (required for OpenLdap)</value>

        [DataMember(Name="ServiceAccountDistinguishedName")]
        public string ServiceAccountDistinguishedName { get; set; }

        /// <summary>
        /// Effective distinguished name of service account (required for OpenLdap)
        /// </summary>
        /// <value>Effective distinguished name of service account (required for OpenLdap)</value>

        [DataMember(Name="EffectiveServiceAccountDistinguishedName")]
        public string EffectiveServiceAccountDistinguishedName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccountCredentialType
        /// </summary>

        [DataMember(Name="ServiceAccountCredentialType")]
        public ServiceAccountCredentialType ServiceAccountCredentialType { get; set; }

        /// <summary>
        /// If ServiceAccountId is not specified then the service account password may be set via this property. (write-only)
        /// </summary>
        /// <value>If ServiceAccountId is not specified then the service account password may be set via this property. (write-only)</value>

        [MaxLength(128)]
        [DataMember(Name="ServiceAccountPassword")]
        public string ServiceAccountPassword { get; set; }

        /// <summary>
        /// Whether the service account has a password set or not (Read-only)
        /// </summary>
        /// <value>Whether the service account has a password set or not (Read-only)</value>

        [DataMember(Name="ServiceAccountHasPassword")]
        public bool? ServiceAccountHasPassword { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccountSshKey
        /// </summary>

        [DataMember(Name="ServiceAccountSshKey")]
        public SystemSshKey ServiceAccountSshKey { get; set; }

        /// <summary>
        /// Whether the service account has an SSH key set or not (Read-only)
        /// </summary>
        /// <value>Whether the service account has an SSH key set or not (Read-only)</value>

        [DataMember(Name="ServiceAccountHasSshKey")]
        public bool? ServiceAccountHasSshKey { get; set; }

        /// <summary>
        /// Port used to connect to the system
        /// </summary>
        /// <value>Port used to connect to the system</value>

        [Range(1, 65535)]
        [DataMember(Name="Port")]
        public int? Port { get; set; }

        /// <summary>
        /// The database ID of the asset the service account belongs to (Read-only)
        /// </summary>
        /// <value>The database ID of the asset the service account belongs to (Read-only)</value>

        [DataMember(Name="ServiceAccountAssetId")]
        public int? ServiceAccountAssetId { get; set; }

        /// <summary>
        /// The name of the asset the service account belongs to (Read-only)
        /// </summary>
        /// <value>The name of the asset the service account belongs to (Read-only)</value>

        [DataMember(Name="ServiceAccountAssetName")]
        public string ServiceAccountAssetName { get; set; }

        /// <summary>
        /// The database ID of the platform of the asset the service account belongs to (Read-only)
        /// </summary>
        /// <value>The database ID of the platform of the asset the service account belongs to (Read-only)</value>

        [DataMember(Name="ServiceAccountAssetPlatformId")]
        public int? ServiceAccountAssetPlatformId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccountAssetPlatformType
        /// </summary>

        [DataMember(Name="ServiceAccountAssetPlatformType")]
        public PlatformType ServiceAccountAssetPlatformType { get; set; }

        /// <summary>
        /// The platform display name of the asset the service account belongs to (Read-only)
        /// </summary>
        /// <value>The platform display name of the asset the service account belongs to (Read-only)</value>

        [DataMember(Name="ServiceAccountAssetPlatformDisplayName")]
        public string ServiceAccountAssetPlatformDisplayName { get; set; }

        /// <summary>
        /// The netbios name of the service account (Read-only)
        /// </summary>
        /// <value>The netbios name of the service account (Read-only)</value>

        [DataMember(Name="ServiceAccountNetbiosName")]
        public string ServiceAccountNetbiosName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveServerConnectionProperties {\n");
            sb.Append("  TransferProtocolType: ").Append(TransferProtocolType).Append("\n");
            sb.Append("  ServiceAccountId: ").Append(ServiceAccountId).Append("\n");
            sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
            sb.Append("  EffectiveServiceAccountName: ").Append(EffectiveServiceAccountName).Append("\n");
            sb.Append("  ServiceAccountDomainName: ").Append(ServiceAccountDomainName).Append("\n");
            sb.Append("  ServiceAccountDistinguishedName: ").Append(ServiceAccountDistinguishedName).Append("\n");
            sb.Append("  EffectiveServiceAccountDistinguishedName: ").Append(EffectiveServiceAccountDistinguishedName).Append("\n");
            sb.Append("  ServiceAccountCredentialType: ").Append(ServiceAccountCredentialType).Append("\n");
            sb.Append("  ServiceAccountPassword: ").Append(ServiceAccountPassword).Append("\n");
            sb.Append("  ServiceAccountHasPassword: ").Append(ServiceAccountHasPassword).Append("\n");
            sb.Append("  ServiceAccountSshKey: ").Append(ServiceAccountSshKey).Append("\n");
            sb.Append("  ServiceAccountHasSshKey: ").Append(ServiceAccountHasSshKey).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ServiceAccountAssetId: ").Append(ServiceAccountAssetId).Append("\n");
            sb.Append("  ServiceAccountAssetName: ").Append(ServiceAccountAssetName).Append("\n");
            sb.Append("  ServiceAccountAssetPlatformId: ").Append(ServiceAccountAssetPlatformId).Append("\n");
            sb.Append("  ServiceAccountAssetPlatformType: ").Append(ServiceAccountAssetPlatformType).Append("\n");
            sb.Append("  ServiceAccountAssetPlatformDisplayName: ").Append(ServiceAccountAssetPlatformDisplayName).Append("\n");
            sb.Append("  ServiceAccountNetbiosName: ").Append(ServiceAccountNetbiosName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ArchiveServerConnectionProperties)obj);
        }

        /// <summary>
        /// Returns true if ArchiveServerConnectionProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchiveServerConnectionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveServerConnectionProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransferProtocolType == other.TransferProtocolType ||
                    TransferProtocolType != null &&
                    TransferProtocolType.Equals(other.TransferProtocolType)
                ) && 
                (
                    ServiceAccountId == other.ServiceAccountId ||
                    ServiceAccountId != null &&
                    ServiceAccountId.Equals(other.ServiceAccountId)
                ) && 
                (
                    ServiceAccountName == other.ServiceAccountName ||
                    ServiceAccountName != null &&
                    ServiceAccountName.Equals(other.ServiceAccountName)
                ) && 
                (
                    EffectiveServiceAccountName == other.EffectiveServiceAccountName ||
                    EffectiveServiceAccountName != null &&
                    EffectiveServiceAccountName.Equals(other.EffectiveServiceAccountName)
                ) && 
                (
                    ServiceAccountDomainName == other.ServiceAccountDomainName ||
                    ServiceAccountDomainName != null &&
                    ServiceAccountDomainName.Equals(other.ServiceAccountDomainName)
                ) && 
                (
                    ServiceAccountDistinguishedName == other.ServiceAccountDistinguishedName ||
                    ServiceAccountDistinguishedName != null &&
                    ServiceAccountDistinguishedName.Equals(other.ServiceAccountDistinguishedName)
                ) && 
                (
                    EffectiveServiceAccountDistinguishedName == other.EffectiveServiceAccountDistinguishedName ||
                    EffectiveServiceAccountDistinguishedName != null &&
                    EffectiveServiceAccountDistinguishedName.Equals(other.EffectiveServiceAccountDistinguishedName)
                ) && 
                (
                    ServiceAccountCredentialType == other.ServiceAccountCredentialType ||
                    ServiceAccountCredentialType != null &&
                    ServiceAccountCredentialType.Equals(other.ServiceAccountCredentialType)
                ) && 
                (
                    ServiceAccountPassword == other.ServiceAccountPassword ||
                    ServiceAccountPassword != null &&
                    ServiceAccountPassword.Equals(other.ServiceAccountPassword)
                ) && 
                (
                    ServiceAccountHasPassword == other.ServiceAccountHasPassword ||
                    ServiceAccountHasPassword != null &&
                    ServiceAccountHasPassword.Equals(other.ServiceAccountHasPassword)
                ) && 
                (
                    ServiceAccountSshKey == other.ServiceAccountSshKey ||
                    ServiceAccountSshKey != null &&
                    ServiceAccountSshKey.Equals(other.ServiceAccountSshKey)
                ) && 
                (
                    ServiceAccountHasSshKey == other.ServiceAccountHasSshKey ||
                    ServiceAccountHasSshKey != null &&
                    ServiceAccountHasSshKey.Equals(other.ServiceAccountHasSshKey)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) && 
                (
                    ServiceAccountAssetId == other.ServiceAccountAssetId ||
                    ServiceAccountAssetId != null &&
                    ServiceAccountAssetId.Equals(other.ServiceAccountAssetId)
                ) && 
                (
                    ServiceAccountAssetName == other.ServiceAccountAssetName ||
                    ServiceAccountAssetName != null &&
                    ServiceAccountAssetName.Equals(other.ServiceAccountAssetName)
                ) && 
                (
                    ServiceAccountAssetPlatformId == other.ServiceAccountAssetPlatformId ||
                    ServiceAccountAssetPlatformId != null &&
                    ServiceAccountAssetPlatformId.Equals(other.ServiceAccountAssetPlatformId)
                ) && 
                (
                    ServiceAccountAssetPlatformType == other.ServiceAccountAssetPlatformType ||
                    ServiceAccountAssetPlatformType != null &&
                    ServiceAccountAssetPlatformType.Equals(other.ServiceAccountAssetPlatformType)
                ) && 
                (
                    ServiceAccountAssetPlatformDisplayName == other.ServiceAccountAssetPlatformDisplayName ||
                    ServiceAccountAssetPlatformDisplayName != null &&
                    ServiceAccountAssetPlatformDisplayName.Equals(other.ServiceAccountAssetPlatformDisplayName)
                ) && 
                (
                    ServiceAccountNetbiosName == other.ServiceAccountNetbiosName ||
                    ServiceAccountNetbiosName != null &&
                    ServiceAccountNetbiosName.Equals(other.ServiceAccountNetbiosName)
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
                    if (TransferProtocolType != null)
                    hashCode = hashCode * 59 + TransferProtocolType.GetHashCode();
                    if (ServiceAccountId != null)
                    hashCode = hashCode * 59 + ServiceAccountId.GetHashCode();
                    if (ServiceAccountName != null)
                    hashCode = hashCode * 59 + ServiceAccountName.GetHashCode();
                    if (EffectiveServiceAccountName != null)
                    hashCode = hashCode * 59 + EffectiveServiceAccountName.GetHashCode();
                    if (ServiceAccountDomainName != null)
                    hashCode = hashCode * 59 + ServiceAccountDomainName.GetHashCode();
                    if (ServiceAccountDistinguishedName != null)
                    hashCode = hashCode * 59 + ServiceAccountDistinguishedName.GetHashCode();
                    if (EffectiveServiceAccountDistinguishedName != null)
                    hashCode = hashCode * 59 + EffectiveServiceAccountDistinguishedName.GetHashCode();
                    if (ServiceAccountCredentialType != null)
                    hashCode = hashCode * 59 + ServiceAccountCredentialType.GetHashCode();
                    if (ServiceAccountPassword != null)
                    hashCode = hashCode * 59 + ServiceAccountPassword.GetHashCode();
                    if (ServiceAccountHasPassword != null)
                    hashCode = hashCode * 59 + ServiceAccountHasPassword.GetHashCode();
                    if (ServiceAccountSshKey != null)
                    hashCode = hashCode * 59 + ServiceAccountSshKey.GetHashCode();
                    if (ServiceAccountHasSshKey != null)
                    hashCode = hashCode * 59 + ServiceAccountHasSshKey.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    if (ServiceAccountAssetId != null)
                    hashCode = hashCode * 59 + ServiceAccountAssetId.GetHashCode();
                    if (ServiceAccountAssetName != null)
                    hashCode = hashCode * 59 + ServiceAccountAssetName.GetHashCode();
                    if (ServiceAccountAssetPlatformId != null)
                    hashCode = hashCode * 59 + ServiceAccountAssetPlatformId.GetHashCode();
                    if (ServiceAccountAssetPlatformType != null)
                    hashCode = hashCode * 59 + ServiceAccountAssetPlatformType.GetHashCode();
                    if (ServiceAccountAssetPlatformDisplayName != null)
                    hashCode = hashCode * 59 + ServiceAccountAssetPlatformDisplayName.GetHashCode();
                    if (ServiceAccountNetbiosName != null)
                    hashCode = hashCode * 59 + ServiceAccountNetbiosName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ArchiveServerConnectionProperties left, ArchiveServerConnectionProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArchiveServerConnectionProperties left, ArchiveServerConnectionProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
