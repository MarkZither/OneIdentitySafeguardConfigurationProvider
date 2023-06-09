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
    /// Directory attribute mappings for users
    /// </summary>
    [DataContract]
    public partial class UserProviderSchemaProperties : IEquatable<UserProviderSchemaProperties>
    { 
        /// <summary>
        /// LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.
        /// </summary>
        /// <value>LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.</value>

        [DataMember(Name="UserClassType")]
        public List<string> UserClassType { get; set; }

        /// <summary>
        /// Name of user name schema attribute
        /// </summary>
        /// <value>Name of user name schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="UserNameAttribute")]
        public string UserNameAttribute { get; set; }

        /// <summary>
        /// Name of first name schema attribute
        /// </summary>
        /// <value>Name of first name schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="FirstNameAttribute")]
        public string FirstNameAttribute { get; set; }

        /// <summary>
        /// Name of last name schema attribute
        /// </summary>
        /// <value>Name of last name schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="LastNameAttribute")]
        public string LastNameAttribute { get; set; }

        /// <summary>
        /// Name of description schema attribute
        /// </summary>
        /// <value>Name of description schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="DescriptionAttribute")]
        public string DescriptionAttribute { get; set; }

        /// <summary>
        /// Name of mail schema attribute
        /// </summary>
        /// <value>Name of mail schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="MailAttribute")]
        public string MailAttribute { get; set; }

        /// <summary>
        /// Name of phone schema attribute
        /// </summary>
        /// <value>Name of phone schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="PhoneAttribute")]
        public string PhoneAttribute { get; set; }

        /// <summary>
        /// Name of mobile schema attribute
        /// </summary>
        /// <value>Name of mobile schema attribute</value>

        [MaxLength(255)]
        [DataMember(Name="MobileAttribute")]
        public string MobileAttribute { get; set; }

        /// <summary>
        /// Name of attribute used while adding users of a directory user group from which the imported user&#x27;s primary              authentication identity (email address or name claim) will come from when an external federation provider has been              chosen as that group&#x27;s means of authentication.
        /// </summary>
        /// <value>Name of attribute used while adding users of a directory user group from which the imported user&#x27;s primary              authentication identity (email address or name claim) will come from when an external federation provider has been              chosen as that group&#x27;s means of authentication.</value>

        [MaxLength(255)]
        [DataMember(Name="DirectoryGroupSyncAttributeForExternalFederationAuthentication")]
        public string DirectoryGroupSyncAttributeForExternalFederationAuthentication { get; set; }

        /// <summary>
        /// Name of attribute used while adding users of a directory user group from which the imported user&#x27;s primary              or secondary authentication identity will come from when a RADIUS provider has been chosen as that group&#x27;s means of              primary or secondary authentication.
        /// </summary>
        /// <value>Name of attribute used while adding users of a directory user group from which the imported user&#x27;s primary              or secondary authentication identity will come from when a RADIUS provider has been chosen as that group&#x27;s means of              primary or secondary authentication.</value>

        [MaxLength(255)]
        [DataMember(Name="DirectoryGroupSyncAttributeForRadiusAuthentication")]
        public string DirectoryGroupSyncAttributeForRadiusAuthentication { get; set; }

        /// <summary>
        /// Name of attribute used while adding users of a directory user group from which the imported user&#x27;s linked              accounts will automatically be associated to their Safeguard user.
        /// </summary>
        /// <value>Name of attribute used while adding users of a directory user group from which the imported user&#x27;s linked              accounts will automatically be associated to their Safeguard user.</value>

        [MaxLength(255)]
        [DataMember(Name="DirectoryGroupSyncAttributeForManagedObjects")]
        public string DirectoryGroupSyncAttributeForManagedObjects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProviderSchemaProperties {\n");
            sb.Append("  UserClassType: ").Append(UserClassType).Append("\n");
            sb.Append("  UserNameAttribute: ").Append(UserNameAttribute).Append("\n");
            sb.Append("  FirstNameAttribute: ").Append(FirstNameAttribute).Append("\n");
            sb.Append("  LastNameAttribute: ").Append(LastNameAttribute).Append("\n");
            sb.Append("  DescriptionAttribute: ").Append(DescriptionAttribute).Append("\n");
            sb.Append("  MailAttribute: ").Append(MailAttribute).Append("\n");
            sb.Append("  PhoneAttribute: ").Append(PhoneAttribute).Append("\n");
            sb.Append("  MobileAttribute: ").Append(MobileAttribute).Append("\n");
            sb.Append("  DirectoryGroupSyncAttributeForExternalFederationAuthentication: ").Append(DirectoryGroupSyncAttributeForExternalFederationAuthentication).Append("\n");
            sb.Append("  DirectoryGroupSyncAttributeForRadiusAuthentication: ").Append(DirectoryGroupSyncAttributeForRadiusAuthentication).Append("\n");
            sb.Append("  DirectoryGroupSyncAttributeForManagedObjects: ").Append(DirectoryGroupSyncAttributeForManagedObjects).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserProviderSchemaProperties)obj);
        }

        /// <summary>
        /// Returns true if UserProviderSchemaProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProviderSchemaProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProviderSchemaProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserClassType == other.UserClassType ||
                    UserClassType != null &&
                    UserClassType.SequenceEqual(other.UserClassType)
                ) && 
                (
                    UserNameAttribute == other.UserNameAttribute ||
                    UserNameAttribute != null &&
                    UserNameAttribute.Equals(other.UserNameAttribute)
                ) && 
                (
                    FirstNameAttribute == other.FirstNameAttribute ||
                    FirstNameAttribute != null &&
                    FirstNameAttribute.Equals(other.FirstNameAttribute)
                ) && 
                (
                    LastNameAttribute == other.LastNameAttribute ||
                    LastNameAttribute != null &&
                    LastNameAttribute.Equals(other.LastNameAttribute)
                ) && 
                (
                    DescriptionAttribute == other.DescriptionAttribute ||
                    DescriptionAttribute != null &&
                    DescriptionAttribute.Equals(other.DescriptionAttribute)
                ) && 
                (
                    MailAttribute == other.MailAttribute ||
                    MailAttribute != null &&
                    MailAttribute.Equals(other.MailAttribute)
                ) && 
                (
                    PhoneAttribute == other.PhoneAttribute ||
                    PhoneAttribute != null &&
                    PhoneAttribute.Equals(other.PhoneAttribute)
                ) && 
                (
                    MobileAttribute == other.MobileAttribute ||
                    MobileAttribute != null &&
                    MobileAttribute.Equals(other.MobileAttribute)
                ) && 
                (
                    DirectoryGroupSyncAttributeForExternalFederationAuthentication == other.DirectoryGroupSyncAttributeForExternalFederationAuthentication ||
                    DirectoryGroupSyncAttributeForExternalFederationAuthentication != null &&
                    DirectoryGroupSyncAttributeForExternalFederationAuthentication.Equals(other.DirectoryGroupSyncAttributeForExternalFederationAuthentication)
                ) && 
                (
                    DirectoryGroupSyncAttributeForRadiusAuthentication == other.DirectoryGroupSyncAttributeForRadiusAuthentication ||
                    DirectoryGroupSyncAttributeForRadiusAuthentication != null &&
                    DirectoryGroupSyncAttributeForRadiusAuthentication.Equals(other.DirectoryGroupSyncAttributeForRadiusAuthentication)
                ) && 
                (
                    DirectoryGroupSyncAttributeForManagedObjects == other.DirectoryGroupSyncAttributeForManagedObjects ||
                    DirectoryGroupSyncAttributeForManagedObjects != null &&
                    DirectoryGroupSyncAttributeForManagedObjects.Equals(other.DirectoryGroupSyncAttributeForManagedObjects)
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
                    if (UserClassType != null)
                    hashCode = hashCode * 59 + UserClassType.GetHashCode();
                    if (UserNameAttribute != null)
                    hashCode = hashCode * 59 + UserNameAttribute.GetHashCode();
                    if (FirstNameAttribute != null)
                    hashCode = hashCode * 59 + FirstNameAttribute.GetHashCode();
                    if (LastNameAttribute != null)
                    hashCode = hashCode * 59 + LastNameAttribute.GetHashCode();
                    if (DescriptionAttribute != null)
                    hashCode = hashCode * 59 + DescriptionAttribute.GetHashCode();
                    if (MailAttribute != null)
                    hashCode = hashCode * 59 + MailAttribute.GetHashCode();
                    if (PhoneAttribute != null)
                    hashCode = hashCode * 59 + PhoneAttribute.GetHashCode();
                    if (MobileAttribute != null)
                    hashCode = hashCode * 59 + MobileAttribute.GetHashCode();
                    if (DirectoryGroupSyncAttributeForExternalFederationAuthentication != null)
                    hashCode = hashCode * 59 + DirectoryGroupSyncAttributeForExternalFederationAuthentication.GetHashCode();
                    if (DirectoryGroupSyncAttributeForRadiusAuthentication != null)
                    hashCode = hashCode * 59 + DirectoryGroupSyncAttributeForRadiusAuthentication.GetHashCode();
                    if (DirectoryGroupSyncAttributeForManagedObjects != null)
                    hashCode = hashCode * 59 + DirectoryGroupSyncAttributeForManagedObjects.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserProviderSchemaProperties left, UserProviderSchemaProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserProviderSchemaProperties left, UserProviderSchemaProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
