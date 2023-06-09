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
    /// Configuration for managing accounts/assets in a partition
    /// </summary>
    [DataContract]
    public partial class PasswordProfile : IEquatable<PasswordProfile>
    { 
        /// <summary>
        /// Database ID of the profile (Read-only)
        /// </summary>
        /// <value>Database ID of the profile (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of this profile
        /// </summary>
        /// <value>Name of this profile</value>
        [Required]

        [StringLength(70, MinimumLength=1)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of this profile
        /// </summary>
        /// <value>Description of this profile</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

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
        /// Database ID of the password complexity rule that will be enforced. The password rule governs the construction requirements for new password generation.
        /// </summary>
        /// <value>Database ID of the password complexity rule that will be enforced. The password rule governs the construction requirements for new password generation.</value>

        [DataMember(Name="AccountPasswordRuleId")]
        public int? AccountPasswordRuleId { get; set; }

        /// <summary>
        /// Name of the account password rule enforced by this profile (Read-only)
        /// </summary>
        /// <value>Name of the account password rule enforced by this profile (Read-only)</value>

        [DataMember(Name="AccountPasswordRuleName")]
        public string AccountPasswordRuleName { get; set; }

        /// <summary>
        /// Id of the Password Check Schedule
        /// </summary>
        /// <value>Id of the Password Check Schedule</value>

        [DataMember(Name="CheckScheduleId")]
        public int? CheckScheduleId { get; set; }

        /// <summary>
        /// Name of the Password Check Schedule
        /// </summary>
        /// <value>Name of the Password Check Schedule</value>

        [DataMember(Name="CheckScheduleName")]
        public string CheckScheduleName { get; set; }

        /// <summary>
        /// Id of the Password Change Schedule
        /// </summary>
        /// <value>Id of the Password Change Schedule</value>

        [DataMember(Name="ChangeScheduleId")]
        public int? ChangeScheduleId { get; set; }

        /// <summary>
        /// Name of the Password Change Schedule
        /// </summary>
        /// <value>Name of the Password Change Schedule</value>

        [DataMember(Name="ChangeScheduleName")]
        public string ChangeScheduleName { get; set; }

        /// <summary>
        /// Gets or Sets CheckSchedule
        /// </summary>

        [DataMember(Name="CheckSchedule")]
        public PasswordCheckSchedule CheckSchedule { get; set; }

        /// <summary>
        /// Gets or Sets ChangeSchedule
        /// </summary>

        [DataMember(Name="ChangeSchedule")]
        public PasswordChangeSchedule ChangeSchedule { get; set; }

        /// <summary>
        /// Gets or Sets AccountPasswordRule
        /// </summary>

        [DataMember(Name="AccountPasswordRule")]
        public AccountPasswordRule AccountPasswordRule { get; set; }

        /// <summary>
        /// The asset partition this profile belongs to (Read-only)
        /// </summary>
        /// <value>The asset partition this profile belongs to (Read-only)</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition this profile belongs to (Read-only)
        /// </summary>
        /// <value>Name of the asset partition this profile belongs to (Read-only)</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
            sb.Append("  AccountPasswordRuleId: ").Append(AccountPasswordRuleId).Append("\n");
            sb.Append("  AccountPasswordRuleName: ").Append(AccountPasswordRuleName).Append("\n");
            sb.Append("  CheckScheduleId: ").Append(CheckScheduleId).Append("\n");
            sb.Append("  CheckScheduleName: ").Append(CheckScheduleName).Append("\n");
            sb.Append("  ChangeScheduleId: ").Append(ChangeScheduleId).Append("\n");
            sb.Append("  ChangeScheduleName: ").Append(ChangeScheduleName).Append("\n");
            sb.Append("  CheckSchedule: ").Append(CheckSchedule).Append("\n");
            sb.Append("  ChangeSchedule: ").Append(ChangeSchedule).Append("\n");
            sb.Append("  AccountPasswordRule: ").Append(AccountPasswordRule).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PasswordProfile)obj);
        }

        /// <summary>
        /// Returns true if PasswordProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of PasswordProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordProfile other)
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
                    AccountPasswordRuleId == other.AccountPasswordRuleId ||
                    AccountPasswordRuleId != null &&
                    AccountPasswordRuleId.Equals(other.AccountPasswordRuleId)
                ) && 
                (
                    AccountPasswordRuleName == other.AccountPasswordRuleName ||
                    AccountPasswordRuleName != null &&
                    AccountPasswordRuleName.Equals(other.AccountPasswordRuleName)
                ) && 
                (
                    CheckScheduleId == other.CheckScheduleId ||
                    CheckScheduleId != null &&
                    CheckScheduleId.Equals(other.CheckScheduleId)
                ) && 
                (
                    CheckScheduleName == other.CheckScheduleName ||
                    CheckScheduleName != null &&
                    CheckScheduleName.Equals(other.CheckScheduleName)
                ) && 
                (
                    ChangeScheduleId == other.ChangeScheduleId ||
                    ChangeScheduleId != null &&
                    ChangeScheduleId.Equals(other.ChangeScheduleId)
                ) && 
                (
                    ChangeScheduleName == other.ChangeScheduleName ||
                    ChangeScheduleName != null &&
                    ChangeScheduleName.Equals(other.ChangeScheduleName)
                ) && 
                (
                    CheckSchedule == other.CheckSchedule ||
                    CheckSchedule != null &&
                    CheckSchedule.Equals(other.CheckSchedule)
                ) && 
                (
                    ChangeSchedule == other.ChangeSchedule ||
                    ChangeSchedule != null &&
                    ChangeSchedule.Equals(other.ChangeSchedule)
                ) && 
                (
                    AccountPasswordRule == other.AccountPasswordRule ||
                    AccountPasswordRule != null &&
                    AccountPasswordRule.Equals(other.AccountPasswordRule)
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
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                    if (AccountPasswordRuleId != null)
                    hashCode = hashCode * 59 + AccountPasswordRuleId.GetHashCode();
                    if (AccountPasswordRuleName != null)
                    hashCode = hashCode * 59 + AccountPasswordRuleName.GetHashCode();
                    if (CheckScheduleId != null)
                    hashCode = hashCode * 59 + CheckScheduleId.GetHashCode();
                    if (CheckScheduleName != null)
                    hashCode = hashCode * 59 + CheckScheduleName.GetHashCode();
                    if (ChangeScheduleId != null)
                    hashCode = hashCode * 59 + ChangeScheduleId.GetHashCode();
                    if (ChangeScheduleName != null)
                    hashCode = hashCode * 59 + ChangeScheduleName.GetHashCode();
                    if (CheckSchedule != null)
                    hashCode = hashCode * 59 + CheckSchedule.GetHashCode();
                    if (ChangeSchedule != null)
                    hashCode = hashCode * 59 + ChangeSchedule.GetHashCode();
                    if (AccountPasswordRule != null)
                    hashCode = hashCode * 59 + AccountPasswordRule.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PasswordProfile left, PasswordProfile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PasswordProfile left, PasswordProfile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
