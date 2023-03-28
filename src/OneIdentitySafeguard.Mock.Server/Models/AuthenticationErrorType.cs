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
        /// Types of authentication failures
        /// </summary>
        /// <value>Types of authentication failures</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuthenticationErrorType
        {
            /// <summary>
            /// Enum NoErrorEnum for NoError
            /// </summary>
            [EnumMember(Value = "NoError")]
            NoErrorEnum = 0,
            /// <summary>
            /// Enum UserIsDisabledEnum for UserIsDisabled
            /// </summary>
            [EnumMember(Value = "UserIsDisabled")]
            UserIsDisabledEnum = 1,
            /// <summary>
            /// Enum BadPasswordEnum for BadPassword
            /// </summary>
            [EnumMember(Value = "BadPassword")]
            BadPasswordEnum = 2,
            /// <summary>
            /// Enum UserIsLockedEnum for UserIsLocked
            /// </summary>
            [EnumMember(Value = "UserIsLocked")]
            UserIsLockedEnum = 3,
            /// <summary>
            /// Enum PasswordExpiredEnum for PasswordExpired
            /// </summary>
            [EnumMember(Value = "PasswordExpired")]
            PasswordExpiredEnum = 4,
            /// <summary>
            /// Enum AccessDeniedEnum for AccessDenied
            /// </summary>
            [EnumMember(Value = "AccessDenied")]
            AccessDeniedEnum = 5,
            /// <summary>
            /// Enum UserIsUnknownEnum for UserIsUnknown
            /// </summary>
            [EnumMember(Value = "UserIsUnknown")]
            UserIsUnknownEnum = 6,
            /// <summary>
            /// Enum InvalidTokenEnum for InvalidToken
            /// </summary>
            [EnumMember(Value = "InvalidToken")]
            InvalidTokenEnum = 7,
            /// <summary>
            /// Enum ChangePasswordEnum for ChangePassword
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            ChangePasswordEnum = 8        }
}
