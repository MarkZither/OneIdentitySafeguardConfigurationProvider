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
    public partial class UserLogProperties : IEquatable<UserLogProperties>
    { 
        /// <summary>
        /// IP address of the user client that caused the change (Read-only).
        /// </summary>
        /// <value>IP address of the user client that caused the change (Read-only).</value>

        [DataMember(Name="ClientIpAddress")]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// UserName of the user that caused the change (Read-only).
        /// </summary>
        /// <value>UserName of the user that caused the change (Read-only).</value>

        [DataMember(Name="UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Domain name of the user that caused the change (Read-only).
        /// </summary>
        /// <value>Domain name of the user that caused the change (Read-only).</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// DisplayName of the user that caused the change (Read-only).
        /// </summary>
        /// <value>DisplayName of the user that caused the change (Read-only).</value>

        [DataMember(Name="UserDisplayName")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// Was the user in the GlobalAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the GlobalAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasGlobalAdmin")]
        public bool? UserWasGlobalAdmin { get; set; }

        /// <summary>
        /// Was the user in the DirectoryAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the DirectoryAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasDirectoryAdmin")]
        public bool? UserWasDirectoryAdmin { get; set; }

        /// <summary>
        /// Was the user in the Auditor role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the Auditor role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasAuditor")]
        public bool? UserWasAuditor { get; set; }

        /// <summary>
        /// Was the user in the ApplicationAuditor role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the ApplicationAuditor role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasApplicationAuditor")]
        public bool? UserWasApplicationAuditor { get; set; }

        /// <summary>
        /// Was the user in the SystemAuditor role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the SystemAuditor role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasSystemAuditor")]
        public bool? UserWasSystemAuditor { get; set; }

        /// <summary>
        /// Was the user in the AssetAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the AssetAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasAssetAdmin")]
        public bool? UserWasAssetAdmin { get; set; }

        /// <summary>
        /// Was the user a partition owner at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user a partition owner at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasPartitionOwner")]
        public bool? UserWasPartitionOwner { get; set; }

        /// <summary>
        /// Was the user in the ApplianceAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the ApplianceAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasApplianceAdmin")]
        public bool? UserWasApplianceAdmin { get; set; }

        /// <summary>
        /// Was the user in the PolicyAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the PolicyAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasPolicyAdmin")]
        public bool? UserWasPolicyAdmin { get; set; }

        /// <summary>
        /// Was the user in the UserAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the UserAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasUserAdmin")]
        public bool? UserWasUserAdmin { get; set; }

        /// <summary>
        /// Was the user in the HelpdeskAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the HelpdeskAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasHelpdeskAdmin")]
        public bool? UserWasHelpdeskAdmin { get; set; }

        /// <summary>
        /// Was the user in the OperationsAdmin role at the time of the change? (Read-only).
        /// </summary>
        /// <value>Was the user in the OperationsAdmin role at the time of the change? (Read-only).</value>

        [DataMember(Name="UserWasOperationsAdmin")]
        public bool? UserWasOperationsAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLogProperties {\n");
            sb.Append("  ClientIpAddress: ").Append(ClientIpAddress).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
            sb.Append("  UserWasGlobalAdmin: ").Append(UserWasGlobalAdmin).Append("\n");
            sb.Append("  UserWasDirectoryAdmin: ").Append(UserWasDirectoryAdmin).Append("\n");
            sb.Append("  UserWasAuditor: ").Append(UserWasAuditor).Append("\n");
            sb.Append("  UserWasApplicationAuditor: ").Append(UserWasApplicationAuditor).Append("\n");
            sb.Append("  UserWasSystemAuditor: ").Append(UserWasSystemAuditor).Append("\n");
            sb.Append("  UserWasAssetAdmin: ").Append(UserWasAssetAdmin).Append("\n");
            sb.Append("  UserWasPartitionOwner: ").Append(UserWasPartitionOwner).Append("\n");
            sb.Append("  UserWasApplianceAdmin: ").Append(UserWasApplianceAdmin).Append("\n");
            sb.Append("  UserWasPolicyAdmin: ").Append(UserWasPolicyAdmin).Append("\n");
            sb.Append("  UserWasUserAdmin: ").Append(UserWasUserAdmin).Append("\n");
            sb.Append("  UserWasHelpdeskAdmin: ").Append(UserWasHelpdeskAdmin).Append("\n");
            sb.Append("  UserWasOperationsAdmin: ").Append(UserWasOperationsAdmin).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserLogProperties)obj);
        }

        /// <summary>
        /// Returns true if UserLogProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLogProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLogProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClientIpAddress == other.ClientIpAddress ||
                    ClientIpAddress != null &&
                    ClientIpAddress.Equals(other.ClientIpAddress)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    UserDisplayName == other.UserDisplayName ||
                    UserDisplayName != null &&
                    UserDisplayName.Equals(other.UserDisplayName)
                ) && 
                (
                    UserWasGlobalAdmin == other.UserWasGlobalAdmin ||
                    UserWasGlobalAdmin != null &&
                    UserWasGlobalAdmin.Equals(other.UserWasGlobalAdmin)
                ) && 
                (
                    UserWasDirectoryAdmin == other.UserWasDirectoryAdmin ||
                    UserWasDirectoryAdmin != null &&
                    UserWasDirectoryAdmin.Equals(other.UserWasDirectoryAdmin)
                ) && 
                (
                    UserWasAuditor == other.UserWasAuditor ||
                    UserWasAuditor != null &&
                    UserWasAuditor.Equals(other.UserWasAuditor)
                ) && 
                (
                    UserWasApplicationAuditor == other.UserWasApplicationAuditor ||
                    UserWasApplicationAuditor != null &&
                    UserWasApplicationAuditor.Equals(other.UserWasApplicationAuditor)
                ) && 
                (
                    UserWasSystemAuditor == other.UserWasSystemAuditor ||
                    UserWasSystemAuditor != null &&
                    UserWasSystemAuditor.Equals(other.UserWasSystemAuditor)
                ) && 
                (
                    UserWasAssetAdmin == other.UserWasAssetAdmin ||
                    UserWasAssetAdmin != null &&
                    UserWasAssetAdmin.Equals(other.UserWasAssetAdmin)
                ) && 
                (
                    UserWasPartitionOwner == other.UserWasPartitionOwner ||
                    UserWasPartitionOwner != null &&
                    UserWasPartitionOwner.Equals(other.UserWasPartitionOwner)
                ) && 
                (
                    UserWasApplianceAdmin == other.UserWasApplianceAdmin ||
                    UserWasApplianceAdmin != null &&
                    UserWasApplianceAdmin.Equals(other.UserWasApplianceAdmin)
                ) && 
                (
                    UserWasPolicyAdmin == other.UserWasPolicyAdmin ||
                    UserWasPolicyAdmin != null &&
                    UserWasPolicyAdmin.Equals(other.UserWasPolicyAdmin)
                ) && 
                (
                    UserWasUserAdmin == other.UserWasUserAdmin ||
                    UserWasUserAdmin != null &&
                    UserWasUserAdmin.Equals(other.UserWasUserAdmin)
                ) && 
                (
                    UserWasHelpdeskAdmin == other.UserWasHelpdeskAdmin ||
                    UserWasHelpdeskAdmin != null &&
                    UserWasHelpdeskAdmin.Equals(other.UserWasHelpdeskAdmin)
                ) && 
                (
                    UserWasOperationsAdmin == other.UserWasOperationsAdmin ||
                    UserWasOperationsAdmin != null &&
                    UserWasOperationsAdmin.Equals(other.UserWasOperationsAdmin)
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
                    if (ClientIpAddress != null)
                    hashCode = hashCode * 59 + ClientIpAddress.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (UserDisplayName != null)
                    hashCode = hashCode * 59 + UserDisplayName.GetHashCode();
                    if (UserWasGlobalAdmin != null)
                    hashCode = hashCode * 59 + UserWasGlobalAdmin.GetHashCode();
                    if (UserWasDirectoryAdmin != null)
                    hashCode = hashCode * 59 + UserWasDirectoryAdmin.GetHashCode();
                    if (UserWasAuditor != null)
                    hashCode = hashCode * 59 + UserWasAuditor.GetHashCode();
                    if (UserWasApplicationAuditor != null)
                    hashCode = hashCode * 59 + UserWasApplicationAuditor.GetHashCode();
                    if (UserWasSystemAuditor != null)
                    hashCode = hashCode * 59 + UserWasSystemAuditor.GetHashCode();
                    if (UserWasAssetAdmin != null)
                    hashCode = hashCode * 59 + UserWasAssetAdmin.GetHashCode();
                    if (UserWasPartitionOwner != null)
                    hashCode = hashCode * 59 + UserWasPartitionOwner.GetHashCode();
                    if (UserWasApplianceAdmin != null)
                    hashCode = hashCode * 59 + UserWasApplianceAdmin.GetHashCode();
                    if (UserWasPolicyAdmin != null)
                    hashCode = hashCode * 59 + UserWasPolicyAdmin.GetHashCode();
                    if (UserWasUserAdmin != null)
                    hashCode = hashCode * 59 + UserWasUserAdmin.GetHashCode();
                    if (UserWasHelpdeskAdmin != null)
                    hashCode = hashCode * 59 + UserWasHelpdeskAdmin.GetHashCode();
                    if (UserWasOperationsAdmin != null)
                    hashCode = hashCode * 59 + UserWasOperationsAdmin.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserLogProperties left, UserLogProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserLogProperties left, UserLogProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
