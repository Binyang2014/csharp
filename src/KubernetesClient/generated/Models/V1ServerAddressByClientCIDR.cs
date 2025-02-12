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
    /// ServerAddressByClientCIDR helps the client to determine the server address that
        /// they should use, depending on the clientCIDR that they match.
    /// </summary>
    public partial class V1ServerAddressByClientCIDR
    {
        /// <summary>
        /// Initializes a new instance of the V1ServerAddressByClientCIDR class.
        /// </summary>
        public V1ServerAddressByClientCIDR()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ServerAddressByClientCIDR class.
        /// </summary>
        /// <param name="clientCIDR">
        /// The CIDR with which clients can match their IP to figure out the server address
        /// that they should use.
        /// </param>
        /// <param name="serverAddress">
        /// Address of this server, suitable for a client that matches the above CIDR. This
        /// can be a hostname, hostname:port, IP or IP:port.
        /// </param>
        public V1ServerAddressByClientCIDR(string clientCIDR, string serverAddress)
        {
            ClientCIDR = clientCIDR;
            ServerAddress = serverAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The CIDR with which clients can match their IP to figure out the server address
        /// that they should use.
        /// </summary>
        [JsonProperty(PropertyName = "clientCIDR")]
        public string ClientCIDR { get; set; }

        /// <summary>
        /// Address of this server, suitable for a client that matches the above CIDR. This
        /// can be a hostname, hostname:port, IP or IP:port.
        /// </summary>
        [JsonProperty(PropertyName = "serverAddress")]
        public string ServerAddress { get; set; }

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
