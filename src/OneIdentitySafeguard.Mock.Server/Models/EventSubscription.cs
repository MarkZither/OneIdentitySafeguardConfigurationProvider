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
    public partial class EventSubscription : IEquatable<EventSubscription>
    { 
        /// <summary>
        /// Does the event support the ActivityLog? (Read-only)
        /// </summary>
        /// <value>Does the event support the ActivityLog? (Read-only)</value>

        [DataMember(Name="ActivityLogFlag")]
        public bool? ActivityLogFlag { get; set; }

        /// <summary>
        /// Does the event support async broadcast notification to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncMcastFlag
        /// </summary>
        /// <value>Does the event support async broadcast notification to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncMcastFlag</value>

        [DataMember(Name="AsyncBroadcastFlag")]
        public bool? AsyncBroadcastFlag { get; set; }

        /// <summary>
        /// Does the event support async multicast notifications to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncBcastFlag
        /// </summary>
        /// <value>Does the event support async multicast notifications to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncBcastFlag</value>

        [DataMember(Name="AsyncMulticastFlag")]
        public bool? AsyncMulticastFlag { get; set; }

        /// <summary>
        /// Does the event support async unicast notification to connected users? (Read-only) Mutually exclusive with  AsyncBcastFlag and AsyncMcastFlag
        /// </summary>
        /// <value>Does the event support async unicast notification to connected users? (Read-only) Mutually exclusive with  AsyncBcastFlag and AsyncMcastFlag</value>

        [DataMember(Name="AsyncUnicastFlag")]
        public bool? AsyncUnicastFlag { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>

        [DataMember(Name="Category")]
        public EventCategory Category { get; set; }

        /// <summary>
        /// Display name of the event (Read-only)
        /// </summary>
        /// <value>Display name of the event (Read-only)</value>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Category displayname of the event (Read-only)
        /// </summary>
        /// <value>Category displayname of the event (Read-only)</value>

        [DataMember(Name="CategoryDisplayName")]
        public string CategoryDisplayName { get; set; }

        /// <summary>
        /// Brief description of the event (Read-only)
        /// </summary>
        /// <value>Brief description of the event (Read-only)</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Does the event support email notification? (Read-only)
        /// </summary>
        /// <value>Does the event support email notification? (Read-only)</value>

        [DataMember(Name="EmailFlag")]
        public bool? EmailFlag { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>

        [DataMember(Name="Level")]
        public EventLevel Level { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]

        [DataMember(Name="Name")]
        public EventName Name { get; set; }

        /// <summary>
        /// Is this event obsolete? (Read-only)
        /// </summary>
        /// <value>Is this event obsolete? (Read-only)</value>

        [DataMember(Name="Obsolete")]
        public bool? Obsolete { get; set; }

        /// <summary>
        /// Does the event support SNMP trap notification? (Read-only)
        /// </summary>
        /// <value>Does the event support SNMP trap notification? (Read-only)</value>

        [DataMember(Name="SnmpFlag")]
        public bool? SnmpFlag { get; set; }

        /// <summary>
        /// Does the event support syslog logging? (Read-only)
        /// </summary>
        /// <value>Does the event support syslog logging? (Read-only)</value>

        [DataMember(Name="SyslogFlag")]
        public bool? SyslogFlag { get; set; }

        /// <summary>
        /// Whether this event supports object specific subscriptions (Read-only)
        /// </summary>
        /// <value>Whether this event supports object specific subscriptions (Read-only)</value>

        [DataMember(Name="IsObjectAware")]
        public bool? IsObjectAware { get; set; }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>

        [DataMember(Name="ObjectType")]
        public EventObjectType ObjectType { get; set; }

        /// <summary>
        /// Which admin roles can subscribe to this event (Read-only)
        /// </summary>
        /// <value>Which admin roles can subscribe to this event (Read-only)</value>

        [DataMember(Name="AllowedAdminRoles")]
        public List<AdminRoleName> AllowedAdminRoles { get; set; }

        /// <summary>
        /// Whether a partition owner can subscribe to this event (Read-only)
        /// </summary>
        /// <value>Whether a partition owner can subscribe to this event (Read-only)</value>

        [DataMember(Name="AllowPartitionOwner")]
        public bool? AllowPartitionOwner { get; set; }

        /// <summary>
        /// List of event data properties (Read-only)
        /// </summary>
        /// <value>List of event data properties (Read-only)</value>

        [DataMember(Name="Properties")]
        public List<EventProperty> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSubscription {\n");
            sb.Append("  ActivityLogFlag: ").Append(ActivityLogFlag).Append("\n");
            sb.Append("  AsyncBroadcastFlag: ").Append(AsyncBroadcastFlag).Append("\n");
            sb.Append("  AsyncMulticastFlag: ").Append(AsyncMulticastFlag).Append("\n");
            sb.Append("  AsyncUnicastFlag: ").Append(AsyncUnicastFlag).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CategoryDisplayName: ").Append(CategoryDisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmailFlag: ").Append(EmailFlag).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Obsolete: ").Append(Obsolete).Append("\n");
            sb.Append("  SnmpFlag: ").Append(SnmpFlag).Append("\n");
            sb.Append("  SyslogFlag: ").Append(SyslogFlag).Append("\n");
            sb.Append("  IsObjectAware: ").Append(IsObjectAware).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  AllowedAdminRoles: ").Append(AllowedAdminRoles).Append("\n");
            sb.Append("  AllowPartitionOwner: ").Append(AllowPartitionOwner).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EventSubscription)obj);
        }

        /// <summary>
        /// Returns true if EventSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of EventSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventSubscription other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ActivityLogFlag == other.ActivityLogFlag ||
                    ActivityLogFlag != null &&
                    ActivityLogFlag.Equals(other.ActivityLogFlag)
                ) && 
                (
                    AsyncBroadcastFlag == other.AsyncBroadcastFlag ||
                    AsyncBroadcastFlag != null &&
                    AsyncBroadcastFlag.Equals(other.AsyncBroadcastFlag)
                ) && 
                (
                    AsyncMulticastFlag == other.AsyncMulticastFlag ||
                    AsyncMulticastFlag != null &&
                    AsyncMulticastFlag.Equals(other.AsyncMulticastFlag)
                ) && 
                (
                    AsyncUnicastFlag == other.AsyncUnicastFlag ||
                    AsyncUnicastFlag != null &&
                    AsyncUnicastFlag.Equals(other.AsyncUnicastFlag)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    CategoryDisplayName == other.CategoryDisplayName ||
                    CategoryDisplayName != null &&
                    CategoryDisplayName.Equals(other.CategoryDisplayName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    EmailFlag == other.EmailFlag ||
                    EmailFlag != null &&
                    EmailFlag.Equals(other.EmailFlag)
                ) && 
                (
                    Level == other.Level ||
                    Level != null &&
                    Level.Equals(other.Level)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Obsolete == other.Obsolete ||
                    Obsolete != null &&
                    Obsolete.Equals(other.Obsolete)
                ) && 
                (
                    SnmpFlag == other.SnmpFlag ||
                    SnmpFlag != null &&
                    SnmpFlag.Equals(other.SnmpFlag)
                ) && 
                (
                    SyslogFlag == other.SyslogFlag ||
                    SyslogFlag != null &&
                    SyslogFlag.Equals(other.SyslogFlag)
                ) && 
                (
                    IsObjectAware == other.IsObjectAware ||
                    IsObjectAware != null &&
                    IsObjectAware.Equals(other.IsObjectAware)
                ) && 
                (
                    ObjectType == other.ObjectType ||
                    ObjectType != null &&
                    ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    AllowedAdminRoles == other.AllowedAdminRoles ||
                    AllowedAdminRoles != null &&
                    AllowedAdminRoles.SequenceEqual(other.AllowedAdminRoles)
                ) && 
                (
                    AllowPartitionOwner == other.AllowPartitionOwner ||
                    AllowPartitionOwner != null &&
                    AllowPartitionOwner.Equals(other.AllowPartitionOwner)
                ) && 
                (
                    Properties == other.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(other.Properties)
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
                    if (ActivityLogFlag != null)
                    hashCode = hashCode * 59 + ActivityLogFlag.GetHashCode();
                    if (AsyncBroadcastFlag != null)
                    hashCode = hashCode * 59 + AsyncBroadcastFlag.GetHashCode();
                    if (AsyncMulticastFlag != null)
                    hashCode = hashCode * 59 + AsyncMulticastFlag.GetHashCode();
                    if (AsyncUnicastFlag != null)
                    hashCode = hashCode * 59 + AsyncUnicastFlag.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (CategoryDisplayName != null)
                    hashCode = hashCode * 59 + CategoryDisplayName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (EmailFlag != null)
                    hashCode = hashCode * 59 + EmailFlag.GetHashCode();
                    if (Level != null)
                    hashCode = hashCode * 59 + Level.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Obsolete != null)
                    hashCode = hashCode * 59 + Obsolete.GetHashCode();
                    if (SnmpFlag != null)
                    hashCode = hashCode * 59 + SnmpFlag.GetHashCode();
                    if (SyslogFlag != null)
                    hashCode = hashCode * 59 + SyslogFlag.GetHashCode();
                    if (IsObjectAware != null)
                    hashCode = hashCode * 59 + IsObjectAware.GetHashCode();
                    if (ObjectType != null)
                    hashCode = hashCode * 59 + ObjectType.GetHashCode();
                    if (AllowedAdminRoles != null)
                    hashCode = hashCode * 59 + AllowedAdminRoles.GetHashCode();
                    if (AllowPartitionOwner != null)
                    hashCode = hashCode * 59 + AllowPartitionOwner.GetHashCode();
                    if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EventSubscription left, EventSubscription right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventSubscription left, EventSubscription right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
