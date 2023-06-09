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
    /// Session access configuration
    /// </summary>
    [DataContract]
    public partial class SessionProperties : IEquatable<SessionProperties>
    { 
        /// <summary>
        /// ID of the session module connection information
        /// </summary>
        /// <value>ID of the session module connection information</value>

        [DataMember(Name="SessionModuleConnectionId")]
        public int? SessionModuleConnectionId { get; set; }

        /// <summary>
        /// Reference to the session module session connection policy
        /// </summary>
        /// <value>Reference to the session module session connection policy</value>

        [DataMember(Name="SessionConnectionPolicyRef")]
        public string SessionConnectionPolicyRef { get; set; }

        /// <summary>
        /// Gets or Sets RemoteDesktopApplicationProperties
        /// </summary>

        [DataMember(Name="RemoteDesktopApplicationProperties")]
        public RemoteDesktopApplicationProperties RemoteDesktopApplicationProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionProperties {\n");
            sb.Append("  SessionModuleConnectionId: ").Append(SessionModuleConnectionId).Append("\n");
            sb.Append("  SessionConnectionPolicyRef: ").Append(SessionConnectionPolicyRef).Append("\n");
            sb.Append("  RemoteDesktopApplicationProperties: ").Append(RemoteDesktopApplicationProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SessionProperties)obj);
        }

        /// <summary>
        /// Returns true if SessionProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SessionModuleConnectionId == other.SessionModuleConnectionId ||
                    SessionModuleConnectionId != null &&
                    SessionModuleConnectionId.Equals(other.SessionModuleConnectionId)
                ) && 
                (
                    SessionConnectionPolicyRef == other.SessionConnectionPolicyRef ||
                    SessionConnectionPolicyRef != null &&
                    SessionConnectionPolicyRef.Equals(other.SessionConnectionPolicyRef)
                ) && 
                (
                    RemoteDesktopApplicationProperties == other.RemoteDesktopApplicationProperties ||
                    RemoteDesktopApplicationProperties != null &&
                    RemoteDesktopApplicationProperties.Equals(other.RemoteDesktopApplicationProperties)
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
                    if (SessionModuleConnectionId != null)
                    hashCode = hashCode * 59 + SessionModuleConnectionId.GetHashCode();
                    if (SessionConnectionPolicyRef != null)
                    hashCode = hashCode * 59 + SessionConnectionPolicyRef.GetHashCode();
                    if (RemoteDesktopApplicationProperties != null)
                    hashCode = hashCode * 59 + RemoteDesktopApplicationProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SessionProperties left, SessionProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SessionProperties left, SessionProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
