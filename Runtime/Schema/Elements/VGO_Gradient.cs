﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_Gradient
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// VGO Gradient
    /// </summary>
    [Serializable]
    [JsonObject("vgo.gradient")]
    public class VGO_Gradient
    {
        /// <summary>All color keys defined in the gradient.</summary>
        [JsonProperty("colorKeys")]
        public VGO_GradientColorKey[] colorKeys = null;

        /// <summary>All alpha keys defined in the gradient.</summary>
        [JsonProperty("alphaKeys")]
        public VGO_GradientAlphaKey[] alphaKeys = null;

        /// <summary>Control how the gradient is evaluated.</summary>
        [JsonProperty("mode")]
        public GradientMode mode;
    }
}
