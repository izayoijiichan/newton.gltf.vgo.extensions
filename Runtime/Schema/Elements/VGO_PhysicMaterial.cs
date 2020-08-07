﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_PhysicMaterial
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using VgoGltf;

    /// <summary>
    /// glTF VGO Physic Material
    /// </summary>
    [Serializable]
    [JsonObject("vgo.physicMaterial")]
    public class VGO_PhysicMaterial
    {
        /// <summary></summary>
        [JsonProperty("dynamicFriction")]
        public float dynamicFriction;

        /// <summary></summary>
        [JsonProperty("staticFriction")]
        public float staticFriction;

        /// <summary></summary>
        [JsonProperty("bounciness")]
        public float bounciness;

        /// <summary></summary>
        [JsonProperty("frictionCombine", Required = Required.Always)]
        public PhysicMaterialCombine frictionCombine;

        /// <summary></summary>
        [JsonProperty("bounceCombine", Required = Required.Always)]
        public PhysicMaterialCombine bounceCombine;
    }
}