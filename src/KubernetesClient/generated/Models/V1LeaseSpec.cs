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
    /// LeaseSpec is a specification of a Lease.
    /// </summary>
    public partial class V1LeaseSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1LeaseSpec class.
        /// </summary>
        public V1LeaseSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1LeaseSpec class.
        /// </summary>
        /// <param name="acquireTime">
        /// acquireTime is a time when the current lease was acquired.
        /// </param>
        /// <param name="holderIdentity">
        /// holderIdentity contains the identity of the holder of a current lease.
        /// </param>
        /// <param name="leaseDurationSeconds">
        /// leaseDurationSeconds is a duration that candidates for a lease need to wait to
        /// force acquire it. This is measure against time of last observed RenewTime.
        /// </param>
        /// <param name="leaseTransitions">
        /// leaseTransitions is the number of transitions of a lease between holders.
        /// </param>
        /// <param name="renewTime">
        /// renewTime is a time when the current holder of a lease has last updated the
        /// lease.
        /// </param>
        public V1LeaseSpec(System.DateTime? acquireTime = null, string holderIdentity = null, int? leaseDurationSeconds = null, int? leaseTransitions = null, System.DateTime? renewTime = null)
        {
            AcquireTime = acquireTime;
            HolderIdentity = holderIdentity;
            LeaseDurationSeconds = leaseDurationSeconds;
            LeaseTransitions = leaseTransitions;
            RenewTime = renewTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// acquireTime is a time when the current lease was acquired.
        /// </summary>
        [JsonProperty(PropertyName = "acquireTime")]
        public System.DateTime? AcquireTime { get; set; }

        /// <summary>
        /// holderIdentity contains the identity of the holder of a current lease.
        /// </summary>
        [JsonProperty(PropertyName = "holderIdentity")]
        public string HolderIdentity { get; set; }

        /// <summary>
        /// leaseDurationSeconds is a duration that candidates for a lease need to wait to
        /// force acquire it. This is measure against time of last observed RenewTime.
        /// </summary>
        [JsonProperty(PropertyName = "leaseDurationSeconds")]
        public int? LeaseDurationSeconds { get; set; }

        /// <summary>
        /// leaseTransitions is the number of transitions of a lease between holders.
        /// </summary>
        [JsonProperty(PropertyName = "leaseTransitions")]
        public int? LeaseTransitions { get; set; }

        /// <summary>
        /// renewTime is a time when the current holder of a lease has last updated the
        /// lease.
        /// </summary>
        [JsonProperty(PropertyName = "renewTime")]
        public System.DateTime? RenewTime { get; set; }

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
