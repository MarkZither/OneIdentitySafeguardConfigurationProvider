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
    /// Represents the email client configuration on the appliance.
    /// </summary>
    [DataContract]
    public partial class EmailClientConfigConnectionProperties : IEquatable<EmailClientConfigConnectionProperties>
    { 
        /// <summary>
        /// Database ID of an asset account for connecting to the asset. Overrides ServiceAccountName.
        /// </summary>
        /// <value>Database ID of an asset account for connecting to the asset. Overrides ServiceAccountName.</value>

        [DataMember(Name="ServiceAccountId")]
        public int? ServiceAccountId { get; set; }

        /// <summary>
        /// The name of an account for connecting to the SMTP server.
        /// </summary>
        /// <value>The name of an account for connecting to the SMTP server.</value>

        [MaxLength(100)]
        [DataMember(Name="ServiceAccountName")]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// The domain name of the service account if the SMTP authentication uses a Directory Account (Read-only)
        /// </summary>
        /// <value>The domain name of the service account if the SMTP authentication uses a Directory Account (Read-only)</value>

        [DataMember(Name="ServiceAccountDomainName")]
        public string ServiceAccountDomainName { get; set; }

        /// <summary>
        /// Service account password may be set via this property. (write-only)
        /// </summary>
        /// <value>Service account password may be set via this property. (write-only)</value>

        [MaxLength(128)]
        [DataMember(Name="ServiceAccountPassword")]
        public string ServiceAccountPassword { get; set; }

        /// <summary>
        /// The effective service account name (Read-only)
        /// </summary>
        /// <value>The effective service account name (Read-only)</value>

        [DataMember(Name="EffectiveServiceAccountName")]
        public string EffectiveServiceAccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailClientConfigConnectionProperties {\n");
            sb.Append("  ServiceAccountId: ").Append(ServiceAccountId).Append("\n");
            sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
            sb.Append("  ServiceAccountDomainName: ").Append(ServiceAccountDomainName).Append("\n");
            sb.Append("  ServiceAccountPassword: ").Append(ServiceAccountPassword).Append("\n");
            sb.Append("  EffectiveServiceAccountName: ").Append(EffectiveServiceAccountName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EmailClientConfigConnectionProperties)obj);
        }

        /// <summary>
        /// Returns true if EmailClientConfigConnectionProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailClientConfigConnectionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailClientConfigConnectionProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ServiceAccountId == other.ServiceAccountId ||
                    ServiceAccountId != null &&
                    ServiceAccountId.Equals(other.ServiceAccountId)
                ) && 
                (
                    ServiceAccountName == other.ServiceAccountName ||
                    ServiceAccountName != null &&
                    ServiceAccountName.Equals(other.ServiceAccountName)
                ) && 
                (
                    ServiceAccountDomainName == other.ServiceAccountDomainName ||
                    ServiceAccountDomainName != null &&
                    ServiceAccountDomainName.Equals(other.ServiceAccountDomainName)
                ) && 
                (
                    ServiceAccountPassword == other.ServiceAccountPassword ||
                    ServiceAccountPassword != null &&
                    ServiceAccountPassword.Equals(other.ServiceAccountPassword)
                ) && 
                (
                    EffectiveServiceAccountName == other.EffectiveServiceAccountName ||
                    EffectiveServiceAccountName != null &&
                    EffectiveServiceAccountName.Equals(other.EffectiveServiceAccountName)
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
                    if (ServiceAccountId != null)
                    hashCode = hashCode * 59 + ServiceAccountId.GetHashCode();
                    if (ServiceAccountName != null)
                    hashCode = hashCode * 59 + ServiceAccountName.GetHashCode();
                    if (ServiceAccountDomainName != null)
                    hashCode = hashCode * 59 + ServiceAccountDomainName.GetHashCode();
                    if (ServiceAccountPassword != null)
                    hashCode = hashCode * 59 + ServiceAccountPassword.GetHashCode();
                    if (EffectiveServiceAccountName != null)
                    hashCode = hashCode * 59 + EffectiveServiceAccountName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmailClientConfigConnectionProperties left, EmailClientConfigConnectionProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmailClientConfigConnectionProperties left, EmailClientConfigConnectionProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
