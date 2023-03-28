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
    /// Directory attribute mappings for groups
    /// </summary>
    [DataContract]
    public partial class GroupSchemaProperties : IEquatable<GroupSchemaProperties>
    { 
        /// <summary>
        /// LDAP objects that have all of the specified objectClass types will be treated as groups.  These objectClass types will also be used to validate the attributes mapped to group properties.
        /// </summary>
        /// <value>LDAP objects that have all of the specified objectClass types will be treated as groups.  These objectClass types will also be used to validate the attributes mapped to group properties.</value>

        [DataMember(Name="GroupClassType")]
        public List<string> GroupClassType { get; set; }

        /// <summary>
        /// Name of group name schema attribute
        /// </summary>
        /// <value>Name of group name schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="MemberAttribute")]
        public string MemberAttribute { get; set; }

        /// <summary>
        /// Name of group name schema attribute (
        /// </summary>
        /// <value>Name of group name schema attribute (</value>

        [MaxLength(255)]
        [DataMember(Name="NameAttribute")]
        public string NameAttribute { get; set; }

        /// <summary>
        /// Name of description schema attribute
        /// </summary>
        /// <value>Name of description schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="DescriptionAttribute")]
        public string DescriptionAttribute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSchemaProperties {\n");
            sb.Append("  GroupClassType: ").Append(GroupClassType).Append("\n");
            sb.Append("  MemberAttribute: ").Append(MemberAttribute).Append("\n");
            sb.Append("  NameAttribute: ").Append(NameAttribute).Append("\n");
            sb.Append("  DescriptionAttribute: ").Append(DescriptionAttribute).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GroupSchemaProperties)obj);
        }

        /// <summary>
        /// Returns true if GroupSchemaProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupSchemaProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSchemaProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GroupClassType == other.GroupClassType ||
                    GroupClassType != null &&
                    GroupClassType.SequenceEqual(other.GroupClassType)
                ) && 
                (
                    MemberAttribute == other.MemberAttribute ||
                    MemberAttribute != null &&
                    MemberAttribute.Equals(other.MemberAttribute)
                ) && 
                (
                    NameAttribute == other.NameAttribute ||
                    NameAttribute != null &&
                    NameAttribute.Equals(other.NameAttribute)
                ) && 
                (
                    DescriptionAttribute == other.DescriptionAttribute ||
                    DescriptionAttribute != null &&
                    DescriptionAttribute.Equals(other.DescriptionAttribute)
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
                    if (GroupClassType != null)
                    hashCode = hashCode * 59 + GroupClassType.GetHashCode();
                    if (MemberAttribute != null)
                    hashCode = hashCode * 59 + MemberAttribute.GetHashCode();
                    if (NameAttribute != null)
                    hashCode = hashCode * 59 + NameAttribute.GetHashCode();
                    if (DescriptionAttribute != null)
                    hashCode = hashCode * 59 + DescriptionAttribute.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GroupSchemaProperties left, GroupSchemaProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GroupSchemaProperties left, GroupSchemaProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
