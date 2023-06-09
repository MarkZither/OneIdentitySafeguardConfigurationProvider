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
    /// 
    /// </summary>
    [DataContract]
    public partial class ClusterOperationStatus : IEquatable<ClusterOperationStatus>
    { 
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>

        [DataMember(Name="Operation")]
        public ClusterOperation Operation { get; set; }

        /// <summary>
        /// Unique Id of the cluster member
        /// </summary>
        /// <value>Unique Id of the cluster member</value>

        [DataMember(Name="OwnerId")]
        public string OwnerId { get; set; }

        /// <summary>
        /// The timestamp when this operation started
        /// </summary>
        /// <value>The timestamp when this operation started</value>

        [DataMember(Name="Started")]
        public DateTime? Started { get; set; }

        /// <summary>
        /// Status for each node in the cluster
        /// </summary>
        /// <value>Status for each node in the cluster</value>

        [DataMember(Name="Nodes")]
        public List<ClusterOperationNodeStatus> Nodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterOperationStatus {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ClusterOperationStatus)obj);
        }

        /// <summary>
        /// Returns true if ClusterOperationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterOperationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterOperationStatus other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Operation == other.Operation ||
                    Operation != null &&
                    Operation.Equals(other.Operation)
                ) && 
                (
                    OwnerId == other.OwnerId ||
                    OwnerId != null &&
                    OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    Started == other.Started ||
                    Started != null &&
                    Started.Equals(other.Started)
                ) && 
                (
                    Nodes == other.Nodes ||
                    Nodes != null &&
                    Nodes.SequenceEqual(other.Nodes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Operation != null)
                    hashCode = hashCode * 59 + Operation.GetHashCode();
                    if (OwnerId != null)
                    hashCode = hashCode * 59 + OwnerId.GetHashCode();
                    if (Started != null)
                    hashCode = hashCode * 59 + Started.GetHashCode();
                    if (Nodes != null)
                    hashCode = hashCode * 59 + Nodes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ClusterOperationStatus left, ClusterOperationStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ClusterOperationStatus left, ClusterOperationStatus right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
