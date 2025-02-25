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
    /// Adapts a Secret into a volume.
        /// 
        /// The contents of the target Secret&apos;s Data field will be presented in a volume as
        /// files using the keys in the Data field as the file names. Secret volumes support
        /// ownership management and SELinux relabeling.
    /// </summary>
    public partial class V1SecretVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1SecretVolumeSource class.
        /// </summary>
        public V1SecretVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SecretVolumeSource class.
        /// </summary>
        /// <param name="defaultMode">
        /// Optional: mode bits used to set permissions on created files by default. Must be
        /// an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML
        /// accepts both octal and decimal values, JSON requires decimal values for mode
        /// bits. Defaults to 0644. Directories within the path are not affected by this
        /// setting. This might be in conflict with other options that affect the file mode,
        /// like fsGroup, and the result can be other mode bits set.
        /// </param>
        /// <param name="items">
        /// If unspecified, each key-value pair in the Data field of the referenced Secret
        /// will be projected into the volume as a file whose name is the key and content is
        /// the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified which is not
        /// present in the Secret, the volume setup will error unless it is marked optional.
        /// Paths must be relative and may not contain the &apos;..&apos; path or start with &apos;..&apos;.
        /// </param>
        /// <param name="optional">
        /// Specify whether the Secret or its keys must be defined
        /// </param>
        /// <param name="secretName">
        /// Name of the secret in the pod&apos;s namespace to use. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </param>
        public V1SecretVolumeSource(int? defaultMode = null, IList<V1KeyToPath> items = null, bool? optional = null, string secretName = null)
        {
            DefaultMode = defaultMode;
            Items = items;
            Optional = optional;
            SecretName = secretName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Optional: mode bits used to set permissions on created files by default. Must be
        /// an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML
        /// accepts both octal and decimal values, JSON requires decimal values for mode
        /// bits. Defaults to 0644. Directories within the path are not affected by this
        /// setting. This might be in conflict with other options that affect the file mode,
        /// like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret
        /// will be projected into the volume as a file whose name is the key and content is
        /// the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified which is not
        /// present in the Secret, the volume setup will error unless it is marked optional.
        /// Paths must be relative and may not contain the &apos;..&apos; path or start with &apos;..&apos;.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<V1KeyToPath> Items { get; set; }

        /// <summary>
        /// Specify whether the Secret or its keys must be defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Name of the secret in the pod&apos;s namespace to use. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Items != null){
                foreach(var obj in Items)
                {
                    obj.Validate();
                }
            }
        }
    }
}
