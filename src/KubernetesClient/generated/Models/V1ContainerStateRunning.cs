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
    /// ContainerStateRunning is a running state of a container.
    /// </summary>
    public partial class V1ContainerStateRunning
    {
        /// <summary>
        /// Initializes a new instance of the V1ContainerStateRunning class.
        /// </summary>
        public V1ContainerStateRunning()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ContainerStateRunning class.
        /// </summary>
        /// <param name="startedAt">
        /// Time at which the container was last (re-)started
        /// </param>
        public V1ContainerStateRunning(System.DateTime? startedAt = null)
        {
            StartedAt = startedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Time at which the container was last (re-)started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public System.DateTime? StartedAt { get; set; }

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
