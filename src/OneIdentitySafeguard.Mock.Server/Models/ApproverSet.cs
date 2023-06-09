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
    /// Represents a set of identities required to approve a access request for a policy
    /// </summary>
    [DataContract]
    public partial class ApproverSet : IEquatable<ApproverSet>
    { 
        /// <summary>
        /// The minimum number of approvers required by this approver set
        /// </summary>
        /// <value>The minimum number of approvers required by this approver set</value>

        [Range(1, 2147483647)]
        [DataMember(Name="RequiredApprovers")]
        public int? RequiredApprovers { get; set; }

        /// <summary>
        /// List of users that may approve to meet the required approver count
        /// </summary>
        /// <value>List of users that may approve to meet the required approver count</value>

        [DataMember(Name="Approvers")]
        public List<Approver> Approvers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApproverSet {\n");
            sb.Append("  RequiredApprovers: ").Append(RequiredApprovers).Append("\n");
            sb.Append("  Approvers: ").Append(Approvers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ApproverSet)obj);
        }

        /// <summary>
        /// Returns true if ApproverSet instances are equal
        /// </summary>
        /// <param name="other">Instance of ApproverSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApproverSet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RequiredApprovers == other.RequiredApprovers ||
                    RequiredApprovers != null &&
                    RequiredApprovers.Equals(other.RequiredApprovers)
                ) && 
                (
                    Approvers == other.Approvers ||
                    Approvers != null &&
                    Approvers.SequenceEqual(other.Approvers)
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
                    if (RequiredApprovers != null)
                    hashCode = hashCode * 59 + RequiredApprovers.GetHashCode();
                    if (Approvers != null)
                    hashCode = hashCode * 59 + Approvers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApproverSet left, ApproverSet right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApproverSet left, ApproverSet right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
