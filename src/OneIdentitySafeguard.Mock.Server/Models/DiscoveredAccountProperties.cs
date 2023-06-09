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
    public partial class DiscoveredAccountProperties : IEquatable<DiscoveredAccountProperties>
    { 
        /// <summary>
        /// The unique ID of the account discovery schedule that discovered this account
        /// </summary>
        /// <value>The unique ID of the account discovery schedule that discovered this account</value>

        [DataMember(Name="AccountDiscoveryScheduleId")]
        public int? AccountDiscoveryScheduleId { get; set; }

        /// <summary>
        /// The name of the account discovery schedule that discovered this account
        /// </summary>
        /// <value>The name of the account discovery schedule that discovered this account</value>

        [DataMember(Name="AccountDiscoveryScheduleName")]
        public string AccountDiscoveryScheduleName { get; set; }

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
            sb.Append("class DiscoveredAccountProperties {\n");
            sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
            sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
            sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
            sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DiscoveredAccountProperties)obj);
        }

        /// <summary>
        /// Returns true if DiscoveredAccountProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscoveredAccountProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveredAccountProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    if (AccountDiscoveryScheduleId != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleId.GetHashCode();
                    if (AccountDiscoveryScheduleName != null)
                    hashCode = hashCode * 59 + AccountDiscoveryScheduleName.GetHashCode();
                    if (DiscoveredUserId != null)
                    hashCode = hashCode * 59 + DiscoveredUserId.GetHashCode();
                    if (DiscoveredDate != null)
                    hashCode = hashCode * 59 + DiscoveredDate.GetHashCode();
                    if (DiscoveredGroups != null)
                    hashCode = hashCode * 59 + DiscoveredGroups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DiscoveredAccountProperties left, DiscoveredAccountProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiscoveredAccountProperties left, DiscoveredAccountProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
