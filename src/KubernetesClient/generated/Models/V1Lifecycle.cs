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
    /// Lifecycle describes actions that the management system should take in response
        /// to container lifecycle events. For the PostStart and PreStop lifecycle handlers,
        /// management of the container blocks until the action is complete, unless the
        /// container process fails, in which case the handler is aborted.
    /// </summary>
    public partial class V1Lifecycle
    {
        /// <summary>
        /// Initializes a new instance of the V1Lifecycle class.
        /// </summary>
        public V1Lifecycle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Lifecycle class.
        /// </summary>
        /// <param name="postStart">
        /// PostStart is called immediately after a container is created. If the handler
        /// fails, the container is terminated and restarted according to its restart
        /// policy. Other management of the container blocks until the hook completes. More
        /// info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </param>
        /// <param name="preStop">
        /// PreStop is called immediately before a container is terminated due to an API
        /// request or management event such as liveness/startup probe failure, preemption,
        /// resource contention, etc. The handler is not called if the container crashes or
        /// exits. The reason for termination is passed to the handler. The Pod&apos;s
        /// termination grace period countdown begins before the PreStop hooked is executed.
        /// Regardless of the outcome of the handler, the container will eventually
        /// terminate within the Pod&apos;s termination grace period. Other management of the
        /// container blocks until the hook completes or until the termination grace period
        /// is reached. More info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </param>
        public V1Lifecycle(V1Handler postStart = null, V1Handler preStop = null)
        {
            PostStart = postStart;
            PreStop = preStop;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// PostStart is called immediately after a container is created. If the handler
        /// fails, the container is terminated and restarted according to its restart
        /// policy. Other management of the container blocks until the hook completes. More
        /// info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [JsonProperty(PropertyName = "postStart")]
        public V1Handler PostStart { get; set; }

        /// <summary>
        /// PreStop is called immediately before a container is terminated due to an API
        /// request or management event such as liveness/startup probe failure, preemption,
        /// resource contention, etc. The handler is not called if the container crashes or
        /// exits. The reason for termination is passed to the handler. The Pod&apos;s
        /// termination grace period countdown begins before the PreStop hooked is executed.
        /// Regardless of the outcome of the handler, the container will eventually
        /// terminate within the Pod&apos;s termination grace period. Other management of the
        /// container blocks until the hook completes or until the termination grace period
        /// is reached. More info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [JsonProperty(PropertyName = "preStop")]
        public V1Handler PreStop { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            PostStart?.Validate();
            PreStop?.Validate();
        }
    }
}
