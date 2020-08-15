// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : Gltf_VGO
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// glTF VGO
    /// </summary>
    [Serializable]
    [JsonObject("vgo")]
    public class Gltf_VGO
    {
        /// <summary>VGO Meta</summary>
        [JsonProperty("meta", Required = Required.Default)]
        public Gltf_VGO_Meta meta = null;

        /// <summary>VGO Right</summary>
        [JsonProperty("right", Required = Required.Default)]
        public Gltf_VGO_Right right = null;

        /// <summary>Avatar</summary>
        [JsonProperty("avatar")]
        public VGO_HumanAvatar avatar = null;

        /// <summary></summary>
        [JsonIgnore]
        public static string ExtensionName => "VGO";
    }
}