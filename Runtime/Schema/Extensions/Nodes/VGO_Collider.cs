// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_Collider
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.ComponentModel;
    using System.Numerics;

    /// <summary>Collider Type</summary>
    public enum ColliderType
    {
        /// <summary>Box Collier</summary>
        Box = 0,
        /// <summary>Capsule Collier</summary>
        Capsule = 1,
        /// <summary>Sphere Collier</summary>
        Sphere = 2,
    }

    /// <summary>
    /// glTF Node VGO Collider
    /// </summary>
    [Serializable]
    [JsonObject("node.vgo.collider")]
    public class VGO_Collider
    {
        /// <summary>Enabled</summary>
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(true)]
        public bool enabled = false;

        /// <summary>Type</summary>
        [JsonProperty("type", Required = Required.Always)]
        public ColliderType type = default;

        /// <summary>Is Trigger</summary>
        [JsonProperty("isTrigger")]
        public bool isTrigger = false;

        /// <summary>Center</summary>
        [JsonProperty("center")]
        public Vector3? center = null;

        /// <summary>Size</summary>
        [JsonProperty("size")]
        public Vector3? size = null;

        /// <summary>Radius</summary>
        [JsonProperty("radius", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        public float radius = -1.0f;

        /// <summary>Height</summary>
        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        public float height = -1.0f;

        /// <summary>Direction</summary>
        [JsonProperty("direction", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int direction = -1;

        /// <summary>Physic Material</summary>
        [JsonProperty("physicMaterial")]
        public VGO_PhysicMaterial physicMaterial = null;
    }
}