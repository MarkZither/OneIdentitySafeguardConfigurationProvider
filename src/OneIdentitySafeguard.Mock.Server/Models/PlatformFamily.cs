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
        /// Gets or Sets PlatformFamily
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PlatformFamily
        {
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 0,
            /// <summary>
            /// Enum WindowsEnum for Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            WindowsEnum = 1,
            /// <summary>
            /// Enum LinuxEnum for Linux
            /// </summary>
            [EnumMember(Value = "Linux")]
            LinuxEnum = 2,
            /// <summary>
            /// Enum AIXEnum for AIX
            /// </summary>
            [EnumMember(Value = "AIX")]
            AIXEnum = 3,
            /// <summary>
            /// Enum SolarisEnum for Solaris
            /// </summary>
            [EnumMember(Value = "Solaris")]
            SolarisEnum = 4,
            /// <summary>
            /// Enum HPUXEnum for HPUX
            /// </summary>
            [EnumMember(Value = "HPUX")]
            HPUXEnum = 5,
            /// <summary>
            /// Enum OSXEnum for OSX
            /// </summary>
            [EnumMember(Value = "OSX")]
            OSXEnum = 6,
            /// <summary>
            /// Enum AS400Enum for AS400
            /// </summary>
            [EnumMember(Value = "AS400")]
            AS400Enum = 7,
            /// <summary>
            /// Enum CiscoEnum for Cisco
            /// </summary>
            [EnumMember(Value = "Cisco")]
            CiscoEnum = 8,
            /// <summary>
            /// Enum IDRACEnum for iDRAC
            /// </summary>
            [EnumMember(Value = "iDRAC")]
            IDRACEnum = 9,
            /// <summary>
            /// Enum FortinetEnum for Fortinet
            /// </summary>
            [EnumMember(Value = "Fortinet")]
            FortinetEnum = 10,
            /// <summary>
            /// Enum FreeBsdEnum for FreeBsd
            /// </summary>
            [EnumMember(Value = "FreeBsd")]
            FreeBsdEnum = 11,
            /// <summary>
            /// Enum HPiLOEnum for HPiLO
            /// </summary>
            [EnumMember(Value = "HPiLO")]
            HPiLOEnum = 12,
            /// <summary>
            /// Enum JunOSEnum for JunOS
            /// </summary>
            [EnumMember(Value = "JunOS")]
            JunOSEnum = 13,
            /// <summary>
            /// Enum OpenLdapEnum for OpenLdap
            /// </summary>
            [EnumMember(Value = "OpenLdap")]
            OpenLdapEnum = 14,
            /// <summary>
            /// Enum ACF2Enum for ACF2
            /// </summary>
            [EnumMember(Value = "ACF2")]
            ACF2Enum = 15,
            /// <summary>
            /// Enum RACFEnum for RACF
            /// </summary>
            [EnumMember(Value = "RACF")]
            RACFEnum = 16,
            /// <summary>
            /// Enum RacfLdapEnum for RacfLdap
            /// </summary>
            [EnumMember(Value = "RacfLdap")]
            RacfLdapEnum = 17,
            /// <summary>
            /// Enum TopSecretEnum for TopSecret
            /// </summary>
            [EnumMember(Value = "TopSecret")]
            TopSecretEnum = 18,
            /// <summary>
            /// Enum SqlServerEnum for SqlServer
            /// </summary>
            [EnumMember(Value = "SqlServer")]
            SqlServerEnum = 19,
            /// <summary>
            /// Enum MySQLEnum for MySQL
            /// </summary>
            [EnumMember(Value = "MySQL")]
            MySQLEnum = 20,
            /// <summary>
            /// Enum OracleEnum for Oracle
            /// </summary>
            [EnumMember(Value = "Oracle")]
            OracleEnum = 21,
            /// <summary>
            /// Enum PanOSEnum for PanOS
            /// </summary>
            [EnumMember(Value = "PanOS")]
            PanOSEnum = 22,
            /// <summary>
            /// Enum SAPEnum for SAP
            /// </summary>
            [EnumMember(Value = "SAP")]
            SAPEnum = 23,
            /// <summary>
            /// Enum SonicOsEnum for SonicOs
            /// </summary>
            [EnumMember(Value = "SonicOs")]
            SonicOsEnum = 24,
            /// <summary>
            /// Enum SybaseEnum for Sybase
            /// </summary>
            [EnumMember(Value = "Sybase")]
            SybaseEnum = 25,
            /// <summary>
            /// Enum VSphereEnum for VSphere
            /// </summary>
            [EnumMember(Value = "VSphere")]
            VSphereEnum = 26,
            /// <summary>
            /// Enum MicrosoftADEnum for MicrosoftAD
            /// </summary>
            [EnumMember(Value = "MicrosoftAD")]
            MicrosoftADEnum = 27,
            /// <summary>
            /// Enum SonicWallSmaEnum for SonicWallSma
            /// </summary>
            [EnumMember(Value = "SonicWallSma")]
            SonicWallSmaEnum = 28,
            /// <summary>
            /// Enum TwitterEnum for Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            TwitterEnum = 29,
            /// <summary>
            /// Enum HPiLOMPEnum for HPiLOMP
            /// </summary>
            [EnumMember(Value = "HPiLOMP")]
            HPiLOMPEnum = 30,
            /// <summary>
            /// Enum AwsEnum for Aws
            /// </summary>
            [EnumMember(Value = "Aws")]
            AwsEnum = 31,
            /// <summary>
            /// Enum FacebookEnum for Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            FacebookEnum = 32,
            /// <summary>
            /// Enum F5BigIpEnum for F5BigIp
            /// </summary>
            [EnumMember(Value = "F5BigIp")]
            F5BigIpEnum = 33,
            /// <summary>
            /// Enum MongoDBEnum for MongoDB
            /// </summary>
            [EnumMember(Value = "MongoDB")]
            MongoDBEnum = 34,
            /// <summary>
            /// Enum PostgreSQLEnum for PostgreSQL
            /// </summary>
            [EnumMember(Value = "PostgreSQL")]
            PostgreSQLEnum = 35,
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 36,
            /// <summary>
            /// Enum WindowsSshEnum for WindowsSsh
            /// </summary>
            [EnumMember(Value = "WindowsSsh")]
            WindowsSshEnum = 37,
            /// <summary>
            /// Enum CheckPointEnum for CheckPoint
            /// </summary>
            [EnumMember(Value = "CheckPoint")]
            CheckPointEnum = 38,
            /// <summary>
            /// Enum StarlingConnectEnum for StarlingConnect
            /// </summary>
            [EnumMember(Value = "StarlingConnect")]
            StarlingConnectEnum = 39,
            /// <summary>
            /// Enum CiscoISECLIEnum for CiscoISECLI
            /// </summary>
            [EnumMember(Value = "CiscoISECLI")]
            CiscoISECLIEnum = 40,
            /// <summary>
            /// Enum CiscoISEEnum for CiscoISE
            /// </summary>
            [EnumMember(Value = "CiscoISE")]
            CiscoISEEnum = 41,
            /// <summary>
            /// Enum WindowsRmEnum for WindowsRm
            /// </summary>
            [EnumMember(Value = "WindowsRm")]
            WindowsRmEnum = 42,
            /// <summary>
            /// Enum CiscoNxOsEnum for CiscoNxOs
            /// </summary>
            [EnumMember(Value = "CiscoNxOs")]
            CiscoNxOsEnum = 43,
            /// <summary>
            /// Enum StarlingDirectoryEnum for StarlingDirectory
            /// </summary>
            [EnumMember(Value = "StarlingDirectory")]
            StarlingDirectoryEnum = 44,
            /// <summary>
            /// Enum SapHanaEnum for SapHana
            /// </summary>
            [EnumMember(Value = "SapHana")]
            SapHanaEnum = 45        }
}
