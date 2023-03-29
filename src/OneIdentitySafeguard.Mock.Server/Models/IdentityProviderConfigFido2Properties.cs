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
    /// When the TypeReferenceName property is \&quot;Fido2\&quot;, this provides additional FIDO2-specific              configuration values.
    /// </summary>
    [DataContract]
    public partial class IdentityProviderConfigFido2Properties : IEquatable<IdentityProviderConfigFido2Properties>
    { 
        /// <summary>
        /// A valid domain string that identifies the WebAuthn Relying Party on whose behalf a given registration              or authentication ceremony is being performed.  A public key credential can only be used for authentication              with the same entity (as identified by this value) it was registered with.  However, this value may be just a              valid registrable domain suffix of what appears in the user&#x27;s browser when registering.  For example, you may              enter just \&quot;contoso.com\&quot; here, which would allow you to register against a server at https://www.contoso.com,              or https://node1.contoso.com, and later use the same authenticator security key to authenticate at either of              those locations.
        /// </summary>
        /// <value>A valid domain string that identifies the WebAuthn Relying Party on whose behalf a given registration              or authentication ceremony is being performed.  A public key credential can only be used for authentication              with the same entity (as identified by this value) it was registered with.  However, this value may be just a              valid registrable domain suffix of what appears in the user&#x27;s browser when registering.  For example, you may              enter just \&quot;contoso.com\&quot; here, which would allow you to register against a server at https://www.contoso.com,              or https://node1.contoso.com, and later use the same authenticator security key to authenticate at either of              those locations.</value>

        [MaxLength(255)]
        [DataMember(Name="DomainSuffix")]
        public string DomainSuffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProviderConfigFido2Properties {\n");
            sb.Append("  DomainSuffix: ").Append(DomainSuffix).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdentityProviderConfigFido2Properties)obj);
        }

        /// <summary>
        /// Returns true if IdentityProviderConfigFido2Properties instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityProviderConfigFido2Properties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderConfigFido2Properties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DomainSuffix == other.DomainSuffix ||
                    DomainSuffix != null &&
                    DomainSuffix.Equals(other.DomainSuffix)
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
                    if (DomainSuffix != null)
                    hashCode = hashCode * 59 + DomainSuffix.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdentityProviderConfigFido2Properties left, IdentityProviderConfigFido2Properties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentityProviderConfigFido2Properties left, IdentityProviderConfigFido2Properties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}