// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShapeBinding
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// VGO BlendShape Binding
    /// </summary>
    [Serializable]
    [JsonObject("vgo.blendshape.binding")]
    public class VGO_BlendShapeBinding
    {
        /// <summary>The index of the BlendShape.</summary>
        [JsonProperty("index")]
        public int index;

        /// <summary>The weight for this BlendShape.</summary>
        [JsonProperty("weight")]
        //[Range(0.0f, 100.0f)]
        public float weight;
    }
}
