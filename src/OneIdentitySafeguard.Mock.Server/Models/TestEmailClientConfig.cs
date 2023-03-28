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
    public partial class TestEmailClientConfig : IEquatable<TestEmailClientConfig>
    { 
        /// <summary>
        /// Email address used to send a test email to
        /// </summary>
        /// <value>Email address used to send a test email to</value>
        [Required]

        [MaxLength(512)]
        [DataMember(Name="ToEmail")]
        public string ToEmail { get; set; }

        /// <summary>
        /// IP address or FQDN of the email server
        /// </summary>
        /// <value>IP address or FQDN of the email server</value>
        [Required]

        [MaxLength(255)]
        [DataMember(Name="ServerAddress")]
        public string ServerAddress { get; set; }

        /// <summary>
        /// TCP port number for the email service
        /// </summary>
        /// <value>TCP port number for the email service</value>

        [Range(1, 65535)]
        [DataMember(Name="PortNumber")]
        public int? PortNumber { get; set; }

        /// <summary>
        /// Email address used as the From address for all email originating from the appliance. Required when an email server address is configured.
        /// </summary>
        /// <value>Email address used as the From address for all email originating from the appliance. Required when an email server address is configured.</value>
        [Required]

        [MaxLength(512)]
        [DataMember(Name="SenderEmail")]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Determines whether TLS is required by the SMTP server. (STARTTLS)
        /// </summary>
        /// <value>Determines whether TLS is required by the SMTP server. (STARTTLS)</value>

        [DataMember(Name="RequireTlsFlag")]
        public bool? RequireTlsFlag { get; set; }

        /// <summary>
        /// Determines whether SMTPS is required by the SMTP server.  Setting this also sets RequireTlsFlag
        /// </summary>
        /// <value>Determines whether SMTPS is required by the SMTP server.  Setting this also sets RequireTlsFlag</value>

        [DataMember(Name="RequireSmtpsFlag")]
        public bool? RequireSmtpsFlag { get; set; }

        /// <summary>
        /// Determines whether the server certificate needs validation when RequireTlsFlag is set to true
        /// </summary>
        /// <value>Determines whether the server certificate needs validation when RequireTlsFlag is set to true</value>

        [DataMember(Name="VerifySslCertificate")]
        public bool? VerifySslCertificate { get; set; }

        /// <summary>
        /// Determines whether the SMTP server requires account/password authentication
        /// </summary>
        /// <value>Determines whether the SMTP server requires account/password authentication</value>

        [DataMember(Name="RequireUserAuthentication")]
        public bool? RequireUserAuthentication { get; set; }

        /// <summary>
        /// Indicate if the client certificate is required for the connection to remote SMTP server
        /// </summary>
        /// <value>Indicate if the client certificate is required for the connection to remote SMTP server</value>

        [DataMember(Name="UseClientCertificate")]
        public bool? UseClientCertificate { get; set; }

        /// <summary>
        /// Seconds to wait after the test email has begun delivery to see if the delivery fails (max 255 seconds).
        /// </summary>
        /// <value>Seconds to wait after the test email has begun delivery to see if the delivery fails (max 255 seconds).</value>

        [DataMember(Name="TimeoutSeconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>

        [DataMember(Name="ConnectionProperties")]
        public EmailClientConfigConnectionProperties ConnectionProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestEmailClientConfig {\n");
            sb.Append("  ToEmail: ").Append(ToEmail).Append("\n");
            sb.Append("  ServerAddress: ").Append(ServerAddress).Append("\n");
            sb.Append("  PortNumber: ").Append(PortNumber).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  RequireTlsFlag: ").Append(RequireTlsFlag).Append("\n");
            sb.Append("  RequireSmtpsFlag: ").Append(RequireSmtpsFlag).Append("\n");
            sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
            sb.Append("  RequireUserAuthentication: ").Append(RequireUserAuthentication).Append("\n");
            sb.Append("  UseClientCertificate: ").Append(UseClientCertificate).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TestEmailClientConfig)obj);
        }

        /// <summary>
        /// Returns true if TestEmailClientConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of TestEmailClientConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestEmailClientConfig other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ToEmail == other.ToEmail ||
                    ToEmail != null &&
                    ToEmail.Equals(other.ToEmail)
                ) && 
                (
                    ServerAddress == other.ServerAddress ||
                    ServerAddress != null &&
                    ServerAddress.Equals(other.ServerAddress)
                ) && 
                (
                    PortNumber == other.PortNumber ||
                    PortNumber != null &&
                    PortNumber.Equals(other.PortNumber)
                ) && 
                (
                    SenderEmail == other.SenderEmail ||
                    SenderEmail != null &&
                    SenderEmail.Equals(other.SenderEmail)
                ) && 
                (
                    RequireTlsFlag == other.RequireTlsFlag ||
                    RequireTlsFlag != null &&
                    RequireTlsFlag.Equals(other.RequireTlsFlag)
                ) && 
                (
                    RequireSmtpsFlag == other.RequireSmtpsFlag ||
                    RequireSmtpsFlag != null &&
                    RequireSmtpsFlag.Equals(other.RequireSmtpsFlag)
                ) && 
                (
                    VerifySslCertificate == other.VerifySslCertificate ||
                    VerifySslCertificate != null &&
                    VerifySslCertificate.Equals(other.VerifySslCertificate)
                ) && 
                (
                    RequireUserAuthentication == other.RequireUserAuthentication ||
                    RequireUserAuthentication != null &&
                    RequireUserAuthentication.Equals(other.RequireUserAuthentication)
                ) && 
                (
                    UseClientCertificate == other.UseClientCertificate ||
                    UseClientCertificate != null &&
                    UseClientCertificate.Equals(other.UseClientCertificate)
                ) && 
                (
                    TimeoutSeconds == other.TimeoutSeconds ||
                    TimeoutSeconds != null &&
                    TimeoutSeconds.Equals(other.TimeoutSeconds)
                ) && 
                (
                    ConnectionProperties == other.ConnectionProperties ||
                    ConnectionProperties != null &&
                    ConnectionProperties.Equals(other.ConnectionProperties)
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
                    if (ToEmail != null)
                    hashCode = hashCode * 59 + ToEmail.GetHashCode();
                    if (ServerAddress != null)
                    hashCode = hashCode * 59 + ServerAddress.GetHashCode();
                    if (PortNumber != null)
                    hashCode = hashCode * 59 + PortNumber.GetHashCode();
                    if (SenderEmail != null)
                    hashCode = hashCode * 59 + SenderEmail.GetHashCode();
                    if (RequireTlsFlag != null)
                    hashCode = hashCode * 59 + RequireTlsFlag.GetHashCode();
                    if (RequireSmtpsFlag != null)
                    hashCode = hashCode * 59 + RequireSmtpsFlag.GetHashCode();
                    if (VerifySslCertificate != null)
                    hashCode = hashCode * 59 + VerifySslCertificate.GetHashCode();
                    if (RequireUserAuthentication != null)
                    hashCode = hashCode * 59 + RequireUserAuthentication.GetHashCode();
                    if (UseClientCertificate != null)
                    hashCode = hashCode * 59 + UseClientCertificate.GetHashCode();
                    if (TimeoutSeconds != null)
                    hashCode = hashCode * 59 + TimeoutSeconds.GetHashCode();
                    if (ConnectionProperties != null)
                    hashCode = hashCode * 59 + ConnectionProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TestEmailClientConfig left, TestEmailClientConfig right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TestEmailClientConfig left, TestEmailClientConfig right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
