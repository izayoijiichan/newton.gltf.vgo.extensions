// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShapeBlink
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO BlendShape Blink
    /// </summary>
    [Serializable]
    [JsonObject("vgo.blendshape.blink")]
    public class VGO_BlendShapeBlink
    {
        /// <summary>The type of blink.</summary>
        [JsonProperty("type")]
        public VgoBlendShapeBlinkType type;

        /// <summary>The index of the BlendShape.</summary>
        [JsonProperty("index")]
        public int index;
    }
}
