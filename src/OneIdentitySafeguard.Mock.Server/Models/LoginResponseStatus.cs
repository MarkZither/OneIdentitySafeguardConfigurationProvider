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
        /// The <i>/service/core/v2/Token/LoginResponse</i> end point will return a Pangaea.Data.Transfer.V2.Users.LoginResponse object with              a Pangaea.Data.Transfer.V2.Users.LoginResponse.Status of one of these values indicating to the client application what it should do next.
        /// </summary>
        /// <value>The <i>/service/core/v2/Token/LoginResponse</i> end point will return a Pangaea.Data.Transfer.V2.Users.LoginResponse object with              a Pangaea.Data.Transfer.V2.Users.LoginResponse.Status of one of these values indicating to the client application what it should do next.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LoginResponseStatus
        {
            /// <summary>
            /// Enum SuccessEnum for Success
            /// </summary>
            [EnumMember(Value = "Success")]
            SuccessEnum = 0,
            /// <summary>
            /// Enum Needs2FAEnum for Needs2FA
            /// </summary>
            [EnumMember(Value = "Needs2FA")]
            Needs2FAEnum = 1        }
}
