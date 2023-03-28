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
    /// User authentication events
    /// </summary>
    [DataContract]
    public partial class LoginActivityLog : IEquatable<LoginActivityLog>
    { 
        /// <summary>
        /// The unique id of this log entry
        /// </summary>
        /// <value>The unique id of this log entry</value>

        [DataMember(Name="LogId")]
        public string LogId { get; set; }

        /// <summary>
        /// Time of authentication
        /// </summary>
        /// <value>Time of authentication</value>

        [DataMember(Name="LogTime")]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// Unique id of the user that authenticated.
        /// </summary>
        /// <value>Unique id of the user that authenticated.</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

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
        /// Id of appliance to which user authenticated
        /// </summary>
        /// <value>Id of appliance to which user authenticated</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Name of appliance to which user authenticated
        /// </summary>
        /// <value>Name of appliance to which user authenticated</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>

        [DataMember(Name="ErrorType")]
        public AuthenticationErrorType ErrorType { get; set; }

        /// <summary>
        /// The id of the user&#x27;s primary authentication provider.
        /// </summary>
        /// <value>The id of the user&#x27;s primary authentication provider.</value>

        [DataMember(Name="PrimaryAuthenticationProviderId")]
        public int? PrimaryAuthenticationProviderId { get; set; }

        /// <summary>
        /// The name of the user&#x27;s primary authentication provider
        /// </summary>
        /// <value>The name of the user&#x27;s primary authentication provider</value>

        [DataMember(Name="PrimaryAuthenticationProviderName")]
        public string PrimaryAuthenticationProviderName { get; set; }

        /// <summary>
        /// The id of the user&#x27;s secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.
        /// </summary>
        /// <value>The id of the user&#x27;s secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.</value>

        [DataMember(Name="SecondaryAuthenticationProviderId")]
        public int? SecondaryAuthenticationProviderId { get; set; }

        /// <summary>
        /// The name of the user&#x27;s secondary authentication provider. (Read-only)
        /// </summary>
        /// <value>The name of the user&#x27;s secondary authentication provider. (Read-only)</value>

        [DataMember(Name="SecondaryAuthenticationProviderName")]
        public string SecondaryAuthenticationProviderName { get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        /// <value>Reason for failure</value>

        [DataMember(Name="Reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets LoginTime
        /// </summary>

        [DataMember(Name="LoginTime")]
        public DateTime? LoginTime { get; set; }

        /// <summary>
        /// Gets or Sets LoginDuration
        /// </summary>

        [DataMember(Name="LoginDuration")]
        public TimeInterval LoginDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginActivityLog {\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  PrimaryAuthenticationProviderId: ").Append(PrimaryAuthenticationProviderId).Append("\n");
            sb.Append("  PrimaryAuthenticationProviderName: ").Append(PrimaryAuthenticationProviderName).Append("\n");
            sb.Append("  SecondaryAuthenticationProviderId: ").Append(SecondaryAuthenticationProviderId).Append("\n");
            sb.Append("  SecondaryAuthenticationProviderName: ").Append(SecondaryAuthenticationProviderName).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  LoginTime: ").Append(LoginTime).Append("\n");
            sb.Append("  LoginDuration: ").Append(LoginDuration).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoginActivityLog)obj);
        }

        /// <summary>
        /// Returns true if LoginActivityLog instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginActivityLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginActivityLog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LogId == other.LogId ||
                    LogId != null &&
                    LogId.Equals(other.LogId)
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
                    ErrorType == other.ErrorType ||
                    ErrorType != null &&
                    ErrorType.Equals(other.ErrorType)
                ) && 
                (
                    PrimaryAuthenticationProviderId == other.PrimaryAuthenticationProviderId ||
                    PrimaryAuthenticationProviderId != null &&
                    PrimaryAuthenticationProviderId.Equals(other.PrimaryAuthenticationProviderId)
                ) && 
                (
                    PrimaryAuthenticationProviderName == other.PrimaryAuthenticationProviderName ||
                    PrimaryAuthenticationProviderName != null &&
                    PrimaryAuthenticationProviderName.Equals(other.PrimaryAuthenticationProviderName)
                ) && 
                (
                    SecondaryAuthenticationProviderId == other.SecondaryAuthenticationProviderId ||
                    SecondaryAuthenticationProviderId != null &&
                    SecondaryAuthenticationProviderId.Equals(other.SecondaryAuthenticationProviderId)
                ) && 
                (
                    SecondaryAuthenticationProviderName == other.SecondaryAuthenticationProviderName ||
                    SecondaryAuthenticationProviderName != null &&
                    SecondaryAuthenticationProviderName.Equals(other.SecondaryAuthenticationProviderName)
                ) && 
                (
                    Reason == other.Reason ||
                    Reason != null &&
                    Reason.Equals(other.Reason)
                ) && 
                (
                    LoginTime == other.LoginTime ||
                    LoginTime != null &&
                    LoginTime.Equals(other.LoginTime)
                ) && 
                (
                    LoginDuration == other.LoginDuration ||
                    LoginDuration != null &&
                    LoginDuration.Equals(other.LoginDuration)
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
                    if (LogId != null)
                    hashCode = hashCode * 59 + LogId.GetHashCode();
                    if (LogTime != null)
                    hashCode = hashCode * 59 + LogTime.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (ErrorType != null)
                    hashCode = hashCode * 59 + ErrorType.GetHashCode();
                    if (PrimaryAuthenticationProviderId != null)
                    hashCode = hashCode * 59 + PrimaryAuthenticationProviderId.GetHashCode();
                    if (PrimaryAuthenticationProviderName != null)
                    hashCode = hashCode * 59 + PrimaryAuthenticationProviderName.GetHashCode();
                    if (SecondaryAuthenticationProviderId != null)
                    hashCode = hashCode * 59 + SecondaryAuthenticationProviderId.GetHashCode();
                    if (SecondaryAuthenticationProviderName != null)
                    hashCode = hashCode * 59 + SecondaryAuthenticationProviderName.GetHashCode();
                    if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                    if (LoginTime != null)
                    hashCode = hashCode * 59 + LoginTime.GetHashCode();
                    if (LoginDuration != null)
                    hashCode = hashCode * 59 + LoginDuration.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoginActivityLog left, LoginActivityLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginActivityLog left, LoginActivityLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
