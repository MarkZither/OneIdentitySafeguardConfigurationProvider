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
        /// Type of discovery condition
        /// </summary>
        /// <value>Type of discovery condition</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AssetDiscoveryConditionType
        {
            /// <summary>
            /// Enum FindAllEnum for FindAll
            /// </summary>
            [EnumMember(Value = "FindAll")]
            FindAllEnum = 0,
            /// <summary>
            /// Enum LdapFilterEnum for LdapFilter
            /// </summary>
            [EnumMember(Value = "LdapFilter")]
            LdapFilterEnum = 1,
            /// <summary>
            /// Enum PropertyConstraintEnum for PropertyConstraint
            /// </summary>
            [EnumMember(Value = "PropertyConstraint")]
            PropertyConstraintEnum = 2,
            /// <summary>
            /// Enum AdGroupMembershipEnum for AdGroupMembership
            /// </summary>
            [EnumMember(Value = "AdGroupMembership")]
            AdGroupMembershipEnum = 3        }
}
