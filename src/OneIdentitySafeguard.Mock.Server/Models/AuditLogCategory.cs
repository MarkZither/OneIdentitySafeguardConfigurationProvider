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
        /// Categories of information provided by the ActivityLog
        /// </summary>
        /// <value>Categories of information provided by the ActivityLog</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuditLogCategory
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum ApplianceEnum for Appliance
            /// </summary>
            [EnumMember(Value = "Appliance")]
            ApplianceEnum = 1,
            /// <summary>
            /// Enum AccessRequestActivityEnum for AccessRequestActivity
            /// </summary>
            [EnumMember(Value = "AccessRequestActivity")]
            AccessRequestActivityEnum = 2,
            /// <summary>
            /// Enum LoginEnum for Login
            /// </summary>
            [EnumMember(Value = "Login")]
            LoginEnum = 3,
            /// <summary>
            /// Enum ObjectChangeEnum for ObjectChange
            /// </summary>
            [EnumMember(Value = "ObjectChange")]
            ObjectChangeEnum = 4,
            /// <summary>
            /// Enum PasswordEnum for Password
            /// </summary>
            [EnumMember(Value = "Password")]
            PasswordEnum = 5,
            /// <summary>
            /// Enum AssetDiscoveryEnum for AssetDiscovery
            /// </summary>
            [EnumMember(Value = "AssetDiscovery")]
            AssetDiscoveryEnum = 6,
            /// <summary>
            /// Enum AccountDiscoveryEnum for AccountDiscovery
            /// </summary>
            [EnumMember(Value = "AccountDiscovery")]
            AccountDiscoveryEnum = 7,
            /// <summary>
            /// Enum PatchEnum for Patch
            /// </summary>
            [EnumMember(Value = "Patch")]
            PatchEnum = 8,
            /// <summary>
            /// Enum LicenseEnum for License
            /// </summary>
            [EnumMember(Value = "License")]
            LicenseEnum = 9,
            /// <summary>
            /// Enum AccessRequestSessionsEnum for AccessRequestSessions
            /// </summary>
            [EnumMember(Value = "AccessRequestSessions")]
            AccessRequestSessionsEnum = 10,
            /// <summary>
            /// Enum ArchiveEnum for Archive
            /// </summary>
            [EnumMember(Value = "Archive")]
            ArchiveEnum = 11,
            /// <summary>
            /// Enum ServiceDiscoveryEnum for ServiceDiscovery
            /// </summary>
            [EnumMember(Value = "ServiceDiscovery")]
            ServiceDiscoveryEnum = 12,
            /// <summary>
            /// Enum DirectorySyncEnum for DirectorySync
            /// </summary>
            [EnumMember(Value = "DirectorySync")]
            DirectorySyncEnum = 13,
            /// <summary>
            /// Enum SshKeyDiscoveryEnum for SshKeyDiscovery
            /// </summary>
            [EnumMember(Value = "SshKeyDiscovery")]
            SshKeyDiscoveryEnum = 14        }
}
