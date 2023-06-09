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
    /// Used by client applications to exchange an STS token for a Safeguard user token that will then be used by the              application for all future API requests.  A client application should make a request to the &lt;i&gt;/service/core/v2/Token/LoginResponse&lt;/i&gt;              end point, passing the &lt;i&gt;access token&lt;/i&gt; they got from the STS.  Authorization will be performed on the authenticated user              and if successful, this Pangaea.Data.Transfer.V2.Users.LoginResponse object will be returned with a new token value in              Pangaea.Data.Transfer.V2.Users.LoginResponse.UserToken.
    /// </summary>
    [DataContract]
    public partial class LoginResponse : IEquatable<LoginResponse>
    { 
        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name="Status")]
        public LoginResponseStatus Status { get; set; }

        /// <summary>
        /// Upon successful authorization, a new access token will be granted that is to be used for all future API              requests by the client application.  Currently, the lifetime of this token is one day.
        /// </summary>
        /// <value>Upon successful authorization, a new access token will be granted that is to be used for all future API              requests by the client application.  Currently, the lifetime of this token is one day.</value>

        [DataMember(Name="UserToken")]
        public string UserToken { get; set; }

        /// <summary>
        /// If the &lt;i&gt;access token&lt;/i&gt; from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user initially authenticated against.  It will need to be              included in the redirect back to the STS.
        /// </summary>
        /// <value>If the &lt;i&gt;access token&lt;/i&gt; from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user initially authenticated against.  It will need to be              included in the redirect back to the STS.</value>

        [DataMember(Name="PrimaryProviderId")]
        public string PrimaryProviderId { get; set; }

        /// <summary>
        /// If the &lt;i&gt;access token&lt;/i&gt; from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user needs for two-factor authentication.  It will need to be              included in the redirect back to the STS.
        /// </summary>
        /// <value>If the &lt;i&gt;access token&lt;/i&gt; from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user needs for two-factor authentication.  It will need to be              included in the redirect back to the STS.</value>

        [DataMember(Name="SecondaryProviderId")]
        public string SecondaryProviderId { get; set; }

        /// <summary>
        /// This is the amount of time in minutes the web client can sit idle before its session will time out.
        /// </summary>
        /// <value>This is the amount of time in minutes the web client can sit idle before its session will time out.</value>

        [DataMember(Name="WebClientInactivityTimeout")]
        public int? WebClientInactivityTimeout { get; set; }

        /// <summary>
        /// This is the amount of time in minutes the desktop client can sit idle before its session will time out.
        /// </summary>
        /// <value>This is the amount of time in minutes the desktop client can sit idle before its session will time out.</value>

        [DataMember(Name="DesktopClientInactivityTimeout")]
        public int? DesktopClientInactivityTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserToken: ").Append(UserToken).Append("\n");
            sb.Append("  PrimaryProviderId: ").Append(PrimaryProviderId).Append("\n");
            sb.Append("  SecondaryProviderId: ").Append(SecondaryProviderId).Append("\n");
            sb.Append("  WebClientInactivityTimeout: ").Append(WebClientInactivityTimeout).Append("\n");
            sb.Append("  DesktopClientInactivityTimeout: ").Append(DesktopClientInactivityTimeout).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoginResponse)obj);
        }

        /// <summary>
        /// Returns true if LoginResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginResponse other)
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
                    UserToken == other.UserToken ||
                    UserToken != null &&
                    UserToken.Equals(other.UserToken)
                ) && 
                (
                    PrimaryProviderId == other.PrimaryProviderId ||
                    PrimaryProviderId != null &&
                    PrimaryProviderId.Equals(other.PrimaryProviderId)
                ) && 
                (
                    SecondaryProviderId == other.SecondaryProviderId ||
                    SecondaryProviderId != null &&
                    SecondaryProviderId.Equals(other.SecondaryProviderId)
                ) && 
                (
                    WebClientInactivityTimeout == other.WebClientInactivityTimeout ||
                    WebClientInactivityTimeout != null &&
                    WebClientInactivityTimeout.Equals(other.WebClientInactivityTimeout)
                ) && 
                (
                    DesktopClientInactivityTimeout == other.DesktopClientInactivityTimeout ||
                    DesktopClientInactivityTimeout != null &&
                    DesktopClientInactivityTimeout.Equals(other.DesktopClientInactivityTimeout)
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
                    if (UserToken != null)
                    hashCode = hashCode * 59 + UserToken.GetHashCode();
                    if (PrimaryProviderId != null)
                    hashCode = hashCode * 59 + PrimaryProviderId.GetHashCode();
                    if (SecondaryProviderId != null)
                    hashCode = hashCode * 59 + SecondaryProviderId.GetHashCode();
                    if (WebClientInactivityTimeout != null)
                    hashCode = hashCode * 59 + WebClientInactivityTimeout.GetHashCode();
                    if (DesktopClientInactivityTimeout != null)
                    hashCode = hashCode * 59 + DesktopClientInactivityTimeout.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoginResponse left, LoginResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginResponse left, LoginResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
