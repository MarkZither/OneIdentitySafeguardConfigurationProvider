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
    /// Represents a schedule used by a partition profile to discovery authorized SSH keys
    /// </summary>
    [DataContract]
    public partial class SshKeyDiscoverySchedule : IEquatable<SshKeyDiscoverySchedule>
    { 
        /// <summary>
        /// Name of this schedule
        /// </summary>
        /// <value>Name of this schedule</value>
        [Required]

        [StringLength(70, MinimumLength=1)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// The asset partition this Discovery schedule is applied to (Read-only)
        /// </summary>
        /// <value>The asset partition this Discovery schedule is applied to (Read-only)</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition this Discovery schedule is applied to (Read-only)
        /// </summary>
        /// <value>Name of the asset partition this Discovery schedule is applied to (Read-only)</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Number of profiles assigned to this discovery schedule (Read-only)
        /// </summary>
        /// <value>Number of profiles assigned to this discovery schedule (Read-only)</value>

        [DataMember(Name="ProfilesCount")]
        public int? ProfilesCount { get; set; }

        /// <summary>
        /// Number of accounts assigned to this discovery schedule (Read-only)
        /// </summary>
        /// <value>Number of accounts assigned to this discovery schedule (Read-only)</value>

        [DataMember(Name="AccountsCount")]
        public int? AccountsCount { get; set; }

        /// <summary>
        /// Database ID of the schedule (Read-only)
        /// </summary>
        /// <value>Database ID of the schedule (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Description of this schedule
        /// </summary>
        /// <value>Description of this schedule</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Date this entity was created (Read-only)
        /// </summary>
        /// <value>Date this entity was created (Read-only)</value>

        [DataMember(Name="CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The database ID of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserId")]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserDisplayName")]
        public string CreatedByUserDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleType
        /// </summary>

        [DataMember(Name="ScheduleType")]
        public ScheduleType ScheduleType { get; set; }

        /// <summary>
        /// The timezone in which the schedule should run. Required when ScheduleType is not Never.
        /// </summary>
        /// <value>The timezone in which the schedule should run. Required when ScheduleType is not Never.</value>

        [DataMember(Name="TimeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// The description of the timezone in which the schedule should run (Read-only)
        /// </summary>
        /// <value>The description of the timezone in which the schedule should run (Read-only)</value>

        [DataMember(Name="TimeZoneDisplayName")]
        public string TimeZoneDisplayName { get; set; }

        /// <summary>
        /// How frequently to run. Units are based on ScheduleType.   e.g. every 2 days, every 3 months, every 4 weeks
        /// </summary>
        /// <value>How frequently to run. Units are based on ScheduleType.   e.g. every 2 days, every 3 months, every 4 weeks</value>

        [Range(1, 2147483647)]
        [DataMember(Name="RepeatInterval")]
        public int? RepeatInterval { get; set; }

        /// <summary>
        /// Gets or Sets RepeatMonthlyScheduleType
        /// </summary>

        [DataMember(Name="RepeatMonthlyScheduleType")]
        public MonthlyScheduleType RepeatMonthlyScheduleType { get; set; }

        /// <summary>
        /// Gets or Sets RepeatWeekOfMonth
        /// </summary>

        [DataMember(Name="RepeatWeekOfMonth")]
        public WeekOfMonth RepeatWeekOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets RepeatDayOfWeek
        /// </summary>

        [DataMember(Name="RepeatDayOfWeek")]
        public DayOfWeek RepeatDayOfWeek { get; set; }

        /// <summary>
        /// Which day of the month the schedule should run. Only valid when RepeatMonthlyScheduleType is DayOfMonth
        /// </summary>
        /// <value>Which day of the month the schedule should run. Only valid when RepeatMonthlyScheduleType is DayOfMonth</value>

        [Range(1, 31)]
        [DataMember(Name="RepeatDayOfMonth")]
        public int? RepeatDayOfMonth { get; set; }

        /// <summary>
        /// Which days of the week the schedule should run. Only valid when ScheduleType is Weekly
        /// </summary>
        /// <value>Which days of the week the schedule should run. Only valid when ScheduleType is Weekly</value>

        [DataMember(Name="RepeatDaysOfWeek")]
        public List<DayOfWeek> RepeatDaysOfWeek { get; set; }

        /// <summary>
        /// Gets or Sets TimeOfDayType
        /// </summary>

        [DataMember(Name="TimeOfDayType")]
        public TimeOfDayType TimeOfDayType { get; set; }

        /// <summary>
        /// The hour of the day that the schedule will run (not applicable for &#x27;Hour&#x27; or &#x27;Minute&#x27; schedule type)
        /// </summary>
        /// <value>The hour of the day that the schedule will run (not applicable for &#x27;Hour&#x27; or &#x27;Minute&#x27; schedule type)</value>

        [Range(0, 23)]
        [DataMember(Name="StartHour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// The minute of the hour of the day that the schedule will run (not applicable for &#x27;Minute&#x27; schedule type)
        /// </summary>
        /// <value>The minute of the hour of the day that the schedule will run (not applicable for &#x27;Minute&#x27; schedule type)</value>

        [Range(0, 59)]
        [DataMember(Name="StartMinute")]
        public int? StartMinute { get; set; }

        /// <summary>
        /// Configuration of intervals of time in a day where tasks can be executed.
        /// </summary>
        /// <value>Configuration of intervals of time in a day where tasks can be executed.</value>

        [DataMember(Name="TimeOfDayIntervals")]
        public List<ScheduleInterval> TimeOfDayIntervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SshKeyDiscoverySchedule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  ProfilesCount: ").Append(ProfilesCount).Append("\n");
            sb.Append("  AccountsCount: ").Append(AccountsCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
            sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  TimeZoneDisplayName: ").Append(TimeZoneDisplayName).Append("\n");
            sb.Append("  RepeatInterval: ").Append(RepeatInterval).Append("\n");
            sb.Append("  RepeatMonthlyScheduleType: ").Append(RepeatMonthlyScheduleType).Append("\n");
            sb.Append("  RepeatWeekOfMonth: ").Append(RepeatWeekOfMonth).Append("\n");
            sb.Append("  RepeatDayOfWeek: ").Append(RepeatDayOfWeek).Append("\n");
            sb.Append("  RepeatDayOfMonth: ").Append(RepeatDayOfMonth).Append("\n");
            sb.Append("  RepeatDaysOfWeek: ").Append(RepeatDaysOfWeek).Append("\n");
            sb.Append("  TimeOfDayType: ").Append(TimeOfDayType).Append("\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
            sb.Append("  TimeOfDayIntervals: ").Append(TimeOfDayIntervals).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SshKeyDiscoverySchedule)obj);
        }

        /// <summary>
        /// Returns true if SshKeyDiscoverySchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of SshKeyDiscoverySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshKeyDiscoverySchedule other)
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
                    ProfilesCount == other.ProfilesCount ||
                    ProfilesCount != null &&
                    ProfilesCount.Equals(other.ProfilesCount)
                ) && 
                (
                    AccountsCount == other.AccountsCount ||
                    AccountsCount != null &&
                    AccountsCount.Equals(other.AccountsCount)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedByUserId == other.CreatedByUserId ||
                    CreatedByUserId != null &&
                    CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    CreatedByUserDisplayName == other.CreatedByUserDisplayName ||
                    CreatedByUserDisplayName != null &&
                    CreatedByUserDisplayName.Equals(other.CreatedByUserDisplayName)
                ) && 
                (
                    ScheduleType == other.ScheduleType ||
                    ScheduleType != null &&
                    ScheduleType.Equals(other.ScheduleType)
                ) && 
                (
                    TimeZoneId == other.TimeZoneId ||
                    TimeZoneId != null &&
                    TimeZoneId.Equals(other.TimeZoneId)
                ) && 
                (
                    TimeZoneDisplayName == other.TimeZoneDisplayName ||
                    TimeZoneDisplayName != null &&
                    TimeZoneDisplayName.Equals(other.TimeZoneDisplayName)
                ) && 
                (
                    RepeatInterval == other.RepeatInterval ||
                    RepeatInterval != null &&
                    RepeatInterval.Equals(other.RepeatInterval)
                ) && 
                (
                    RepeatMonthlyScheduleType == other.RepeatMonthlyScheduleType ||
                    RepeatMonthlyScheduleType != null &&
                    RepeatMonthlyScheduleType.Equals(other.RepeatMonthlyScheduleType)
                ) && 
                (
                    RepeatWeekOfMonth == other.RepeatWeekOfMonth ||
                    RepeatWeekOfMonth != null &&
                    RepeatWeekOfMonth.Equals(other.RepeatWeekOfMonth)
                ) && 
                (
                    RepeatDayOfWeek == other.RepeatDayOfWeek ||
                    RepeatDayOfWeek != null &&
                    RepeatDayOfWeek.Equals(other.RepeatDayOfWeek)
                ) && 
                (
                    RepeatDayOfMonth == other.RepeatDayOfMonth ||
                    RepeatDayOfMonth != null &&
                    RepeatDayOfMonth.Equals(other.RepeatDayOfMonth)
                ) && 
                (
                    RepeatDaysOfWeek == other.RepeatDaysOfWeek ||
                    RepeatDaysOfWeek != null &&
                    RepeatDaysOfWeek.SequenceEqual(other.RepeatDaysOfWeek)
                ) && 
                (
                    TimeOfDayType == other.TimeOfDayType ||
                    TimeOfDayType != null &&
                    TimeOfDayType.Equals(other.TimeOfDayType)
                ) && 
                (
                    StartHour == other.StartHour ||
                    StartHour != null &&
                    StartHour.Equals(other.StartHour)
                ) && 
                (
                    StartMinute == other.StartMinute ||
                    StartMinute != null &&
                    StartMinute.Equals(other.StartMinute)
                ) && 
                (
                    TimeOfDayIntervals == other.TimeOfDayIntervals ||
                    TimeOfDayIntervals != null &&
                    TimeOfDayIntervals.SequenceEqual(other.TimeOfDayIntervals)
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
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (ProfilesCount != null)
                    hashCode = hashCode * 59 + ProfilesCount.GetHashCode();
                    if (AccountsCount != null)
                    hashCode = hashCode * 59 + AccountsCount.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                    if (ScheduleType != null)
                    hashCode = hashCode * 59 + ScheduleType.GetHashCode();
                    if (TimeZoneId != null)
                    hashCode = hashCode * 59 + TimeZoneId.GetHashCode();
                    if (TimeZoneDisplayName != null)
                    hashCode = hashCode * 59 + TimeZoneDisplayName.GetHashCode();
                    if (RepeatInterval != null)
                    hashCode = hashCode * 59 + RepeatInterval.GetHashCode();
                    if (RepeatMonthlyScheduleType != null)
                    hashCode = hashCode * 59 + RepeatMonthlyScheduleType.GetHashCode();
                    if (RepeatWeekOfMonth != null)
                    hashCode = hashCode * 59 + RepeatWeekOfMonth.GetHashCode();
                    if (RepeatDayOfWeek != null)
                    hashCode = hashCode * 59 + RepeatDayOfWeek.GetHashCode();
                    if (RepeatDayOfMonth != null)
                    hashCode = hashCode * 59 + RepeatDayOfMonth.GetHashCode();
                    if (RepeatDaysOfWeek != null)
                    hashCode = hashCode * 59 + RepeatDaysOfWeek.GetHashCode();
                    if (TimeOfDayType != null)
                    hashCode = hashCode * 59 + TimeOfDayType.GetHashCode();
                    if (StartHour != null)
                    hashCode = hashCode * 59 + StartHour.GetHashCode();
                    if (StartMinute != null)
                    hashCode = hashCode * 59 + StartMinute.GetHashCode();
                    if (TimeOfDayIntervals != null)
                    hashCode = hashCode * 59 + TimeOfDayIntervals.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SshKeyDiscoverySchedule left, SshKeyDiscoverySchedule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SshKeyDiscoverySchedule left, SshKeyDiscoverySchedule right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
