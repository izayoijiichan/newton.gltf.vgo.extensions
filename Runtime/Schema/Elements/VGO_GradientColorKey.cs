// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_GradientColorKey
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO Gradient ColorKey
    /// </summary>
    [Serializable]
    [JsonObject("vgo.gradient.colorKey")]
    public class VGO_GradientColorKey
    {
        /// <summary>Color of key</summary>
        [JsonProperty("color")]
        public Color4 color;

        /// <summary>Time of the key (0 - 1).</summary>
        [JsonProperty("time")]
        public float time;
    }
}
