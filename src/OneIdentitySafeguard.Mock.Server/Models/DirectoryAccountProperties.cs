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
    /// Properties mapping the entity to an account in a directory
    /// </summary>
    [DataContract]
    public partial class DirectoryAccountProperties : IEquatable<DirectoryAccountProperties>
    { 
        /// <summary>
        /// Netbios name of the domain this object is from (Read-only)
        /// </summary>
        /// <value>Netbios name of the domain this object is from (Read-only)</value>

        [DataMember(Name="NetbiosName")]
        public string NetbiosName { get; set; }

        /// <summary>
        /// Unique ID of the object in the directory (Read-only)
        /// </summary>
        /// <value>Unique ID of the object in the directory (Read-only)</value>

        [DataMember(Name="ObjectGuid")]
        public string ObjectGuid { get; set; }

        /// <summary>
        /// Security ID of the object in the directory (Active Directory only) (Read-only)
        /// </summary>
        /// <value>Security ID of the object in the directory (Active Directory only) (Read-only)</value>

        [DataMember(Name="ObjectSid")]
        public string ObjectSid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectoryAccountProperties {\n");
            sb.Append("  NetbiosName: ").Append(NetbiosName).Append("\n");
            sb.Append("  ObjectGuid: ").Append(ObjectGuid).Append("\n");
            sb.Append("  ObjectSid: ").Append(ObjectSid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DirectoryAccountProperties)obj);
        }

        /// <summary>
        /// Returns true if DirectoryAccountProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DirectoryAccountProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectoryAccountProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NetbiosName == other.NetbiosName ||
                    NetbiosName != null &&
                    NetbiosName.Equals(other.NetbiosName)
                ) && 
                (
                    ObjectGuid == other.ObjectGuid ||
                    ObjectGuid != null &&
                    ObjectGuid.Equals(other.ObjectGuid)
                ) && 
                (
                    ObjectSid == other.ObjectSid ||
                    ObjectSid != null &&
                    ObjectSid.Equals(other.ObjectSid)
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
                    if (NetbiosName != null)
                    hashCode = hashCode * 59 + NetbiosName.GetHashCode();
                    if (ObjectGuid != null)
                    hashCode = hashCode * 59 + ObjectGuid.GetHashCode();
                    if (ObjectSid != null)
                    hashCode = hashCode * 59 + ObjectSid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DirectoryAccountProperties left, DirectoryAccountProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DirectoryAccountProperties left, DirectoryAccountProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
