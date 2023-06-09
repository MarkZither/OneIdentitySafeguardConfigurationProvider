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
    /// Parameters for initiating a session for an access request
    /// </summary>
    [DataContract]
    public partial class InitiateSessionParameters : IEquatable<InitiateSessionParameters>
    { 
        /// <summary>
        /// Name of session access account if using user-supplied credentials
        /// </summary>
        /// <value>Name of session access account if using user-supplied credentials</value>

        [DataMember(Name="SessionAccessAccountName")]
        public string SessionAccessAccountName { get; set; }

        /// <summary>
        /// DomainName of session access account if using user-supplied credentials
        /// </summary>
        /// <value>DomainName of session access account if using user-supplied credentials</value>

        [DataMember(Name="SessionAccessAccountDomainName")]
        public string SessionAccessAccountDomainName { get; set; }

        /// <summary>
        /// Password of session access account if using user-supplied credentials
        /// </summary>
        /// <value>Password of session access account if using user-supplied credentials</value>

        [DataMember(Name="SessionAccessAccountPassword")]
        public string SessionAccessAccountPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateSessionParameters {\n");
            sb.Append("  SessionAccessAccountName: ").Append(SessionAccessAccountName).Append("\n");
            sb.Append("  SessionAccessAccountDomainName: ").Append(SessionAccessAccountDomainName).Append("\n");
            sb.Append("  SessionAccessAccountPassword: ").Append(SessionAccessAccountPassword).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InitiateSessionParameters)obj);
        }

        /// <summary>
        /// Returns true if InitiateSessionParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiateSessionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateSessionParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SessionAccessAccountName == other.SessionAccessAccountName ||
                    SessionAccessAccountName != null &&
                    SessionAccessAccountName.Equals(other.SessionAccessAccountName)
                ) && 
                (
                    SessionAccessAccountDomainName == other.SessionAccessAccountDomainName ||
                    SessionAccessAccountDomainName != null &&
                    SessionAccessAccountDomainName.Equals(other.SessionAccessAccountDomainName)
                ) && 
                (
                    SessionAccessAccountPassword == other.SessionAccessAccountPassword ||
                    SessionAccessAccountPassword != null &&
                    SessionAccessAccountPassword.Equals(other.SessionAccessAccountPassword)
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
                    if (SessionAccessAccountName != null)
                    hashCode = hashCode * 59 + SessionAccessAccountName.GetHashCode();
                    if (SessionAccessAccountDomainName != null)
                    hashCode = hashCode * 59 + SessionAccessAccountDomainName.GetHashCode();
                    if (SessionAccessAccountPassword != null)
                    hashCode = hashCode * 59 + SessionAccessAccountPassword.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InitiateSessionParameters left, InitiateSessionParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InitiateSessionParameters left, InitiateSessionParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
