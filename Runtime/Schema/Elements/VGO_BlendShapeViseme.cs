// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShapeViseme
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO BlendShape Viseme
    /// </summary>
    [Serializable]
    [JsonObject("vgo.blendshape.viseme")]
    public class VGO_BlendShapeViseme
    {
        /// <summary>The viseme.</summary>
        [JsonProperty("type")]
        public VgoBlendShapeViseme type;

        /// <summary>The index of the BlendShape.</summary>
        [JsonProperty("index")]
        public int index;
    }
}
