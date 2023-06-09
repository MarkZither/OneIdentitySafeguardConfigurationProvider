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
    public partial class MeEntitlementPolicy : IEquatable<MeEntitlementPolicy>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>

        [DataMember(Name="Priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets RolePriority
        /// </summary>

        [DataMember(Name="RolePriority")]
        public int? RolePriority { get; set; }

        /// <summary>
        /// Gets or Sets RequesterProperties
        /// </summary>

        [DataMember(Name="RequesterProperties")]
        public PolicyRequesterProperties RequesterProperties { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyAccessProperties
        /// </summary>

        [DataMember(Name="EmergencyAccessProperties")]
        public PolicyEmergencyAccessProperties EmergencyAccessProperties { get; set; }

        /// <summary>
        /// Gets or Sets AccessRequestProperties
        /// </summary>

        [DataMember(Name="AccessRequestProperties")]
        public AccessRequestProperties AccessRequestProperties { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveExpirationDate
        /// </summary>

        [DataMember(Name="EffectiveExpirationDate")]
        public DateTime? EffectiveExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveHourlyRestrictionProperties
        /// </summary>

        [DataMember(Name="EffectiveHourlyRestrictionProperties")]
        public HourlyRestrictionProperties EffectiveHourlyRestrictionProperties { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCodes
        /// </summary>

        [DataMember(Name="ReasonCodes")]
        public List<ReasonCode> ReasonCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeEntitlementPolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  RolePriority: ").Append(RolePriority).Append("\n");
            sb.Append("  RequesterProperties: ").Append(RequesterProperties).Append("\n");
            sb.Append("  EmergencyAccessProperties: ").Append(EmergencyAccessProperties).Append("\n");
            sb.Append("  AccessRequestProperties: ").Append(AccessRequestProperties).Append("\n");
            sb.Append("  EffectiveExpirationDate: ").Append(EffectiveExpirationDate).Append("\n");
            sb.Append("  EffectiveHourlyRestrictionProperties: ").Append(EffectiveHourlyRestrictionProperties).Append("\n");
            sb.Append("  ReasonCodes: ").Append(ReasonCodes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeEntitlementPolicy)obj);
        }

        /// <summary>
        /// Returns true if MeEntitlementPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of MeEntitlementPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeEntitlementPolicy other)
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
                    Priority == other.Priority ||
                    Priority != null &&
                    Priority.Equals(other.Priority)
                ) && 
                (
                    RolePriority == other.RolePriority ||
                    RolePriority != null &&
                    RolePriority.Equals(other.RolePriority)
                ) && 
                (
                    RequesterProperties == other.RequesterProperties ||
                    RequesterProperties != null &&
                    RequesterProperties.Equals(other.RequesterProperties)
                ) && 
                (
                    EmergencyAccessProperties == other.EmergencyAccessProperties ||
                    EmergencyAccessProperties != null &&
                    EmergencyAccessProperties.Equals(other.EmergencyAccessProperties)
                ) && 
                (
                    AccessRequestProperties == other.AccessRequestProperties ||
                    AccessRequestProperties != null &&
                    AccessRequestProperties.Equals(other.AccessRequestProperties)
                ) && 
                (
                    EffectiveExpirationDate == other.EffectiveExpirationDate ||
                    EffectiveExpirationDate != null &&
                    EffectiveExpirationDate.Equals(other.EffectiveExpirationDate)
                ) && 
                (
                    EffectiveHourlyRestrictionProperties == other.EffectiveHourlyRestrictionProperties ||
                    EffectiveHourlyRestrictionProperties != null &&
                    EffectiveHourlyRestrictionProperties.Equals(other.EffectiveHourlyRestrictionProperties)
                ) && 
                (
                    ReasonCodes == other.ReasonCodes ||
                    ReasonCodes != null &&
                    ReasonCodes.SequenceEqual(other.ReasonCodes)
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
                    if (Priority != null)
                    hashCode = hashCode * 59 + Priority.GetHashCode();
                    if (RolePriority != null)
                    hashCode = hashCode * 59 + RolePriority.GetHashCode();
                    if (RequesterProperties != null)
                    hashCode = hashCode * 59 + RequesterProperties.GetHashCode();
                    if (EmergencyAccessProperties != null)
                    hashCode = hashCode * 59 + EmergencyAccessProperties.GetHashCode();
                    if (AccessRequestProperties != null)
                    hashCode = hashCode * 59 + AccessRequestProperties.GetHashCode();
                    if (EffectiveExpirationDate != null)
                    hashCode = hashCode * 59 + EffectiveExpirationDate.GetHashCode();
                    if (EffectiveHourlyRestrictionProperties != null)
                    hashCode = hashCode * 59 + EffectiveHourlyRestrictionProperties.GetHashCode();
                    if (ReasonCodes != null)
                    hashCode = hashCode * 59 + ReasonCodes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeEntitlementPolicy left, MeEntitlementPolicy right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeEntitlementPolicy left, MeEntitlementPolicy right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
