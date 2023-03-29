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
        /// State of the current request
        /// </summary>
        /// <value>State of the current request</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RequestState
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum QueuedEnum for Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            QueuedEnum = 1,
            /// <summary>
            /// Enum RunningEnum for Running
            /// </summary>
            [EnumMember(Value = "Running")]
            RunningEnum = 2,
            /// <summary>
            /// Enum SuccessEnum for Success
            /// </summary>
            [EnumMember(Value = "Success")]
            SuccessEnum = 3,
            /// <summary>
            /// Enum FailureEnum for Failure
            /// </summary>
            [EnumMember(Value = "Failure")]
            FailureEnum = 4,
            /// <summary>
            /// Enum CancelledEnum for Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            CancelledEnum = 5,
            /// <summary>
            /// Enum AcceptedEnum for Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            AcceptedEnum = 6,
            /// <summary>
            /// Enum RejectedEnum for Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            RejectedEnum = 7,
            /// <summary>
            /// Enum ReceivedEnum for Received
            /// </summary>
            [EnumMember(Value = "Received")]
            ReceivedEnum = 8        }
}