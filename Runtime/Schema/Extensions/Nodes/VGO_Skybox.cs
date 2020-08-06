// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_Skybox
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// glTF Node VGO Skybox
    /// </summary>
    [Serializable]
    [JsonObject("node.vgo.skybox")]
    public class VGO_Skybox
    {
        /// <summary>Material Index</summary>
        [JsonProperty("materialIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int materialIndex = -1;
    }
}