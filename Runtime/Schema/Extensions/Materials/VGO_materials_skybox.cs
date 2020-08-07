﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_materials_skybox
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Skybox shader properties
    /// </summary>
    [Serializable]
    [JsonObject("material.extensions.VGO_materials_skybox")]
    public class VGO_materials_skybox
    {
        /// <summary></summary>
        [JsonProperty("sunDisk", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(SkyboxSunDisk.None)]
        public SkyboxSunDisk sunDisk = SkyboxSunDisk.None;

        /// <summary></summary>
        [JsonProperty("sunSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f, 1.0f)]
        public float sunSize = -1.0f;

        /// <summary></summary>
        [JsonProperty("sunSizeConvergence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        //[Range(1f, 10f)]
        public int sunSizeConvergence = -1;

        /// <summary></summary>
        [JsonProperty("atmosphereThickness", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f, 5.0f)]
        public float atmosphereThickness = -1.0f;

        /// <summary></summary>
        [JsonProperty("tint")]
        public Color4? tint;

        /// <summary></summary>
        [JsonProperty("skyTint")]
        public Color4? skyTint;

        /// <summary></summary>
        [JsonProperty("groundColor")]
        public Color4? groundColor;

        /// <summary></summary>
        [JsonProperty("exposure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f, 8.0f)]
        public float exposure = -1.0f;

        /// <summary></summary>
        [JsonProperty("rotation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        //[Range(0f, 360f)]
        public int rotation = -1;

        /// <summary></summary>
        [JsonProperty("frontTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int frontTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("backTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int backTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("leftTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int leftTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("rightTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int rightTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("upTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int upTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("downTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int downTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("texIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int texIndex = -1;

        /// <summary></summary>
        [JsonProperty("mainTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int mainTexIndex = -1;

        /// <summary></summary>
        [JsonProperty("mapping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(SkyboxMapping.SixFramesLayout)]
        public SkyboxMapping mapping = SkyboxMapping.SixFramesLayout;

        /// <summary></summary>
        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(SkyboxImageType.Degrees360)]
        public SkyboxImageType imageType = SkyboxImageType.Degrees360;

        /// <summary></summary>
        [JsonProperty("mirrorOnBack", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(false)]
        public bool mirrorOnBack;

        /// <summary></summary>
        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(SkyboxLayout.None)]
        public SkyboxLayout layout = SkyboxLayout.None;

        [JsonIgnore]
        public static string ExtensionName => "VGO_materials_skybox";
    }
}
