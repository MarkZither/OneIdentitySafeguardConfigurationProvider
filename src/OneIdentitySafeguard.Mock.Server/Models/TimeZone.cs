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
    /// Represents the read-only property values of a time zone.
    /// </summary>
    [DataContract]
    public partial class TimeZone : IEquatable<TimeZone>
    { 
        /// <summary>
        /// The time zone&#x27;s unique id. (Read-only)
        /// </summary>
        /// <value>The time zone&#x27;s unique id. (Read-only)</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// The time zone&#x27;s display name. (Read-only)
        /// </summary>
        /// <value>The time zone&#x27;s display name. (Read-only)</value>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// A standard name of the time zone. (Read-only)
        /// </summary>
        /// <value>A standard name of the time zone. (Read-only)</value>

        [DataMember(Name="StandardName")]
        public string StandardName { get; set; }

        /// <summary>
        /// A daylight name of the time zone. (Read-only)
        /// </summary>
        /// <value>A daylight name of the time zone. (Read-only)</value>

        [DataMember(Name="DaylightName")]
        public string DaylightName { get; set; }

        /// <summary>
        /// The IANA name of the time zone. (Read-only)
        /// </summary>
        /// <value>The IANA name of the time zone. (Read-only)</value>

        [DataMember(Name="IanaName")]
        public string IanaName { get; set; }

        /// <summary>
        /// The time zone&#x27;s offset from UTC (in minutes). May be a negative number or zero. (Read-only)
        /// </summary>
        /// <value>The time zone&#x27;s offset from UTC (in minutes). May be a negative number or zero. (Read-only)</value>

        [DataMember(Name="UtcOffset")]
        public int? UtcOffset { get; set; }

        /// <summary>
        /// A flag indicating whether or not the time zone observes Daylight Saving Time. (Read-only)
        /// </summary>
        /// <value>A flag indicating whether or not the time zone observes Daylight Saving Time. (Read-only)</value>

        [DataMember(Name="AllowsDst")]
        public bool? AllowsDst { get; set; }

        /// <summary>
        /// A flag indicating whether or not the time zone is obsolete. Obsolete time zones may still be referenced  by existing entities but should not be used when creating new entities. (Read-only)
        /// </summary>
        /// <value>A flag indicating whether or not the time zone is obsolete. Obsolete time zones may still be referenced  by existing entities but should not be used when creating new entities. (Read-only)</value>

        [DataMember(Name="Obsolete")]
        public bool? Obsolete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeZone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  StandardName: ").Append(StandardName).Append("\n");
            sb.Append("  DaylightName: ").Append(DaylightName).Append("\n");
            sb.Append("  IanaName: ").Append(IanaName).Append("\n");
            sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
            sb.Append("  AllowsDst: ").Append(AllowsDst).Append("\n");
            sb.Append("  Obsolete: ").Append(Obsolete).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeZone)obj);
        }

        /// <summary>
        /// Returns true if TimeZone instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeZone other)
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
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    StandardName == other.StandardName ||
                    StandardName != null &&
                    StandardName.Equals(other.StandardName)
                ) && 
                (
                    DaylightName == other.DaylightName ||
                    DaylightName != null &&
                    DaylightName.Equals(other.DaylightName)
                ) && 
                (
                    IanaName == other.IanaName ||
                    IanaName != null &&
                    IanaName.Equals(other.IanaName)
                ) && 
                (
                    UtcOffset == other.UtcOffset ||
                    UtcOffset != null &&
                    UtcOffset.Equals(other.UtcOffset)
                ) && 
                (
                    AllowsDst == other.AllowsDst ||
                    AllowsDst != null &&
                    AllowsDst.Equals(other.AllowsDst)
                ) && 
                (
                    Obsolete == other.Obsolete ||
                    Obsolete != null &&
                    Obsolete.Equals(other.Obsolete)
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
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (StandardName != null)
                    hashCode = hashCode * 59 + StandardName.GetHashCode();
                    if (DaylightName != null)
                    hashCode = hashCode * 59 + DaylightName.GetHashCode();
                    if (IanaName != null)
                    hashCode = hashCode * 59 + IanaName.GetHashCode();
                    if (UtcOffset != null)
                    hashCode = hashCode * 59 + UtcOffset.GetHashCode();
                    if (AllowsDst != null)
                    hashCode = hashCode * 59 + AllowsDst.GetHashCode();
                    if (Obsolete != null)
                    hashCode = hashCode * 59 + Obsolete.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeZone left, TimeZone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeZone left, TimeZone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
