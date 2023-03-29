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
    /// 
    /// </summary>
    [DataContract]
    public partial class TaggingGroupingConditionGroup : IEquatable<TaggingGroupingConditionGroup>
    { 
        /// <summary>
        /// Gets or Sets LogicalJoinType
        /// </summary>

        [DataMember(Name="LogicalJoinType")]
        public ConditionJoinType LogicalJoinType { get; set; }

        /// <summary>
        /// The children of this group.
        /// </summary>
        /// <value>The children of this group.</value>
        [Required]

        [DataMember(Name="Children")]
        public List<TaggingGroupingConditionOrConditionGroup> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaggingGroupingConditionGroup {\n");
            sb.Append("  LogicalJoinType: ").Append(LogicalJoinType).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TaggingGroupingConditionGroup)obj);
        }

        /// <summary>
        /// Returns true if TaggingGroupingConditionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of TaggingGroupingConditionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaggingGroupingConditionGroup other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LogicalJoinType == other.LogicalJoinType ||
                    LogicalJoinType != null &&
                    LogicalJoinType.Equals(other.LogicalJoinType)
                ) && 
                (
                    Children == other.Children ||
                    Children != null &&
                    Children.SequenceEqual(other.Children)
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
                    if (LogicalJoinType != null)
                    hashCode = hashCode * 59 + LogicalJoinType.GetHashCode();
                    if (Children != null)
                    hashCode = hashCode * 59 + Children.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TaggingGroupingConditionGroup left, TaggingGroupingConditionGroup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TaggingGroupingConditionGroup left, TaggingGroupingConditionGroup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}