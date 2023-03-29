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
    /// An account discovered as part of an account discovery task
    /// </summary>
    [DataContract]
    public partial class DiscoveredAccountLog : IEquatable<DiscoveredAccountLog>
    { 
        /// <summary>
        /// Name of the discovered account
        /// </summary>
        /// <value>Name of the discovered account</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Discovered ID of the account
        /// </summary>
        /// <value>Discovered ID of the account</value>

        [DataMember(Name="DiscoveredUserId")]
        public string DiscoveredUserId { get; set; }

        /// <summary>
        /// Domain name of the discovered account
        /// </summary>
        /// <value>Domain name of the discovered account</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name="Status")]
        public DiscoveredAccountStatus Status { get; set; }

        /// <summary>
        /// Discovered groups of the account
        /// </summary>
        /// <value>Discovered groups of the account</value>

        [DataMember(Name="DiscoveredGroups")]
        public List<DiscoveredGroupLog> DiscoveredGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveredAccountLog {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DiscoveredGroups: ").Append(DiscoveredGroups).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DiscoveredAccountLog)obj);
        }

        /// <summary>
        /// Returns true if DiscoveredAccountLog instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscoveredAccountLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveredAccountLog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DiscoveredUserId == other.DiscoveredUserId ||
                    DiscoveredUserId != null &&
                    DiscoveredUserId.Equals(other.DiscoveredUserId)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    DiscoveredGroups == other.DiscoveredGroups ||
                    DiscoveredGroups != null &&
                    DiscoveredGroups.SequenceEqual(other.DiscoveredGroups)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (DiscoveredUserId != null)
                    hashCode = hashCode * 59 + DiscoveredUserId.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (DiscoveredGroups != null)
                    hashCode = hashCode * 59 + DiscoveredGroups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DiscoveredAccountLog left, DiscoveredAccountLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiscoveredAccountLog left, DiscoveredAccountLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}