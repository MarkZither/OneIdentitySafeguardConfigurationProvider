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
    /// Interval of time in which to execute tasks
    /// </summary>
    [DataContract]
    public partial class ScheduleInterval : IEquatable<ScheduleInterval>
    { 
        /// <summary>
        /// Hour the interval starts
        /// </summary>
        /// <value>Hour the interval starts</value>
        [Required]

        [Range(0, 23)]
        [DataMember(Name="StartHour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// Minute the interval starts
        /// </summary>
        /// <value>Minute the interval starts</value>
        [Required]

        [Range(0, 59)]
        [DataMember(Name="StartMinute")]
        public int? StartMinute { get; set; }

        /// <summary>
        /// Hour the interval ends
        /// </summary>
        /// <value>Hour the interval ends</value>
        [Required]

        [Range(0, 23)]
        [DataMember(Name="EndHour")]
        public int? EndHour { get; set; }

        /// <summary>
        /// Minute the interval ends. The end minute is not included in the window interval
        /// </summary>
        /// <value>Minute the interval ends. The end minute is not included in the window interval</value>
        [Required]

        [Range(0, 59)]
        [DataMember(Name="EndMinute")]
        public int? EndMinute { get; set; }

        /// <summary>
        /// Number of times to execute tasks during schedule window (derived using RepeatInterval for Hourly and Minute schedule types)
        /// </summary>
        /// <value>Number of times to execute tasks during schedule window (derived using RepeatInterval for Hourly and Minute schedule types)</value>

        [Range(1, 1440)]
        [DataMember(Name="Iterations")]
        public int? Iterations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleInterval {\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
            sb.Append("  EndHour: ").Append(EndHour).Append("\n");
            sb.Append("  EndMinute: ").Append(EndMinute).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScheduleInterval)obj);
        }

        /// <summary>
        /// Returns true if ScheduleInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleInterval other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartHour == other.StartHour ||
                    StartHour != null &&
                    StartHour.Equals(other.StartHour)
                ) && 
                (
                    StartMinute == other.StartMinute ||
                    StartMinute != null &&
                    StartMinute.Equals(other.StartMinute)
                ) && 
                (
                    EndHour == other.EndHour ||
                    EndHour != null &&
                    EndHour.Equals(other.EndHour)
                ) && 
                (
                    EndMinute == other.EndMinute ||
                    EndMinute != null &&
                    EndMinute.Equals(other.EndMinute)
                ) && 
                (
                    Iterations == other.Iterations ||
                    Iterations != null &&
                    Iterations.Equals(other.Iterations)
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
                    if (StartHour != null)
                    hashCode = hashCode * 59 + StartHour.GetHashCode();
                    if (StartMinute != null)
                    hashCode = hashCode * 59 + StartMinute.GetHashCode();
                    if (EndHour != null)
                    hashCode = hashCode * 59 + EndHour.GetHashCode();
                    if (EndMinute != null)
                    hashCode = hashCode * 59 + EndMinute.GetHashCode();
                    if (Iterations != null)
                    hashCode = hashCode * 59 + Iterations.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScheduleInterval left, ScheduleInterval right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScheduleInterval left, ScheduleInterval right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
