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
    /// Represents requestable items governed by policy
    /// </summary>
    [DataContract]
    public partial class PolicyScopeItem : IEquatable<PolicyScopeItem>
    { 
        /// <summary>
        /// Database Id of the scope item
        /// </summary>
        /// <value>Database Id of the scope item</value>
        [Required]

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// DisplayName of the scope item (Read-only)
        /// </summary>
        /// <value>DisplayName of the scope item (Read-only)</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the scope item (Read-only)
        /// </summary>
        /// <value>Description of the scope item (Read-only)</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ScopeItemType
        /// </summary>
        [Required]

        [DataMember(Name="ScopeItemType")]
        public PolicyScopeItemType ScopeItemType { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>

        [DataMember(Name="Account")]
        public PolicyAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>

        [DataMember(Name="Asset")]
        public PolicyAsset Asset { get; set; }

        /// <summary>
        /// Gets or Sets AccountGroup
        /// </summary>

        [DataMember(Name="AccountGroup")]
        public AccountGroup AccountGroup { get; set; }

        /// <summary>
        /// Gets or Sets AssetGroup
        /// </summary>

        [DataMember(Name="AssetGroup")]
        public AssetGroup AssetGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyScopeItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ScopeItemType: ").Append(ScopeItemType).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  AssetGroup: ").Append(AssetGroup).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PolicyScopeItem)obj);
        }

        /// <summary>
        /// Returns true if PolicyScopeItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyScopeItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyScopeItem other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ScopeItemType == other.ScopeItemType ||
                    ScopeItemType != null &&
                    ScopeItemType.Equals(other.ScopeItemType)
                ) && 
                (
                    Account == other.Account ||
                    Account != null &&
                    Account.Equals(other.Account)
                ) && 
                (
                    Asset == other.Asset ||
                    Asset != null &&
                    Asset.Equals(other.Asset)
                ) && 
                (
                    AccountGroup == other.AccountGroup ||
                    AccountGroup != null &&
                    AccountGroup.Equals(other.AccountGroup)
                ) && 
                (
                    AssetGroup == other.AssetGroup ||
                    AssetGroup != null &&
                    AssetGroup.Equals(other.AssetGroup)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ScopeItemType != null)
                    hashCode = hashCode * 59 + ScopeItemType.GetHashCode();
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (Asset != null)
                    hashCode = hashCode * 59 + Asset.GetHashCode();
                    if (AccountGroup != null)
                    hashCode = hashCode * 59 + AccountGroup.GetHashCode();
                    if (AssetGroup != null)
                    hashCode = hashCode * 59 + AssetGroup.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PolicyScopeItem left, PolicyScopeItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PolicyScopeItem left, PolicyScopeItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}