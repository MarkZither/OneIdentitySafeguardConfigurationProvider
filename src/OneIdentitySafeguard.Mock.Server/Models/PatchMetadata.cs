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
    public partial class PatchMetadata : IEquatable<PatchMetadata>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>

        [DataMember(Name="Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OsOnlyPatch
        /// </summary>

        [DataMember(Name="OsOnlyPatch")]
        public bool? OsOnlyPatch { get; set; }

        /// <summary>
        /// Gets or Sets TargetOsLevel
        /// </summary>

        [DataMember(Name="TargetOsLevel")]
        public int? TargetOsLevel { get; set; }

        /// <summary>
        /// Gets or Sets TargetOsVersions
        /// </summary>

        [DataMember(Name="TargetOsVersions")]
        public List<string> TargetOsVersions { get; set; }

        /// <summary>
        /// Gets or Sets SupportLink
        /// </summary>

        [DataMember(Name="SupportLink")]
        public string SupportLink { get; set; }

        /// <summary>
        /// Gets or Sets PatchVersion
        /// </summary>

        [DataMember(Name="PatchVersion")]
        public PatchVersion PatchVersion { get; set; }

        /// <summary>
        /// Gets or Sets Released
        /// </summary>

        [DataMember(Name="Released")]
        public DateTime? Released { get; set; }

        /// <summary>
        /// Gets or Sets PayloadSizeBytes
        /// </summary>

        [DataMember(Name="PayloadSizeBytes")]
        public long? PayloadSizeBytes { get; set; }

        /// <summary>
        /// Gets or Sets MinimumApplianceVersion
        /// </summary>

        [DataMember(Name="MinimumApplianceVersion")]
        public PatchVersion MinimumApplianceVersion { get; set; }

        /// <summary>
        /// Gets or Sets LtsMinimumApplianceVersion
        /// </summary>

        [DataMember(Name="LtsMinimumApplianceVersion")]
        public PatchVersion LtsMinimumApplianceVersion { get; set; }

        /// <summary>
        /// Gets or Sets MaximumApplianceVersion
        /// </summary>

        [DataMember(Name="MaximumApplianceVersion")]
        public PatchVersion MaximumApplianceVersion { get; set; }

        /// <summary>
        /// Gets or Sets LtsMaximumApplianceVersion
        /// </summary>

        [DataMember(Name="LtsMaximumApplianceVersion")]
        public PatchVersion LtsMaximumApplianceVersion { get; set; }

        /// <summary>
        /// Gets or Sets LtsType
        /// </summary>

        [DataMember(Name="LtsType")]
        public string LtsType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OsOnlyPatch: ").Append(OsOnlyPatch).Append("\n");
            sb.Append("  TargetOsLevel: ").Append(TargetOsLevel).Append("\n");
            sb.Append("  TargetOsVersions: ").Append(TargetOsVersions).Append("\n");
            sb.Append("  SupportLink: ").Append(SupportLink).Append("\n");
            sb.Append("  PatchVersion: ").Append(PatchVersion).Append("\n");
            sb.Append("  Released: ").Append(Released).Append("\n");
            sb.Append("  PayloadSizeBytes: ").Append(PayloadSizeBytes).Append("\n");
            sb.Append("  MinimumApplianceVersion: ").Append(MinimumApplianceVersion).Append("\n");
            sb.Append("  LtsMinimumApplianceVersion: ").Append(LtsMinimumApplianceVersion).Append("\n");
            sb.Append("  MaximumApplianceVersion: ").Append(MaximumApplianceVersion).Append("\n");
            sb.Append("  LtsMaximumApplianceVersion: ").Append(LtsMaximumApplianceVersion).Append("\n");
            sb.Append("  LtsType: ").Append(LtsType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PatchMetadata)obj);
        }

        /// <summary>
        /// Returns true if PatchMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchMetadata other)
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
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    OsOnlyPatch == other.OsOnlyPatch ||
                    OsOnlyPatch != null &&
                    OsOnlyPatch.Equals(other.OsOnlyPatch)
                ) && 
                (
                    TargetOsLevel == other.TargetOsLevel ||
                    TargetOsLevel != null &&
                    TargetOsLevel.Equals(other.TargetOsLevel)
                ) && 
                (
                    TargetOsVersions == other.TargetOsVersions ||
                    TargetOsVersions != null &&
                    TargetOsVersions.SequenceEqual(other.TargetOsVersions)
                ) && 
                (
                    SupportLink == other.SupportLink ||
                    SupportLink != null &&
                    SupportLink.Equals(other.SupportLink)
                ) && 
                (
                    PatchVersion == other.PatchVersion ||
                    PatchVersion != null &&
                    PatchVersion.Equals(other.PatchVersion)
                ) && 
                (
                    Released == other.Released ||
                    Released != null &&
                    Released.Equals(other.Released)
                ) && 
                (
                    PayloadSizeBytes == other.PayloadSizeBytes ||
                    PayloadSizeBytes != null &&
                    PayloadSizeBytes.Equals(other.PayloadSizeBytes)
                ) && 
                (
                    MinimumApplianceVersion == other.MinimumApplianceVersion ||
                    MinimumApplianceVersion != null &&
                    MinimumApplianceVersion.Equals(other.MinimumApplianceVersion)
                ) && 
                (
                    LtsMinimumApplianceVersion == other.LtsMinimumApplianceVersion ||
                    LtsMinimumApplianceVersion != null &&
                    LtsMinimumApplianceVersion.Equals(other.LtsMinimumApplianceVersion)
                ) && 
                (
                    MaximumApplianceVersion == other.MaximumApplianceVersion ||
                    MaximumApplianceVersion != null &&
                    MaximumApplianceVersion.Equals(other.MaximumApplianceVersion)
                ) && 
                (
                    LtsMaximumApplianceVersion == other.LtsMaximumApplianceVersion ||
                    LtsMaximumApplianceVersion != null &&
                    LtsMaximumApplianceVersion.Equals(other.LtsMaximumApplianceVersion)
                ) && 
                (
                    LtsType == other.LtsType ||
                    LtsType != null &&
                    LtsType.Equals(other.LtsType)
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
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (OsOnlyPatch != null)
                    hashCode = hashCode * 59 + OsOnlyPatch.GetHashCode();
                    if (TargetOsLevel != null)
                    hashCode = hashCode * 59 + TargetOsLevel.GetHashCode();
                    if (TargetOsVersions != null)
                    hashCode = hashCode * 59 + TargetOsVersions.GetHashCode();
                    if (SupportLink != null)
                    hashCode = hashCode * 59 + SupportLink.GetHashCode();
                    if (PatchVersion != null)
                    hashCode = hashCode * 59 + PatchVersion.GetHashCode();
                    if (Released != null)
                    hashCode = hashCode * 59 + Released.GetHashCode();
                    if (PayloadSizeBytes != null)
                    hashCode = hashCode * 59 + PayloadSizeBytes.GetHashCode();
                    if (MinimumApplianceVersion != null)
                    hashCode = hashCode * 59 + MinimumApplianceVersion.GetHashCode();
                    if (LtsMinimumApplianceVersion != null)
                    hashCode = hashCode * 59 + LtsMinimumApplianceVersion.GetHashCode();
                    if (MaximumApplianceVersion != null)
                    hashCode = hashCode * 59 + MaximumApplianceVersion.GetHashCode();
                    if (LtsMaximumApplianceVersion != null)
                    hashCode = hashCode * 59 + LtsMaximumApplianceVersion.GetHashCode();
                    if (LtsType != null)
                    hashCode = hashCode * 59 + LtsType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PatchMetadata left, PatchMetadata right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PatchMetadata left, PatchMetadata right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}