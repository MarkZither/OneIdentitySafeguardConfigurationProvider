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
        /// Audit log access request types
        /// </summary>
        /// <value>Audit log access request types</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuditLogDiscoveryType
        {
            /// <summary>
            /// Enum AccountsEnum for Accounts
            /// </summary>
            [EnumMember(Value = "Accounts")]
            AccountsEnum = 0,
            /// <summary>
            /// Enum AssetsEnum for Assets
            /// </summary>
            [EnumMember(Value = "Assets")]
            AssetsEnum = 1,
            /// <summary>
            /// Enum ServicesEnum for Services
            /// </summary>
            [EnumMember(Value = "Services")]
            ServicesEnum = 2,
            /// <summary>
            /// Enum SshKeysEnum for SshKeys
            /// </summary>
            [EnumMember(Value = "SshKeys")]
            SshKeysEnum = 3        }
}
