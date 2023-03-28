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
    /// Represents a single event change on the server
    /// </summary>
    [DataContract]
    public partial class ObjectChangeLog : IEquatable<ObjectChangeLog>
    { 
        /// <summary>
        /// Database ID of this log entry
        /// </summary>
        /// <value>Database ID of this log entry</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Time the change occurred (Read-only)
        /// </summary>
        /// <value>Time the change occurred (Read-only)</value>

        [DataMember(Name="LogTime")]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// Unique id of the user that caused the change (Read-only).
        /// </summary>
        /// <value>Unique id of the user that caused the change (Read-only).</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Id of appliance
        /// </summary>
        /// <value>Id of appliance</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Name of appliance
        /// </summary>
        /// <value>Name of appliance</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>

        [DataMember(Name="OperationType")]
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// The event display name that caused the change (Read-only)
        /// </summary>
        /// <value>The event display name that caused the change (Read-only)</value>

        [DataMember(Name="EventDisplayName")]
        public string EventDisplayName { get; set; }

        /// <summary>
        /// Extra info clarifying the event (Read-only)
        /// </summary>
        /// <value>Extra info clarifying the event (Read-only)</value>

        [DataMember(Name="Message")]
        public string Message { get; set; }

        /// <summary>
        /// The database ID of the object that was changed (Read-only).
        /// </summary>
        /// <value>The database ID of the object that was changed (Read-only).</value>

        [DataMember(Name="ObjectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>

        [DataMember(Name="ObjectType")]
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// The name of the object that was changed (Read-only).
        /// </summary>
        /// <value>The name of the object that was changed (Read-only).</value>

        [DataMember(Name="ObjectName")]
        public string ObjectName { get; set; }

        /// <summary>
        /// Gets or Sets ParentObjectType
        /// </summary>

        [DataMember(Name="ParentObjectType")]
        public ObjectType ParentObjectType { get; set; }

        /// <summary>
        /// The database ID of the parent of the object that was changed (Read-only).
        /// </summary>
        /// <value>The database ID of the parent of the object that was changed (Read-only).</value>

        [DataMember(Name="ParentObjectId")]
        public string ParentObjectId { get; set; }

        /// <summary>
        /// The name of the parent of the object that was changed (Read-only).
        /// </summary>
        /// <value>The name of the parent of the object that was changed (Read-only).</value>

        [DataMember(Name="ParentObjectName")]
        public string ParentObjectName { get; set; }

        /// <summary>
        /// Gets or Sets RelatedObjectType
        /// </summary>

        [DataMember(Name="RelatedObjectType")]
        public ObjectType RelatedObjectType { get; set; }

        /// <summary>
        /// The database ID of the object relating to this change (Read-only).
        /// </summary>
        /// <value>The database ID of the object relating to this change (Read-only).</value>

        [DataMember(Name="RelatedObjectId")]
        public string RelatedObjectId { get; set; }

        /// <summary>
        /// The name of the object relating to this change (Read-only).
        /// </summary>
        /// <value>The name of the object relating to this change (Read-only).</value>

        [DataMember(Name="RelatedObjectName")]
        public string RelatedObjectName { get; set; }

        /// <summary>
        /// The original JSON-encoded entity values (Read-only).
        /// </summary>
        /// <value>The original JSON-encoded entity values (Read-only).</value>

        [DataMember(Name="OldValue")]
        public string OldValue { get; set; }

        /// <summary>
        /// The new JSON-encoded entity values (Read-only).
        /// </summary>
        /// <value>The new JSON-encoded entity values (Read-only).</value>

        [DataMember(Name="NewValue")]
        public string NewValue { get; set; }

        /// <summary>
        /// The database ID of the related asset partition (Read-only).
        /// </summary>
        /// <value>The database ID of the related asset partition (Read-only).</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// The name of the related asset partition (Read-only).
        /// </summary>
        /// <value>The name of the related asset partition (Read-only).</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// The network address of the related asset (Read-only).
        /// </summary>
        /// <value>The network address of the related asset (Read-only).</value>

        [DataMember(Name="AssetNetworkAddress")]
        public string AssetNetworkAddress { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

        /// <summary>
        /// Changes made to the object for this entry
        /// </summary>
        /// <value>Changes made to the object for this entry</value>

        [DataMember(Name="Changes")]
        public List<PropertyChange> Changes { get; set; }

        /// <summary>
        /// Gets or Sets SessionSpsNodeIpAddress
        /// </summary>

        [DataMember(Name="SessionSpsNodeIpAddress")]
        public string SessionSpsNodeIpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectChangeLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
            sb.Append("  ParentObjectType: ").Append(ParentObjectType).Append("\n");
            sb.Append("  ParentObjectId: ").Append(ParentObjectId).Append("\n");
            sb.Append("  ParentObjectName: ").Append(ParentObjectName).Append("\n");
            sb.Append("  RelatedObjectType: ").Append(RelatedObjectType).Append("\n");
            sb.Append("  RelatedObjectId: ").Append(RelatedObjectId).Append("\n");
            sb.Append("  RelatedObjectName: ").Append(RelatedObjectName).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  SessionSpsNodeIpAddress: ").Append(SessionSpsNodeIpAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ObjectChangeLog)obj);
        }

        /// <summary>
        /// Returns true if ObjectChangeLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectChangeLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectChangeLog other)
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
                    LogTime == other.LogTime ||
                    LogTime != null &&
                    LogTime.Equals(other.LogTime)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    ApplianceName == other.ApplianceName ||
                    ApplianceName != null &&
                    ApplianceName.Equals(other.ApplianceName)
                ) && 
                (
                    OperationType == other.OperationType ||
                    OperationType != null &&
                    OperationType.Equals(other.OperationType)
                ) && 
                (
                    EventName == other.EventName ||
                    EventName != null &&
                    EventName.Equals(other.EventName)
                ) && 
                (
                    EventDisplayName == other.EventDisplayName ||
                    EventDisplayName != null &&
                    EventDisplayName.Equals(other.EventDisplayName)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    ObjectId == other.ObjectId ||
                    ObjectId != null &&
                    ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    ObjectType == other.ObjectType ||
                    ObjectType != null &&
                    ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    ObjectName == other.ObjectName ||
                    ObjectName != null &&
                    ObjectName.Equals(other.ObjectName)
                ) && 
                (
                    ParentObjectType == other.ParentObjectType ||
                    ParentObjectType != null &&
                    ParentObjectType.Equals(other.ParentObjectType)
                ) && 
                (
                    ParentObjectId == other.ParentObjectId ||
                    ParentObjectId != null &&
                    ParentObjectId.Equals(other.ParentObjectId)
                ) && 
                (
                    ParentObjectName == other.ParentObjectName ||
                    ParentObjectName != null &&
                    ParentObjectName.Equals(other.ParentObjectName)
                ) && 
                (
                    RelatedObjectType == other.RelatedObjectType ||
                    RelatedObjectType != null &&
                    RelatedObjectType.Equals(other.RelatedObjectType)
                ) && 
                (
                    RelatedObjectId == other.RelatedObjectId ||
                    RelatedObjectId != null &&
                    RelatedObjectId.Equals(other.RelatedObjectId)
                ) && 
                (
                    RelatedObjectName == other.RelatedObjectName ||
                    RelatedObjectName != null &&
                    RelatedObjectName.Equals(other.RelatedObjectName)
                ) && 
                (
                    OldValue == other.OldValue ||
                    OldValue != null &&
                    OldValue.Equals(other.OldValue)
                ) && 
                (
                    NewValue == other.NewValue ||
                    NewValue != null &&
                    NewValue.Equals(other.NewValue)
                ) && 
                (
                    AssetPartitionId == other.AssetPartitionId ||
                    AssetPartitionId != null &&
                    AssetPartitionId.Equals(other.AssetPartitionId)
                ) && 
                (
                    AssetPartitionName == other.AssetPartitionName ||
                    AssetPartitionName != null &&
                    AssetPartitionName.Equals(other.AssetPartitionName)
                ) && 
                (
                    AssetNetworkAddress == other.AssetNetworkAddress ||
                    AssetNetworkAddress != null &&
                    AssetNetworkAddress.Equals(other.AssetNetworkAddress)
                ) && 
                (
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
                ) && 
                (
                    Changes == other.Changes ||
                    Changes != null &&
                    Changes.SequenceEqual(other.Changes)
                ) && 
                (
                    SessionSpsNodeIpAddress == other.SessionSpsNodeIpAddress ||
                    SessionSpsNodeIpAddress != null &&
                    SessionSpsNodeIpAddress.Equals(other.SessionSpsNodeIpAddress)
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
                    if (LogTime != null)
                    hashCode = hashCode * 59 + LogTime.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (OperationType != null)
                    hashCode = hashCode * 59 + OperationType.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (ObjectId != null)
                    hashCode = hashCode * 59 + ObjectId.GetHashCode();
                    if (ObjectType != null)
                    hashCode = hashCode * 59 + ObjectType.GetHashCode();
                    if (ObjectName != null)
                    hashCode = hashCode * 59 + ObjectName.GetHashCode();
                    if (ParentObjectType != null)
                    hashCode = hashCode * 59 + ParentObjectType.GetHashCode();
                    if (ParentObjectId != null)
                    hashCode = hashCode * 59 + ParentObjectId.GetHashCode();
                    if (ParentObjectName != null)
                    hashCode = hashCode * 59 + ParentObjectName.GetHashCode();
                    if (RelatedObjectType != null)
                    hashCode = hashCode * 59 + RelatedObjectType.GetHashCode();
                    if (RelatedObjectId != null)
                    hashCode = hashCode * 59 + RelatedObjectId.GetHashCode();
                    if (RelatedObjectName != null)
                    hashCode = hashCode * 59 + RelatedObjectName.GetHashCode();
                    if (OldValue != null)
                    hashCode = hashCode * 59 + OldValue.GetHashCode();
                    if (NewValue != null)
                    hashCode = hashCode * 59 + NewValue.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (AssetNetworkAddress != null)
                    hashCode = hashCode * 59 + AssetNetworkAddress.GetHashCode();
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (Changes != null)
                    hashCode = hashCode * 59 + Changes.GetHashCode();
                    if (SessionSpsNodeIpAddress != null)
                    hashCode = hashCode * 59 + SessionSpsNodeIpAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ObjectChangeLog left, ObjectChangeLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ObjectChangeLog left, ObjectChangeLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
