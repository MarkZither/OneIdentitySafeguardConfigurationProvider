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
    /// Resource for viewing the password history of an account
    /// </summary>
    [DataContract]
    public partial class AccountPassword : IEquatable<AccountPassword>
    { 
        /// <summary>
        /// When the password came into effect
        /// </summary>
        /// <value>When the password came into effect</value>

        [DataMember(Name="TimeStarted")]
        public DateTime? TimeStarted { get; private set; }

        /// <summary>
        /// When the passowrd expired or was changed
        /// </summary>
        /// <value>When the passowrd expired or was changed</value>

        [DataMember(Name="TimeEnded")]
        public DateTime? TimeEnded { get; private set; }

        /// <summary>
        /// The password during this time period
        /// </summary>
        /// <value>The password during this time period</value>

        [DataMember(Name="Password")]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPassword {\n");
            sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
            sb.Append("  TimeEnded: ").Append(TimeEnded).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountPassword)obj);
        }

        /// <summary>
        /// Returns true if AccountPassword instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPassword other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeStarted == other.TimeStarted ||
                    TimeStarted != null &&
                    TimeStarted.Equals(other.TimeStarted)
                ) && 
                (
                    TimeEnded == other.TimeEnded ||
                    TimeEnded != null &&
                    TimeEnded.Equals(other.TimeEnded)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
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
                    if (TimeStarted != null)
                    hashCode = hashCode * 59 + TimeStarted.GetHashCode();
                    if (TimeEnded != null)
                    hashCode = hashCode * 59 + TimeEnded.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountPassword left, AccountPassword right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountPassword left, AccountPassword right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}