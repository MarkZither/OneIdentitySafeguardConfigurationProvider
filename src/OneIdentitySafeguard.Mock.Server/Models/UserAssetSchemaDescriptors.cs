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
    /// Descriptors for user schema properties
    /// </summary>
    [DataContract]
    public partial class UserAssetSchemaDescriptors : IEquatable<UserAssetSchemaDescriptors>
    { 
        /// <summary>
        /// Gets or Sets UserClassTypeDescriptor
        /// </summary>

        [DataMember(Name="UserClassTypeDescriptor")]
        public SchemaDescriptor UserClassTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets UserNameAttributeDescriptor
        /// </summary>

        [DataMember(Name="UserNameAttributeDescriptor")]
        public SchemaDescriptor UserNameAttributeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets PasswordAttributeDescriptor
        /// </summary>

        [DataMember(Name="PasswordAttributeDescriptor")]
        public SchemaDescriptor PasswordAttributeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionAttributeDescriptor
        /// </summary>

        [DataMember(Name="DescriptionAttributeDescriptor")]
        public SchemaDescriptor DescriptionAttributeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets MemberOfAttributeDescriptor
        /// </summary>

        [DataMember(Name="MemberOfAttributeDescriptor")]
        public SchemaDescriptor MemberOfAttributeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets AltLoginNameAttributeDescriptor
        /// </summary>

        [DataMember(Name="AltLoginNameAttributeDescriptor")]
        public SchemaDescriptor AltLoginNameAttributeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAssetSchemaDescriptors {\n");
            sb.Append("  UserClassTypeDescriptor: ").Append(UserClassTypeDescriptor).Append("\n");
            sb.Append("  UserNameAttributeDescriptor: ").Append(UserNameAttributeDescriptor).Append("\n");
            sb.Append("  PasswordAttributeDescriptor: ").Append(PasswordAttributeDescriptor).Append("\n");
            sb.Append("  DescriptionAttributeDescriptor: ").Append(DescriptionAttributeDescriptor).Append("\n");
            sb.Append("  MemberOfAttributeDescriptor: ").Append(MemberOfAttributeDescriptor).Append("\n");
            sb.Append("  AltLoginNameAttributeDescriptor: ").Append(AltLoginNameAttributeDescriptor).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserAssetSchemaDescriptors)obj);
        }

        /// <summary>
        /// Returns true if UserAssetSchemaDescriptors instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAssetSchemaDescriptors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAssetSchemaDescriptors other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserClassTypeDescriptor == other.UserClassTypeDescriptor ||
                    UserClassTypeDescriptor != null &&
                    UserClassTypeDescriptor.Equals(other.UserClassTypeDescriptor)
                ) && 
                (
                    UserNameAttributeDescriptor == other.UserNameAttributeDescriptor ||
                    UserNameAttributeDescriptor != null &&
                    UserNameAttributeDescriptor.Equals(other.UserNameAttributeDescriptor)
                ) && 
                (
                    PasswordAttributeDescriptor == other.PasswordAttributeDescriptor ||
                    PasswordAttributeDescriptor != null &&
                    PasswordAttributeDescriptor.Equals(other.PasswordAttributeDescriptor)
                ) && 
                (
                    DescriptionAttributeDescriptor == other.DescriptionAttributeDescriptor ||
                    DescriptionAttributeDescriptor != null &&
                    DescriptionAttributeDescriptor.Equals(other.DescriptionAttributeDescriptor)
                ) && 
                (
                    MemberOfAttributeDescriptor == other.MemberOfAttributeDescriptor ||
                    MemberOfAttributeDescriptor != null &&
                    MemberOfAttributeDescriptor.Equals(other.MemberOfAttributeDescriptor)
                ) && 
                (
                    AltLoginNameAttributeDescriptor == other.AltLoginNameAttributeDescriptor ||
                    AltLoginNameAttributeDescriptor != null &&
                    AltLoginNameAttributeDescriptor.Equals(other.AltLoginNameAttributeDescriptor)
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
                    if (UserClassTypeDescriptor != null)
                    hashCode = hashCode * 59 + UserClassTypeDescriptor.GetHashCode();
                    if (UserNameAttributeDescriptor != null)
                    hashCode = hashCode * 59 + UserNameAttributeDescriptor.GetHashCode();
                    if (PasswordAttributeDescriptor != null)
                    hashCode = hashCode * 59 + PasswordAttributeDescriptor.GetHashCode();
                    if (DescriptionAttributeDescriptor != null)
                    hashCode = hashCode * 59 + DescriptionAttributeDescriptor.GetHashCode();
                    if (MemberOfAttributeDescriptor != null)
                    hashCode = hashCode * 59 + MemberOfAttributeDescriptor.GetHashCode();
                    if (AltLoginNameAttributeDescriptor != null)
                    hashCode = hashCode * 59 + AltLoginNameAttributeDescriptor.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserAssetSchemaDescriptors left, UserAssetSchemaDescriptors right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserAssetSchemaDescriptors left, UserAssetSchemaDescriptors right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}