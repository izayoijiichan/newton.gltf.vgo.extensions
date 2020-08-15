// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShapeFacePart
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO BlendShape Face Part
    /// </summary>
    [Serializable]
    [JsonObject("vgo.blendshape.facepart")]
    public class VGO_BlendShapeFacePart
    {
        /// <summary>The index of the BlendShape.</summary>
        [JsonProperty("index")]
        public int index;

        /// <summary>The type of the BlendShape.</summary>
        [JsonProperty("type")]
        public VgoBlendShapeFacePartsType type;
    }
}
