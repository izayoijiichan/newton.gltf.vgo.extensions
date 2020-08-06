// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_materials_particle
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.Numerics;
    using VgoGltf;

    #region Enums

    /// <summary></summary>
    public enum ParticleBlendMode
    {
        /// <summary></summary>
        Opaque = 0,
        /// <summary></summary>
        Cutout = 1,
        /// <summary></summary>
        Fade = 2,
        /// <summary></summary>
        Transparent = 3,
        /// <summary></summary>
        Additive = 4,
        /// <summary></summary>
        Subtractive = 5,
        /// <summary></summary>
        Modulate = 6,
    }

    /// <summary></summary>
    public enum ParticleColorMode
    {
        /// <summary></summary>
        Multiply = 0,
        /// <summary></summary>
        Additive = 1,
        /// <summary></summary>
        Subtractive = 2,
        /// <summary></summary>
        Overlay = 3,
        /// <summary></summary>
        Color = 4,
        /// <summary></summary>
        Difference = 5,
    }

    /// <summary></summary>
    public enum ParticleFlipBookMode
    {
        /// <summary></summary>
        Simple = 0,
        /// <summary></summary>
        Blended = 1,
    }

    #endregion

    /// <summary>
    /// Particles/Standard shader properties
    /// </summary>
    [Serializable]
    [JsonObject("material.extensions.VGO_materials_particle")]
    public class VGO_materials_particle
    {
        /// <summary></summary>
        [JsonProperty("renderMode")]
        public ParticleBlendMode renderMode;

        /// <summary></summary>
        [JsonProperty("colorMode")]
        public ParticleColorMode colorMode;

        /// <summary></summary>
        [JsonProperty("flipBookMode")]
        public ParticleFlipBookMode flipBookMode;

        /// <summary></summary>
        [JsonProperty("cullMode")]
        public CullMode cullMode;

        /// <summary></summary>
        [JsonProperty("softParticlesEnabled")]
        public bool softParticlesEnabled;

        /// <summary></summary>
        [JsonProperty("softParticleFadeParams")]
        public Vector4? softParticleFadeParams;

        /// <summary></summary>
        [JsonProperty("cameraFadingEnabled")]
        public bool cameraFadingEnabled;

        /// <summary></summary>
        [JsonProperty("cameraFadeParams")]
        public Vector4? cameraFadeParams;

        /// <summary></summary>
        [JsonProperty("distortionEnabled")]
        public bool distortionEnabled;

        /// <summary></summary>
        [JsonProperty("grabTextureIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int grabTextureIndex = -1;

        /// <summary></summary>
        [JsonProperty("distortionStrengthScaled")]
        public float distortionStrengthScaled;

        /// <summary></summary>
        [JsonProperty("distortionBlend")]
        public float distortionBlend;

        /// <summary></summary>
        [JsonProperty("colorAddSubDiff")]
        public Color4? colorAddSubDiff;

        /// <summary></summary>
        [JsonProperty("mainTexIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int mainTexIndex = -1;

        /// <summary>Tiling(Scale)[2], Offset[2]</summary>
        [JsonProperty("mainTexSt")]
        public Vector4? mainTexSt;

        /// <summary></summary>
        [JsonProperty("color")]
        public Color4? color;

        /// <summary></summary>
        [JsonProperty("cutoff")]
        public float cutoff;

        /// <summary></summary>
        [JsonProperty("metallicGlossMapIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int metallicGlossMapIndex = -1;

        /// <summary></summary>
        [JsonProperty("metallic")]
        public float metallic;

        /// <summary></summary>
        [JsonProperty("glossiness")]
        public float glossiness;

        /// <summary></summary>
        [JsonProperty("bumpMapIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int bumpMapIndex = -1;

        /// <summary></summary>
        [JsonProperty("bumpScale")]
        public float bumpScale;

        /// <summary></summary>
        [JsonProperty("lightingEnabled")]
        public bool lightingEnabled;

        /// <summary></summary>
        [JsonProperty("emissionEnabled")]
        public bool emissionEnabled;

        /// <summary></summary>
        [JsonProperty("emissionColor")]
        public Color3? emissionColor;

        /// <summary></summary>
        [JsonProperty("emissionMapIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int emissionMapIndex = -1;

        [JsonIgnore]
        public static string ExtensionName => "VGO_materials_particle";
    }
}
