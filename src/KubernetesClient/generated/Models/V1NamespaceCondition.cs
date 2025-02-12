// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// NamespaceCondition contains details about state of namespace.
    /// </summary>
    public partial class V1NamespaceCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1NamespaceCondition class.
        /// </summary>
        public V1NamespaceCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NamespaceCondition class.
        /// </summary>
        /// <param name="status">
        /// Status of the condition, one of True, False, Unknown.
        /// </param>
        /// <param name="type">
        /// Type of namespace controller condition.
        /// </param>
        /// <param name="lastTransitionTime">
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and
        /// JSON.  Wrappers are provided for many of the factory methods that the time
        /// package offers.
        /// </param>
        /// <param name="message">
        /// 
        /// </param>
        /// <param name="reason">
        /// 
        /// </param>
        public V1NamespaceCondition(string status, string type, System.DateTime? lastTransitionTime = null, string message = null, string reason = null)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and
        /// JSON.  Wrappers are provided for many of the factory methods that the time
        /// package offers.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of namespace controller condition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
