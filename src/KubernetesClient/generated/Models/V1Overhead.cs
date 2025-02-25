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
    /// Overhead structure represents the resource overhead associated with running a
        /// pod.
    /// </summary>
    public partial class V1Overhead
    {
        /// <summary>
        /// Initializes a new instance of the V1Overhead class.
        /// </summary>
        public V1Overhead()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Overhead class.
        /// </summary>
        /// <param name="podFixed">
        /// PodFixed represents the fixed resource overhead associated with running a pod.
        /// </param>
        public V1Overhead(IDictionary<string, ResourceQuantity> podFixed = null)
        {
            PodFixed = podFixed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// PodFixed represents the fixed resource overhead associated with running a pod.
        /// </summary>
        [JsonProperty(PropertyName = "podFixed")]
        public IDictionary<string, ResourceQuantity> PodFixed { get; set; }

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
