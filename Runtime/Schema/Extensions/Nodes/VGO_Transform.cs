// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_Transform
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Numerics;

    /// <summary>
    /// glTF Node Transform
    /// </summary>
    [Serializable]
    [JsonObject("node.vgo.transform")]
    public class VGO_Transform
    {
        /// <summary>Position of the transform relative to the parent transform.</summary>
        [JsonProperty("position")]
        public Vector3? position = null;

        /// <summary>The rotation of the transform relative to the transform rotation of the parent.</summary>
        [JsonProperty("rotation")]
        public Quaternion? rotation = null;

        /// <summary>The scale of the transform relative to the GameObjects parent.</summary>
        [JsonProperty("scale")]
        public Vector3? scale = null;
    }
}
