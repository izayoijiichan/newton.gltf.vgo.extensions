// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_HumanBone
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO Human Bone
    /// </summary>
    [Serializable]
    [JsonObject("vgo.humanBone")]
    public class VGO_HumanBone
    {
        /// <summary></summary>
        [JsonProperty("humanBodyBone")]
        public HumanBodyBones humanBodyBone;

        /// <summary>The index of the node.</summary>
        [JsonProperty("nodeIndex")]
        public int nodeIndex;
    }
}