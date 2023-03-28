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
        /// Type of ticket system
        /// </summary>
        /// <value>Type of ticket system</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TicketSystemType
        {
            /// <summary>
            /// Enum ServiceNowEnum for ServiceNow
            /// </summary>
            [EnumMember(Value = "ServiceNow")]
            ServiceNowEnum = 0,
            /// <summary>
            /// Enum RemedyEnum for Remedy
            /// </summary>
            [EnumMember(Value = "Remedy")]
            RemedyEnum = 1,
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 2        }
}
