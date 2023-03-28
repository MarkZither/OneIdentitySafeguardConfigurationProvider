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
        /// Type of file transfer protocol
        /// </summary>
        /// <value>Type of file transfer protocol</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransferProtocolType
        {
            /// <summary>
            /// Enum SmbEnum for Smb
            /// </summary>
            [EnumMember(Value = "Smb")]
            SmbEnum = 0,
            /// <summary>
            /// Enum ScpEnum for Scp
            /// </summary>
            [EnumMember(Value = "Scp")]
            ScpEnum = 1,
            /// <summary>
            /// Enum SftpEnum for Sftp
            /// </summary>
            [EnumMember(Value = "Sftp")]
            SftpEnum = 2        }
}
