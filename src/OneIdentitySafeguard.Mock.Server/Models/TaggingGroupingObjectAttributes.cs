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
        /// Gets or Sets TaggingGroupingObjectAttributes
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TaggingGroupingObjectAttributes
        {
            /// <summary>
            /// Enum NameEnum for Name
            /// </summary>
            [EnumMember(Value = "Name")]
            NameEnum = 0,
            /// <summary>
            /// Enum DescriptionEnum for Description
            /// </summary>
            [EnumMember(Value = "Description")]
            DescriptionEnum = 1,
            /// <summary>
            /// Enum PlatformEnum for Platform
            /// </summary>
            [EnumMember(Value = "Platform")]
            PlatformEnum = 2,
            /// <summary>
            /// Enum DisabledEnum for Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            DisabledEnum = 3,
            /// <summary>
            /// Enum AllowSessionRequestsEnum for AllowSessionRequests
            /// </summary>
            [EnumMember(Value = "AllowSessionRequests")]
            AllowSessionRequestsEnum = 4,
            /// <summary>
            /// Enum TagEnum for Tag
            /// </summary>
            [EnumMember(Value = "Tag")]
            TagEnum = 5,
            /// <summary>
            /// Enum PlatformNameEnum for PlatformName
            /// </summary>
            [EnumMember(Value = "PlatformName")]
            PlatformNameEnum = 6,
            /// <summary>
            /// Enum PlatformVersionEnum for PlatformVersion
            /// </summary>
            [EnumMember(Value = "PlatformVersion")]
            PlatformVersionEnum = 7,
            /// <summary>
            /// Enum AllowPasswordRequestsEnum for AllowPasswordRequests
            /// </summary>
            [EnumMember(Value = "AllowPasswordRequests")]
            AllowPasswordRequestsEnum = 8,
            /// <summary>
            /// Enum IsServiceAccountEnum for IsServiceAccount
            /// </summary>
            [EnumMember(Value = "IsServiceAccount")]
            IsServiceAccountEnum = 9,
            /// <summary>
            /// Enum DiscoveryJobNameEnum for DiscoveryJobName
            /// </summary>
            [EnumMember(Value = "DiscoveryJobName")]
            DiscoveryJobNameEnum = 10,
            /// <summary>
            /// Enum AllowSshKeyRequestsEnum for AllowSshKeyRequests
            /// </summary>
            [EnumMember(Value = "AllowSshKeyRequests")]
            AllowSshKeyRequestsEnum = 11,
            /// <summary>
            /// Enum PartitionNameEnum for PartitionName
            /// </summary>
            [EnumMember(Value = "PartitionName")]
            PartitionNameEnum = 12,
            /// <summary>
            /// Enum AssetTagEnum for AssetTag
            /// </summary>
            [EnumMember(Value = "AssetTag")]
            AssetTagEnum = 13,
            /// <summary>
            /// Enum AssetNameEnum for AssetName
            /// </summary>
            [EnumMember(Value = "AssetName")]
            AssetNameEnum = 14,
            /// <summary>
            /// Enum DomainNameEnum for DomainName
            /// </summary>
            [EnumMember(Value = "DomainName")]
            DomainNameEnum = 15,
            /// <summary>
            /// Enum NetBiosNameEnum for NetBiosName
            /// </summary>
            [EnumMember(Value = "NetBiosName")]
            NetBiosNameEnum = 16,
            /// <summary>
            /// Enum DistinguishedNameEnum for DistinguishedName
            /// </summary>
            [EnumMember(Value = "DistinguishedName")]
            DistinguishedNameEnum = 17,
            /// <summary>
            /// Enum ObjectSidEnum for ObjectSid
            /// </summary>
            [EnumMember(Value = "ObjectSid")]
            ObjectSidEnum = 18,
            /// <summary>
            /// Enum DiscoveredGroupNameEnum for DiscoveredGroupName
            /// </summary>
            [EnumMember(Value = "DiscoveredGroupName")]
            DiscoveredGroupNameEnum = 19,
            /// <summary>
            /// Enum DiscoveredGroupDistinguishedNameEnum for DiscoveredGroupDistinguishedName
            /// </summary>
            [EnumMember(Value = "DiscoveredGroupDistinguishedName")]
            DiscoveredGroupDistinguishedNameEnum = 20,
            /// <summary>
            /// Enum DirectoryContainerEnum for DirectoryContainer
            /// </summary>
            [EnumMember(Value = "DirectoryContainer")]
            DirectoryContainerEnum = 21,
            /// <summary>
            /// Enum ProfileNameEnum for ProfileName
            /// </summary>
            [EnumMember(Value = "ProfileName")]
            ProfileNameEnum = 22,
            /// <summary>
            /// Enum EffectiveProfileNameEnum for EffectiveProfileName
            /// </summary>
            [EnumMember(Value = "EffectiveProfileName")]
            EffectiveProfileNameEnum = 23,
            /// <summary>
            /// Enum NetworkAddressEnum for NetworkAddress
            /// </summary>
            [EnumMember(Value = "NetworkAddress")]
            NetworkAddressEnum = 24        }
}
