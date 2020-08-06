// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_AnimationCurve
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO AnimationCurve
    /// </summary>
    [Serializable]
    [JsonObject("vgo.animationCurve")]
    public class VGO_AnimationCurve
    {
        /// <summary>All keys defined in the animation curve.</summary>
        [JsonProperty("keys")]
        public VGO_Keyframe[] keys = null;

        /// <summary>The behaviour of the animation before the first keyframe.</summary>
        [JsonProperty("preWrapMode")]
        public WrapMode preWrapMode;

        /// <summary>The behaviour of the animation after the last keyframe.</summary>
        [JsonProperty("postWrapMode")]
        public WrapMode postWrapMode;
    }
}
