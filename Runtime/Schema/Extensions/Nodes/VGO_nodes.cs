﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_nodes
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// VGO nodes
    /// </summary>
    [Serializable]
    [JsonObject("nodes.extensions.VGO_nodes")]
    public class VGO_nodes
    {
        /// <summary>GameObject</summary>
        [JsonProperty("gameObject")]
        public VGO_GameObject gameObject = null;

        /// <summary>Colliders</summary>
        [JsonProperty("colliders")]
        public List<VGO_Collider> colliders = null;

        /// <summary>Rigidbody</summary>
        [JsonProperty("rigidbody")]
        public VGO_Rigidbody rigidbody = null;

        /// <summary>BlendShape</summary>
        [JsonProperty("blendShape")]
        public VGO_BlendShape blendShape = null;

        /// <summary>Light</summary>
        [JsonProperty("light")]
        public VGO_Light light = null;

        /// <summary>ParticleSystem</summary>
        [JsonProperty("particleSystem")]
        public VGO_ParticleSystem particleSystem = null;

        /// <summary>Right</summary>
        [JsonProperty("right")]
        public Gltf_VGO_Right right = null;

        /// <summary>Skybox</summary>
        [JsonProperty("skybox")]
        public VGO_Skybox skybox = null;

        /// <summary></summary>
        [JsonIgnore]
        public static string ExtensionName => "VGO_nodes";
    }
}