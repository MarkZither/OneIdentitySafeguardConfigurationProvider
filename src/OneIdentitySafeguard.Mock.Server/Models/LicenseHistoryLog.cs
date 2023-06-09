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
    /// Represents a change to the appliance licenses
    /// </summary>
    [DataContract]
    public partial class LicenseHistoryLog : IEquatable<LicenseHistoryLog>
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
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

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
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        /// <value>Name of the event</value>

        [DataMember(Name="EventDisplayName")]
        public string EventDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>

        [DataMember(Name="OperationType")]
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name="Status")]
        public LicenseStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="Type")]
        public LicenseType Type { get; set; }

        /// <summary>
        /// The license key.
        /// </summary>
        /// <value>The license key.</value>

        [DataMember(Name="Key")]
        public string Key { get; set; }

        /// <summary>
        /// Is this an enterprise license.
        /// </summary>
        /// <value>Is this an enterprise license.</value>

        [DataMember(Name="IsEnterprise")]
        public bool? IsEnterprise { get; set; }

        /// <summary>
        /// Is the license valid.
        /// </summary>
        /// <value>Is the license valid.</value>

        [DataMember(Name="IsValid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>

        [DataMember(Name="Module")]
        public LicensableModule Module { get; set; }

        /// <summary>
        /// The date and time that the license expires, or null  if the license is a perpetual license.
        /// </summary>
        /// <value>The date and time that the license expires, or null  if the license is a perpetual license.</value>

        [DataMember(Name="Expires")]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// The number of days remaining until the license expires, or  null if the license is perpetual. Will be negative if the  license is already expired.
        /// </summary>
        /// <value>The number of days remaining until the license expires, or  null if the license is perpetual. Will be negative if the  license is already expired.</value>

        [DataMember(Name="DaysRemaining")]
        public int? DaysRemaining { get; private set; }

        /// <summary>
        /// For a trial license, the date by which it must be installed.  If no start-by date is present, this will return null.
        /// </summary>
        /// <value>For a trial license, the date by which it must be installed.  If no start-by date is present, this will return null.</value>

        [DataMember(Name="InstallByDate")]
        public DateTime? InstallByDate { get; set; }

        /// <summary>
        /// For a trial license, the number of days following installation that  the license remains valid. Null if not present.
        /// </summary>
        /// <value>For a trial license, the number of days following installation that  the license remains valid. Null if not present.</value>

        [DataMember(Name="TrialDays")]
        public long? TrialDays { get; set; }

        /// <summary>
        /// Is the license expired.
        /// </summary>
        /// <value>Is the license expired.</value>

        [DataMember(Name="IsExpired")]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Gets or Sets PasswordManagementLicense
        /// </summary>

        [DataMember(Name="PasswordManagementLicense")]
        public PasswordManagementLicense PasswordManagementLicense { get; set; }

        /// <summary>
        /// Gets or Sets SecretsBrokerLicense
        /// </summary>

        [DataMember(Name="SecretsBrokerLicense")]
        public SecretsBrokerLicense SecretsBrokerLicense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseHistoryLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  IsEnterprise: ").Append(IsEnterprise).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  DaysRemaining: ").Append(DaysRemaining).Append("\n");
            sb.Append("  InstallByDate: ").Append(InstallByDate).Append("\n");
            sb.Append("  TrialDays: ").Append(TrialDays).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  PasswordManagementLicense: ").Append(PasswordManagementLicense).Append("\n");
            sb.Append("  SecretsBrokerLicense: ").Append(SecretsBrokerLicense).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LicenseHistoryLog)obj);
        }

        /// <summary>
        /// Returns true if LicenseHistoryLog instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseHistoryLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseHistoryLog other)
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
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
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
                    OperationType == other.OperationType ||
                    OperationType != null &&
                    OperationType.Equals(other.OperationType)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Key == other.Key ||
                    Key != null &&
                    Key.Equals(other.Key)
                ) && 
                (
                    IsEnterprise == other.IsEnterprise ||
                    IsEnterprise != null &&
                    IsEnterprise.Equals(other.IsEnterprise)
                ) && 
                (
                    IsValid == other.IsValid ||
                    IsValid != null &&
                    IsValid.Equals(other.IsValid)
                ) && 
                (
                    Module == other.Module ||
                    Module != null &&
                    Module.Equals(other.Module)
                ) && 
                (
                    Expires == other.Expires ||
                    Expires != null &&
                    Expires.Equals(other.Expires)
                ) && 
                (
                    DaysRemaining == other.DaysRemaining ||
                    DaysRemaining != null &&
                    DaysRemaining.Equals(other.DaysRemaining)
                ) && 
                (
                    InstallByDate == other.InstallByDate ||
                    InstallByDate != null &&
                    InstallByDate.Equals(other.InstallByDate)
                ) && 
                (
                    TrialDays == other.TrialDays ||
                    TrialDays != null &&
                    TrialDays.Equals(other.TrialDays)
                ) && 
                (
                    IsExpired == other.IsExpired ||
                    IsExpired != null &&
                    IsExpired.Equals(other.IsExpired)
                ) && 
                (
                    PasswordManagementLicense == other.PasswordManagementLicense ||
                    PasswordManagementLicense != null &&
                    PasswordManagementLicense.Equals(other.PasswordManagementLicense)
                ) && 
                (
                    SecretsBrokerLicense == other.SecretsBrokerLicense ||
                    SecretsBrokerLicense != null &&
                    SecretsBrokerLicense.Equals(other.SecretsBrokerLicense)
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
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (OperationType != null)
                    hashCode = hashCode * 59 + OperationType.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                    if (IsEnterprise != null)
                    hashCode = hashCode * 59 + IsEnterprise.GetHashCode();
                    if (IsValid != null)
                    hashCode = hashCode * 59 + IsValid.GetHashCode();
                    if (Module != null)
                    hashCode = hashCode * 59 + Module.GetHashCode();
                    if (Expires != null)
                    hashCode = hashCode * 59 + Expires.GetHashCode();
                    if (DaysRemaining != null)
                    hashCode = hashCode * 59 + DaysRemaining.GetHashCode();
                    if (InstallByDate != null)
                    hashCode = hashCode * 59 + InstallByDate.GetHashCode();
                    if (TrialDays != null)
                    hashCode = hashCode * 59 + TrialDays.GetHashCode();
                    if (IsExpired != null)
                    hashCode = hashCode * 59 + IsExpired.GetHashCode();
                    if (PasswordManagementLicense != null)
                    hashCode = hashCode * 59 + PasswordManagementLicense.GetHashCode();
                    if (SecretsBrokerLicense != null)
                    hashCode = hashCode * 59 + SecretsBrokerLicense.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LicenseHistoryLog left, LicenseHistoryLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LicenseHistoryLog left, LicenseHistoryLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
