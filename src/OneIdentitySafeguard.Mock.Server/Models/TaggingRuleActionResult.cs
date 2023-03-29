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
        /// Gets or Sets TaggingRuleActionResult
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TaggingRuleActionResult
        {
            /// <summary>
            /// Enum AddTagEnum for AddTag
            /// </summary>
            [EnumMember(Value = "AddTag")]
            AddTagEnum = 0,
            /// <summary>
            /// Enum RemoveTagEnum for RemoveTag
            /// </summary>
            [EnumMember(Value = "RemoveTag")]
            RemoveTagEnum = 1,
            /// <summary>
            /// Enum AlreadyHasTagEnum for AlreadyHasTag
            /// </summary>
            [EnumMember(Value = "AlreadyHasTag")]
            AlreadyHasTagEnum = 2,
            /// <summary>
            /// Enum AlreadyMissingTagEnum for AlreadyMissingTag
            /// </summary>
            [EnumMember(Value = "AlreadyMissingTag")]
            AlreadyMissingTagEnum = 3,
            /// <summary>
            /// Enum RemoveNotAllowedEnum for RemoveNotAllowed
            /// </summary>
            [EnumMember(Value = "RemoveNotAllowed")]
            RemoveNotAllowedEnum = 4        }
}