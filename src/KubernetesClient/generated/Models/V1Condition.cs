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
    /// Condition contains details for one aspect of the current state of this API
        /// Resource.
    /// </summary>
    public partial class V1Condition
    {
        /// <summary>
        /// Initializes a new instance of the V1Condition class.
        /// </summary>
        public V1Condition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Condition class.
        /// </summary>
        /// <param name="lastTransitionTime">
        /// lastTransitionTime is the last time the condition transitioned from one status
        /// to another. This should be when the underlying condition changed.  If that is
        /// not known, then using the time when the API field changed is acceptable.
        /// </param>
        /// <param name="message">
        /// message is a human readable message indicating details about the transition.
        /// This may be an empty string.
        /// </param>
        /// <param name="reason">
        /// reason contains a programmatic identifier indicating the reason for the
        /// condition&apos;s last transition. Producers of specific condition types may define
        /// expected values and meanings for this field, and whether the values are
        /// considered a guaranteed API. The value should be a CamelCase string. This field
        /// may not be empty.
        /// </param>
        /// <param name="status">
        /// status of the condition, one of True, False, Unknown.
        /// </param>
        /// <param name="type">
        /// type of condition in CamelCase or in foo.example.com/CamelCase.
        /// </param>
        /// <param name="observedGeneration">
        /// observedGeneration represents the .metadata.generation that the condition was
        /// set based upon. For instance, if .metadata.generation is currently 12, but the
        /// .status.conditions[x].observedGeneration is 9, the condition is out of date with
        /// respect to the current state of the instance.
        /// </param>
        public V1Condition(System.DateTime lastTransitionTime, string message, string reason, string status, string type, long? observedGeneration = null)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            ObservedGeneration = observedGeneration;
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
        /// lastTransitionTime is the last time the condition transitioned from one status
        /// to another. This should be when the underlying condition changed.  If that is
        /// not known, then using the time when the API field changed is acceptable.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime LastTransitionTime { get; set; }

        /// <summary>
        /// message is a human readable message indicating details about the transition.
        /// This may be an empty string.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// observedGeneration represents the .metadata.generation that the condition was
        /// set based upon. For instance, if .metadata.generation is currently 12, but the
        /// .status.conditions[x].observedGeneration is 9, the condition is out of date with
        /// respect to the current state of the instance.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// reason contains a programmatic identifier indicating the reason for the
        /// condition&apos;s last transition. Producers of specific condition types may define
        /// expected values and meanings for this field, and whether the values are
        /// considered a guaranteed API. The value should be a CamelCase string. This field
        /// may not be empty.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// type of condition in CamelCase or in foo.example.com/CamelCase.
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
