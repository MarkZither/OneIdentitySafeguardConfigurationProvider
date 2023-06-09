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
    /// Represents a shared personal password account.
    /// </summary>
    [DataContract]
    public partial class PersonalAccountShare : IEquatable<PersonalAccountShare>
    { 
        /// <summary>
        /// The Id of the user with whom the personal account is shared.
        /// </summary>
        /// <value>The Id of the user with whom the personal account is shared.</value>

        [DataMember(Name="SharedWithId")]
        public int? SharedWithId { get; set; }

        /// <summary>
        /// Expiration date of the personal account share.
        /// </summary>
        /// <value>Expiration date of the personal account share.</value>

        [DataMember(Name="ShareExpirationDate")]
        public DateTime? ShareExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalAccountShare {\n");
            sb.Append("  SharedWithId: ").Append(SharedWithId).Append("\n");
            sb.Append("  ShareExpirationDate: ").Append(ShareExpirationDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PersonalAccountShare)obj);
        }

        /// <summary>
        /// Returns true if PersonalAccountShare instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalAccountShare to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalAccountShare other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SharedWithId == other.SharedWithId ||
                    SharedWithId != null &&
                    SharedWithId.Equals(other.SharedWithId)
                ) && 
                (
                    ShareExpirationDate == other.ShareExpirationDate ||
                    ShareExpirationDate != null &&
                    ShareExpirationDate.Equals(other.ShareExpirationDate)
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
                    if (SharedWithId != null)
                    hashCode = hashCode * 59 + SharedWithId.GetHashCode();
                    if (ShareExpirationDate != null)
                    hashCode = hashCode * 59 + ShareExpirationDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PersonalAccountShare left, PersonalAccountShare right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonalAccountShare left, PersonalAccountShare right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
