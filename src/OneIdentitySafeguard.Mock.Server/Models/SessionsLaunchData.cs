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
    public partial class SessionsLaunchData : IEquatable<SessionsLaunchData>
    { 
        /// <summary>
        /// Gets or Sets Token
        /// </summary>

        [DataMember(Name="Token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>

        [DataMember(Name="SessionId")]
        public int? SessionId { get; set; }

        /// <summary>
        /// Gets or Sets SpsInitiate
        /// </summary>

        [DataMember(Name="SpsInitiate")]
        public bool? SpsInitiate { get; set; }

        /// <summary>
        /// Gets or Sets SshConnectionString
        /// </summary>

        [DataMember(Name="SshConnectionString")]
        public string SshConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets TelnetConnectionString
        /// </summary>

        [DataMember(Name="TelnetConnectionString")]
        public string TelnetConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets RdpConnectionString
        /// </summary>

        [DataMember(Name="RdpConnectionString")]
        public string RdpConnectionString { get; set; }

        /// <summary>
        /// Gets or Sets RdpConnectionFile
        /// </summary>

        [DataMember(Name="RdpConnectionFile")]
        public string RdpConnectionFile { get; set; }

        /// <summary>
        /// Gets or Sets RdpHostComputer
        /// </summary>

        [DataMember(Name="RdpHostComputer")]
        public string RdpHostComputer { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionUri
        /// </summary>

        [DataMember(Name="ConnectionUri")]
        public string ConnectionUri { get; set; }

        /// <summary>
        /// Gets or Sets SraConnectionUri
        /// </summary>

        [DataMember(Name="SraConnectionUri")]
        public string SraConnectionUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionsLaunchData {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SpsInitiate: ").Append(SpsInitiate).Append("\n");
            sb.Append("  SshConnectionString: ").Append(SshConnectionString).Append("\n");
            sb.Append("  TelnetConnectionString: ").Append(TelnetConnectionString).Append("\n");
            sb.Append("  RdpConnectionString: ").Append(RdpConnectionString).Append("\n");
            sb.Append("  RdpConnectionFile: ").Append(RdpConnectionFile).Append("\n");
            sb.Append("  RdpHostComputer: ").Append(RdpHostComputer).Append("\n");
            sb.Append("  ConnectionUri: ").Append(ConnectionUri).Append("\n");
            sb.Append("  SraConnectionUri: ").Append(SraConnectionUri).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SessionsLaunchData)obj);
        }

        /// <summary>
        /// Returns true if SessionsLaunchData instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionsLaunchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionsLaunchData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                ) && 
                (
                    SessionId == other.SessionId ||
                    SessionId != null &&
                    SessionId.Equals(other.SessionId)
                ) && 
                (
                    SpsInitiate == other.SpsInitiate ||
                    SpsInitiate != null &&
                    SpsInitiate.Equals(other.SpsInitiate)
                ) && 
                (
                    SshConnectionString == other.SshConnectionString ||
                    SshConnectionString != null &&
                    SshConnectionString.Equals(other.SshConnectionString)
                ) && 
                (
                    TelnetConnectionString == other.TelnetConnectionString ||
                    TelnetConnectionString != null &&
                    TelnetConnectionString.Equals(other.TelnetConnectionString)
                ) && 
                (
                    RdpConnectionString == other.RdpConnectionString ||
                    RdpConnectionString != null &&
                    RdpConnectionString.Equals(other.RdpConnectionString)
                ) && 
                (
                    RdpConnectionFile == other.RdpConnectionFile ||
                    RdpConnectionFile != null &&
                    RdpConnectionFile.Equals(other.RdpConnectionFile)
                ) && 
                (
                    RdpHostComputer == other.RdpHostComputer ||
                    RdpHostComputer != null &&
                    RdpHostComputer.Equals(other.RdpHostComputer)
                ) && 
                (
                    ConnectionUri == other.ConnectionUri ||
                    ConnectionUri != null &&
                    ConnectionUri.Equals(other.ConnectionUri)
                ) && 
                (
                    SraConnectionUri == other.SraConnectionUri ||
                    SraConnectionUri != null &&
                    SraConnectionUri.Equals(other.SraConnectionUri)
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
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                    if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                    if (SpsInitiate != null)
                    hashCode = hashCode * 59 + SpsInitiate.GetHashCode();
                    if (SshConnectionString != null)
                    hashCode = hashCode * 59 + SshConnectionString.GetHashCode();
                    if (TelnetConnectionString != null)
                    hashCode = hashCode * 59 + TelnetConnectionString.GetHashCode();
                    if (RdpConnectionString != null)
                    hashCode = hashCode * 59 + RdpConnectionString.GetHashCode();
                    if (RdpConnectionFile != null)
                    hashCode = hashCode * 59 + RdpConnectionFile.GetHashCode();
                    if (RdpHostComputer != null)
                    hashCode = hashCode * 59 + RdpHostComputer.GetHashCode();
                    if (ConnectionUri != null)
                    hashCode = hashCode * 59 + ConnectionUri.GetHashCode();
                    if (SraConnectionUri != null)
                    hashCode = hashCode * 59 + SraConnectionUri.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SessionsLaunchData left, SessionsLaunchData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SessionsLaunchData left, SessionsLaunchData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
