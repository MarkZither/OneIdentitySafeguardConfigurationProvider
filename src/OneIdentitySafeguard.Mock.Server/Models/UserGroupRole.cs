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
    /// Represents a role that a group belongs to
    /// </summary>
    [DataContract]
    public partial class UserGroupRole : IEquatable<UserGroupRole>
    { 
        /// <summary>
        /// Database ID of the role
        /// </summary>
        /// <value>Database ID of the role</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        /// <value>Name of the role</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of accounts managed by the role
        /// </summary>
        /// <value>Number of accounts managed by the role</value>

        [DataMember(Name="AccountCount")]
        public int? AccountCount { get; set; }

        /// <summary>
        /// Number of users that are members of the role
        /// </summary>
        /// <value>Number of users that are members of the role</value>

        [DataMember(Name="UserCount")]
        public int? UserCount { get; set; }

        /// <summary>
        /// Number of policies assigned to the role
        /// </summary>
        /// <value>Number of policies assigned to the role</value>

        [DataMember(Name="PolicyCount")]
        public int? PolicyCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountCount: ").Append(AccountCount).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  PolicyCount: ").Append(PolicyCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserGroupRole)obj);
        }

        /// <summary>
        /// Returns true if UserGroupRole instances are equal
        /// </summary>
        /// <param name="other">Instance of UserGroupRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGroupRole other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    AccountCount == other.AccountCount ||
                    AccountCount != null &&
                    AccountCount.Equals(other.AccountCount)
                ) && 
                (
                    UserCount == other.UserCount ||
                    UserCount != null &&
                    UserCount.Equals(other.UserCount)
                ) && 
                (
                    PolicyCount == other.PolicyCount ||
                    PolicyCount != null &&
                    PolicyCount.Equals(other.PolicyCount)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AccountCount != null)
                    hashCode = hashCode * 59 + AccountCount.GetHashCode();
                    if (UserCount != null)
                    hashCode = hashCode * 59 + UserCount.GetHashCode();
                    if (PolicyCount != null)
                    hashCode = hashCode * 59 + PolicyCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserGroupRole left, UserGroupRole right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserGroupRole left, UserGroupRole right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}