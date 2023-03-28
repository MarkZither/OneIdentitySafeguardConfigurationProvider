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
    public partial class TaggingGroupingConditionOrConditionGroup : IEquatable<TaggingGroupingConditionOrConditionGroup>
    { 
        /// <summary>
        /// Gets or Sets TaggingGroupingCondition
        /// </summary>

        [DataMember(Name="TaggingGroupingCondition")]
        public TaggingGroupingCondition TaggingGroupingCondition { get; set; }

        /// <summary>
        /// Gets or Sets TaggingGroupingConditionGroup
        /// </summary>

        [DataMember(Name="TaggingGroupingConditionGroup")]
        public TaggingGroupingConditionGroup TaggingGroupingConditionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaggingGroupingConditionOrConditionGroup {\n");
            sb.Append("  TaggingGroupingCondition: ").Append(TaggingGroupingCondition).Append("\n");
            sb.Append("  TaggingGroupingConditionGroup: ").Append(TaggingGroupingConditionGroup).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TaggingGroupingConditionOrConditionGroup)obj);
        }

        /// <summary>
        /// Returns true if TaggingGroupingConditionOrConditionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of TaggingGroupingConditionOrConditionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaggingGroupingConditionOrConditionGroup other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TaggingGroupingCondition == other.TaggingGroupingCondition ||
                    TaggingGroupingCondition != null &&
                    TaggingGroupingCondition.Equals(other.TaggingGroupingCondition)
                ) && 
                (
                    TaggingGroupingConditionGroup == other.TaggingGroupingConditionGroup ||
                    TaggingGroupingConditionGroup != null &&
                    TaggingGroupingConditionGroup.Equals(other.TaggingGroupingConditionGroup)
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
                    if (TaggingGroupingCondition != null)
                    hashCode = hashCode * 59 + TaggingGroupingCondition.GetHashCode();
                    if (TaggingGroupingConditionGroup != null)
                    hashCode = hashCode * 59 + TaggingGroupingConditionGroup.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TaggingGroupingConditionOrConditionGroup left, TaggingGroupingConditionOrConditionGroup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TaggingGroupingConditionOrConditionGroup left, TaggingGroupingConditionOrConditionGroup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
