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
    /// When the TypeReferenceName property is \&quot;OneLoginMfa\&quot;, this provides additional configuration  values specific to that provider type.
    /// </summary>
    [DataContract]
    public partial class IdentityProviderConfigOneLoginMfaProperties : IEquatable<IdentityProviderConfigOneLoginMfaProperties>
    { 
        /// <summary>
        /// The full DNS host name of the OneLogin subscription. Typically this will be &lt;subdomain&gt;.onelogin.com.  Where &lt;subdomain&gt; is the name chosen by you when first signing up.
        /// </summary>
        /// <value>The full DNS host name of the OneLogin subscription. Typically this will be &lt;subdomain&gt;.onelogin.com.  Where &lt;subdomain&gt; is the name chosen by you when first signing up.</value>

        [MaxLength(255)]
        [DataMember(Name="DnsHostName")]
        public string DnsHostName { get; set; }

        /// <summary>
        /// The Client ID of your OneLogin API Credential pair. Obtained by creating API Credentials on your  OneLogin administration site. The credential must be given the \&quot;Manage All\&quot; scope/permission.
        /// </summary>
        /// <value>The Client ID of your OneLogin API Credential pair. Obtained by creating API Credentials on your  OneLogin administration site. The credential must be given the \&quot;Manage All\&quot; scope/permission.</value>

        [MaxLength(255)]
        [DataMember(Name="ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The Client Secret of your OneLogin API Credential pair. Obtained by creating API Credentials on  your OneLogin administration site. The credential must be given the \&quot;Manage All\&quot; scope/permission.  This value is considered write-only and cannot be obtained after being set.
        /// </summary>
        /// <value>The Client Secret of your OneLogin API Credential pair. Obtained by creating API Credentials on  your OneLogin administration site. The credential must be given the \&quot;Manage All\&quot; scope/permission.  This value is considered write-only and cannot be obtained after being set.</value>

        [MaxLength(255)]
        [DataMember(Name="ClientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProviderConfigOneLoginMfaProperties {\n");
            sb.Append("  DnsHostName: ").Append(DnsHostName).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdentityProviderConfigOneLoginMfaProperties)obj);
        }

        /// <summary>
        /// Returns true if IdentityProviderConfigOneLoginMfaProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityProviderConfigOneLoginMfaProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderConfigOneLoginMfaProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DnsHostName == other.DnsHostName ||
                    DnsHostName != null &&
                    DnsHostName.Equals(other.DnsHostName)
                ) && 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                ) && 
                (
                    ClientSecret == other.ClientSecret ||
                    ClientSecret != null &&
                    ClientSecret.Equals(other.ClientSecret)
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
                    if (DnsHostName != null)
                    hashCode = hashCode * 59 + DnsHostName.GetHashCode();
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                    if (ClientSecret != null)
                    hashCode = hashCode * 59 + ClientSecret.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdentityProviderConfigOneLoginMfaProperties left, IdentityProviderConfigOneLoginMfaProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentityProviderConfigOneLoginMfaProperties left, IdentityProviderConfigOneLoginMfaProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
