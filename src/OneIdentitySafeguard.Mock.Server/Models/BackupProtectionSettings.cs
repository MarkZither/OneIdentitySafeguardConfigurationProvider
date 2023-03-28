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
    public partial class BackupProtectionSettings : IEquatable<BackupProtectionSettings>
    { 
        /// <summary>
        /// System set guid string when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password
        /// </summary>
        /// <value>System set guid string when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password</value>

        [DataMember(Name="BackupPasswordIdentifier")]
        public string BackupPasswordIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets BackupProtectionType
        /// </summary>

        [DataMember(Name="BackupProtectionType")]
        public BackupProtectionType BackupProtectionType { get; set; }

        /// <summary>
        /// User defined password when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password
        /// </summary>
        /// <value>User defined password when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password</value>

        [DataMember(Name="BackupPassword")]
        public string BackupPassword { get; set; }

        /// <summary>
        /// User specified GPG public key name when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
        /// </summary>
        /// <value>User specified GPG public key name when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>

        [DataMember(Name="BackupGpgPublicKeyName")]
        public string BackupGpgPublicKeyName { get; set; }

        /// <summary>
        /// User specified GPG public key data when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
        /// </summary>
        /// <value>User specified GPG public key data when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>

        [DataMember(Name="BackupGpgPublicKeyData")]
        public string BackupGpgPublicKeyData { get; set; }

        /// <summary>
        /// User specified GPG public key fingerprint when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
        /// </summary>
        /// <value>User specified GPG public key fingerprint when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>

        [DataMember(Name="BackupGpgPublicKeyFingerprint")]
        public string BackupGpgPublicKeyFingerprint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupProtectionSettings {\n");
            sb.Append("  BackupPasswordIdentifier: ").Append(BackupPasswordIdentifier).Append("\n");
            sb.Append("  BackupProtectionType: ").Append(BackupProtectionType).Append("\n");
            sb.Append("  BackupPassword: ").Append(BackupPassword).Append("\n");
            sb.Append("  BackupGpgPublicKeyName: ").Append(BackupGpgPublicKeyName).Append("\n");
            sb.Append("  BackupGpgPublicKeyData: ").Append(BackupGpgPublicKeyData).Append("\n");
            sb.Append("  BackupGpgPublicKeyFingerprint: ").Append(BackupGpgPublicKeyFingerprint).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BackupProtectionSettings)obj);
        }

        /// <summary>
        /// Returns true if BackupProtectionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of BackupProtectionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupProtectionSettings other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BackupPasswordIdentifier == other.BackupPasswordIdentifier ||
                    BackupPasswordIdentifier != null &&
                    BackupPasswordIdentifier.Equals(other.BackupPasswordIdentifier)
                ) && 
                (
                    BackupProtectionType == other.BackupProtectionType ||
                    BackupProtectionType != null &&
                    BackupProtectionType.Equals(other.BackupProtectionType)
                ) && 
                (
                    BackupPassword == other.BackupPassword ||
                    BackupPassword != null &&
                    BackupPassword.Equals(other.BackupPassword)
                ) && 
                (
                    BackupGpgPublicKeyName == other.BackupGpgPublicKeyName ||
                    BackupGpgPublicKeyName != null &&
                    BackupGpgPublicKeyName.Equals(other.BackupGpgPublicKeyName)
                ) && 
                (
                    BackupGpgPublicKeyData == other.BackupGpgPublicKeyData ||
                    BackupGpgPublicKeyData != null &&
                    BackupGpgPublicKeyData.Equals(other.BackupGpgPublicKeyData)
                ) && 
                (
                    BackupGpgPublicKeyFingerprint == other.BackupGpgPublicKeyFingerprint ||
                    BackupGpgPublicKeyFingerprint != null &&
                    BackupGpgPublicKeyFingerprint.Equals(other.BackupGpgPublicKeyFingerprint)
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
                    if (BackupPasswordIdentifier != null)
                    hashCode = hashCode * 59 + BackupPasswordIdentifier.GetHashCode();
                    if (BackupProtectionType != null)
                    hashCode = hashCode * 59 + BackupProtectionType.GetHashCode();
                    if (BackupPassword != null)
                    hashCode = hashCode * 59 + BackupPassword.GetHashCode();
                    if (BackupGpgPublicKeyName != null)
                    hashCode = hashCode * 59 + BackupGpgPublicKeyName.GetHashCode();
                    if (BackupGpgPublicKeyData != null)
                    hashCode = hashCode * 59 + BackupGpgPublicKeyData.GetHashCode();
                    if (BackupGpgPublicKeyFingerprint != null)
                    hashCode = hashCode * 59 + BackupGpgPublicKeyFingerprint.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BackupProtectionSettings left, BackupProtectionSettings right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BackupProtectionSettings left, BackupProtectionSettings right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
