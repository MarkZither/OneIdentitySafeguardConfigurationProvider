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
    /// Settings controlling when the policy/role will be effective
    /// </summary>
    [DataContract]
    public partial class HourlyRestrictionProperties : IEquatable<HourlyRestrictionProperties>
    { 
        /// <summary>
        /// Whether time restrictions are to be enforced. If false, the policy/role is always valid.
        /// </summary>
        /// <value>Whether time restrictions are to be enforced. If false, the policy/role is always valid.</value>

        [DataMember(Name="EnableHourlyRestrictions")]
        public bool? EnableHourlyRestrictions { get; set; }

        /// <summary>
        /// List of hours on Monday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Monday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="MondayValidHours")]
        public List<int?> MondayValidHours { get; set; }

        /// <summary>
        /// List of hours on Tuesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Tuesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="TuesdayValidHours")]
        public List<int?> TuesdayValidHours { get; set; }

        /// <summary>
        /// List of hours on Wednesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Wednesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="WednesdayValidHours")]
        public List<int?> WednesdayValidHours { get; set; }

        /// <summary>
        /// List of hours on Thursday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Thursday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="ThursdayValidHours")]
        public List<int?> ThursdayValidHours { get; set; }

        /// <summary>
        /// List of hours on Friday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Friday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="FridayValidHours")]
        public List<int?> FridayValidHours { get; set; }

        /// <summary>
        /// List of hours on Saturday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Saturday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="SaturdayValidHours")]
        public List<int?> SaturdayValidHours { get; set; }

        /// <summary>
        /// List of hours on Sunday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
        /// </summary>
        /// <value>List of hours on Sunday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>

        [DataMember(Name="SundayValidHours")]
        public List<int?> SundayValidHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HourlyRestrictionProperties {\n");
            sb.Append("  EnableHourlyRestrictions: ").Append(EnableHourlyRestrictions).Append("\n");
            sb.Append("  MondayValidHours: ").Append(MondayValidHours).Append("\n");
            sb.Append("  TuesdayValidHours: ").Append(TuesdayValidHours).Append("\n");
            sb.Append("  WednesdayValidHours: ").Append(WednesdayValidHours).Append("\n");
            sb.Append("  ThursdayValidHours: ").Append(ThursdayValidHours).Append("\n");
            sb.Append("  FridayValidHours: ").Append(FridayValidHours).Append("\n");
            sb.Append("  SaturdayValidHours: ").Append(SaturdayValidHours).Append("\n");
            sb.Append("  SundayValidHours: ").Append(SundayValidHours).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HourlyRestrictionProperties)obj);
        }

        /// <summary>
        /// Returns true if HourlyRestrictionProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of HourlyRestrictionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HourlyRestrictionProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EnableHourlyRestrictions == other.EnableHourlyRestrictions ||
                    EnableHourlyRestrictions != null &&
                    EnableHourlyRestrictions.Equals(other.EnableHourlyRestrictions)
                ) && 
                (
                    MondayValidHours == other.MondayValidHours ||
                    MondayValidHours != null &&
                    MondayValidHours.SequenceEqual(other.MondayValidHours)
                ) && 
                (
                    TuesdayValidHours == other.TuesdayValidHours ||
                    TuesdayValidHours != null &&
                    TuesdayValidHours.SequenceEqual(other.TuesdayValidHours)
                ) && 
                (
                    WednesdayValidHours == other.WednesdayValidHours ||
                    WednesdayValidHours != null &&
                    WednesdayValidHours.SequenceEqual(other.WednesdayValidHours)
                ) && 
                (
                    ThursdayValidHours == other.ThursdayValidHours ||
                    ThursdayValidHours != null &&
                    ThursdayValidHours.SequenceEqual(other.ThursdayValidHours)
                ) && 
                (
                    FridayValidHours == other.FridayValidHours ||
                    FridayValidHours != null &&
                    FridayValidHours.SequenceEqual(other.FridayValidHours)
                ) && 
                (
                    SaturdayValidHours == other.SaturdayValidHours ||
                    SaturdayValidHours != null &&
                    SaturdayValidHours.SequenceEqual(other.SaturdayValidHours)
                ) && 
                (
                    SundayValidHours == other.SundayValidHours ||
                    SundayValidHours != null &&
                    SundayValidHours.SequenceEqual(other.SundayValidHours)
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
                    if (EnableHourlyRestrictions != null)
                    hashCode = hashCode * 59 + EnableHourlyRestrictions.GetHashCode();
                    if (MondayValidHours != null)
                    hashCode = hashCode * 59 + MondayValidHours.GetHashCode();
                    if (TuesdayValidHours != null)
                    hashCode = hashCode * 59 + TuesdayValidHours.GetHashCode();
                    if (WednesdayValidHours != null)
                    hashCode = hashCode * 59 + WednesdayValidHours.GetHashCode();
                    if (ThursdayValidHours != null)
                    hashCode = hashCode * 59 + ThursdayValidHours.GetHashCode();
                    if (FridayValidHours != null)
                    hashCode = hashCode * 59 + FridayValidHours.GetHashCode();
                    if (SaturdayValidHours != null)
                    hashCode = hashCode * 59 + SaturdayValidHours.GetHashCode();
                    if (SundayValidHours != null)
                    hashCode = hashCode * 59 + SundayValidHours.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HourlyRestrictionProperties left, HourlyRestrictionProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HourlyRestrictionProperties left, HourlyRestrictionProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
