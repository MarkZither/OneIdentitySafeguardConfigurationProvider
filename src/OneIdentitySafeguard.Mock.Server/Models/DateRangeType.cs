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
        /// Type of date range
        /// </summary>
        /// <value>Type of date range</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DateRangeType
        {
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 0,
            /// <summary>
            /// Enum Last24HoursEnum for Last24Hours
            /// </summary>
            [EnumMember(Value = "Last24Hours")]
            Last24HoursEnum = 1,
            /// <summary>
            /// Enum Last7DaysEnum for Last7Days
            /// </summary>
            [EnumMember(Value = "Last7Days")]
            Last7DaysEnum = 2,
            /// <summary>
            /// Enum Last30DaysEnum for Last30Days
            /// </summary>
            [EnumMember(Value = "Last30Days")]
            Last30DaysEnum = 3,
            /// <summary>
            /// Enum Last60DaysEnum for Last60Days
            /// </summary>
            [EnumMember(Value = "Last60Days")]
            Last60DaysEnum = 4,
            /// <summary>
            /// Enum Last90DaysEnum for Last90Days
            /// </summary>
            [EnumMember(Value = "Last90Days")]
            Last90DaysEnum = 5,
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 6        }
}
