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
        /// Gets or Sets PrincipalKind
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PrincipalKind
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum ServiceEnum for Service
            /// </summary>
            [EnumMember(Value = "Service")]
            ServiceEnum = 1,
            /// <summary>
            /// Enum UserEnum for User
            /// </summary>
            [EnumMember(Value = "User")]
            UserEnum = 2,
            /// <summary>
            /// Enum GroupEnum for Group
            /// </summary>
            [EnumMember(Value = "Group")]
            GroupEnum = 3        }
}
