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
        /// The type of profile schedule
        /// </summary>
        /// <value>The type of profile schedule</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ProfileScheduleType
        {
            /// <summary>
            /// Enum AccountDiscoveryEnum for AccountDiscovery
            /// </summary>
            [EnumMember(Value = "AccountDiscovery")]
            AccountDiscoveryEnum = 0,
            /// <summary>
            /// Enum AssetDiscoveryEnum for AssetDiscovery
            /// </summary>
            [EnumMember(Value = "AssetDiscovery")]
            AssetDiscoveryEnum = 1,
            /// <summary>
            /// Enum ChangePasswordEnum for ChangePassword
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            ChangePasswordEnum = 2,
            /// <summary>
            /// Enum CheckPasswordEnum for CheckPassword
            /// </summary>
            [EnumMember(Value = "CheckPassword")]
            CheckPasswordEnum = 3,
            /// <summary>
            /// Enum ChangeSshKeyEnum for ChangeSshKey
            /// </summary>
            [EnumMember(Value = "ChangeSshKey")]
            ChangeSshKeyEnum = 4,
            /// <summary>
            /// Enum CheckSshKeyEnum for CheckSshKey
            /// </summary>
            [EnumMember(Value = "CheckSshKey")]
            CheckSshKeyEnum = 5,
            /// <summary>
            /// Enum SshKeyDiscoveryEnum for SshKeyDiscovery
            /// </summary>
            [EnumMember(Value = "SshKeyDiscovery")]
            SshKeyDiscoveryEnum = 6        }
}
