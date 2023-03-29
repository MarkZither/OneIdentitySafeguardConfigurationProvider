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
        /// Mutually exclusive, customer selected ways of protecting a backup.
        /// </summary>
        /// <value>Mutually exclusive, customer selected ways of protecting a backup.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BackupProtectionType
        {
            /// <summary>
            /// Enum ApplianceEnum for Appliance
            /// </summary>
            [EnumMember(Value = "Appliance")]
            ApplianceEnum = 0,
            /// <summary>
            /// Enum PasswordEnum for Password
            /// </summary>
            [EnumMember(Value = "Password")]
            PasswordEnum = 1,
            /// <summary>
            /// Enum GpgEnum for Gpg
            /// </summary>
            [EnumMember(Value = "Gpg")]
            GpgEnum = 2        }
}