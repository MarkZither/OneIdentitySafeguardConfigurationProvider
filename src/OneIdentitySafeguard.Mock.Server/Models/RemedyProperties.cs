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
    /// Configuration specific to Remedy
    /// </summary>
    [DataContract]
    public partial class RemedyProperties : IEquatable<RemedyProperties>
    { 
        /// <summary>
        /// Authentication string used to connect to the api
        /// </summary>
        /// <value>Authentication string used to connect to the api</value>

        [DataMember(Name="AuthenticationString")]
        public string AuthenticationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemedyProperties {\n");
            sb.Append("  AuthenticationString: ").Append(AuthenticationString).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RemedyProperties)obj);
        }

        /// <summary>
        /// Returns true if RemedyProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of RemedyProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemedyProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AuthenticationString == other.AuthenticationString ||
                    AuthenticationString != null &&
                    AuthenticationString.Equals(other.AuthenticationString)
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
                    if (AuthenticationString != null)
                    hashCode = hashCode * 59 + AuthenticationString.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RemedyProperties left, RemedyProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RemedyProperties left, RemedyProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}