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
    public partial class TicketSystemTestConnectionParameters : IEquatable<TicketSystemTestConnectionParameters>
    { 
        /// <summary>
        /// Base URL location of the ticket system
        /// </summary>
        /// <value>Base URL location of the ticket system</value>

        [MaxLength(255)]
        [DataMember(Name="ApplicationUrl")]
        public string ApplicationUrl { get; set; }

        /// <summary>
        /// Gets or Sets TicketSystemType
        /// </summary>
        [Required]

        [DataMember(Name="TicketSystemType")]
        public TicketSystemType TicketSystemType { get; set; }

        /// <summary>
        /// Login name for ticket system
        /// </summary>
        /// <value>Login name for ticket system</value>

        [MaxLength(255)]
        [DataMember(Name="UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Password for ticket system
        /// </summary>
        /// <value>Password for ticket system</value>

        [DataMember(Name="Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ServiceNowProperties
        /// </summary>

        [DataMember(Name="ServiceNowProperties")]
        public ServiceNowProperties ServiceNowProperties { get; set; }

        /// <summary>
        /// Gets or Sets RemedyProperties
        /// </summary>

        [DataMember(Name="RemedyProperties")]
        public RemedyProperties RemedyProperties { get; set; }

        /// <summary>
        /// TicketRegularExpression string used to validate format of ticket
        /// </summary>
        /// <value>TicketRegularExpression string used to validate format of ticket</value>

        [MaxLength(1024)]
        [DataMember(Name="TicketRegularExpression")]
        public string TicketRegularExpression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TicketSystemTestConnectionParameters {\n");
            sb.Append("  ApplicationUrl: ").Append(ApplicationUrl).Append("\n");
            sb.Append("  TicketSystemType: ").Append(TicketSystemType).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ServiceNowProperties: ").Append(ServiceNowProperties).Append("\n");
            sb.Append("  RemedyProperties: ").Append(RemedyProperties).Append("\n");
            sb.Append("  TicketRegularExpression: ").Append(TicketRegularExpression).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TicketSystemTestConnectionParameters)obj);
        }

        /// <summary>
        /// Returns true if TicketSystemTestConnectionParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of TicketSystemTestConnectionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketSystemTestConnectionParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ApplicationUrl == other.ApplicationUrl ||
                    ApplicationUrl != null &&
                    ApplicationUrl.Equals(other.ApplicationUrl)
                ) && 
                (
                    TicketSystemType == other.TicketSystemType ||
                    TicketSystemType != null &&
                    TicketSystemType.Equals(other.TicketSystemType)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    ServiceNowProperties == other.ServiceNowProperties ||
                    ServiceNowProperties != null &&
                    ServiceNowProperties.Equals(other.ServiceNowProperties)
                ) && 
                (
                    RemedyProperties == other.RemedyProperties ||
                    RemedyProperties != null &&
                    RemedyProperties.Equals(other.RemedyProperties)
                ) && 
                (
                    TicketRegularExpression == other.TicketRegularExpression ||
                    TicketRegularExpression != null &&
                    TicketRegularExpression.Equals(other.TicketRegularExpression)
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
                    if (ApplicationUrl != null)
                    hashCode = hashCode * 59 + ApplicationUrl.GetHashCode();
                    if (TicketSystemType != null)
                    hashCode = hashCode * 59 + TicketSystemType.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (ServiceNowProperties != null)
                    hashCode = hashCode * 59 + ServiceNowProperties.GetHashCode();
                    if (RemedyProperties != null)
                    hashCode = hashCode * 59 + RemedyProperties.GetHashCode();
                    if (TicketRegularExpression != null)
                    hashCode = hashCode * 59 + TicketRegularExpression.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TicketSystemTestConnectionParameters left, TicketSystemTestConnectionParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TicketSystemTestConnectionParameters left, TicketSystemTestConnectionParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}