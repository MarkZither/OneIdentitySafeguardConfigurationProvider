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
    /// Information about a license
    /// </summary>
    [DataContract]
    public partial class ProductLicense : IEquatable<ProductLicense>
    { 
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
        /// The name of the user that installed the license, or  null for a license that is not installed.
        /// </summary>
        /// <value>The name of the user that installed the license, or  null for a license that is not installed.</value>

        [DataMember(Name="ChangedByUserDisplayName")]
        public string ChangedByUserDisplayName { get; set; }

        /// <summary>
        /// The id of the user that installed the license, or  null for a license that is not installed.
        /// </summary>
        /// <value>The id of the user that installed the license, or  null for a license that is not installed.</value>

        [DataMember(Name="ChangedByUserId")]
        public int? ChangedByUserId { get; set; }

        /// <summary>
        /// The date and time that the license was installed, or  null if the license is not installed.
        /// </summary>
        /// <value>The date and time that the license was installed, or  null if the license is not installed.</value>

        [DataMember(Name="ChangedByDate")]
        public DateTime? ChangedByDate { get; set; }

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
            sb.Append("class ProductLicense {\n");
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
            sb.Append("  ChangedByUserDisplayName: ").Append(ChangedByUserDisplayName).Append("\n");
            sb.Append("  ChangedByUserId: ").Append(ChangedByUserId).Append("\n");
            sb.Append("  ChangedByDate: ").Append(ChangedByDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductLicense)obj);
        }

        /// <summary>
        /// Returns true if ProductLicense instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductLicense other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    ChangedByUserDisplayName == other.ChangedByUserDisplayName ||
                    ChangedByUserDisplayName != null &&
                    ChangedByUserDisplayName.Equals(other.ChangedByUserDisplayName)
                ) && 
                (
                    ChangedByUserId == other.ChangedByUserId ||
                    ChangedByUserId != null &&
                    ChangedByUserId.Equals(other.ChangedByUserId)
                ) && 
                (
                    ChangedByDate == other.ChangedByDate ||
                    ChangedByDate != null &&
                    ChangedByDate.Equals(other.ChangedByDate)
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
                    if (ChangedByUserDisplayName != null)
                    hashCode = hashCode * 59 + ChangedByUserDisplayName.GetHashCode();
                    if (ChangedByUserId != null)
                    hashCode = hashCode * 59 + ChangedByUserId.GetHashCode();
                    if (ChangedByDate != null)
                    hashCode = hashCode * 59 + ChangedByDate.GetHashCode();
                    if (PasswordManagementLicense != null)
                    hashCode = hashCode * 59 + PasswordManagementLicense.GetHashCode();
                    if (SecretsBrokerLicense != null)
                    hashCode = hashCode * 59 + SecretsBrokerLicense.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductLicense left, ProductLicense right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductLicense left, ProductLicense right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}