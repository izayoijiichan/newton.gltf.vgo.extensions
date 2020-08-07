﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_Rigidbody
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using VgoGltf;

    /// <summary>
    /// glTF Node VGO Rigidbody
    /// </summary>
    [Serializable]
    [JsonObject("node.vgo.rigidbody")]
    public class VGO_Rigidbody
    {
        /// <summary>Mass</summary>
        [JsonProperty("mass")]
        public float mass = 1.0f;

        /// <summary>Drag</summary>
        [JsonProperty("drag")]
        public float drag = 0.0f;

        /// <summary>Angular Drag</summary>
        [JsonProperty("angularDrag")]
        public float angularDrag = 0.0f;

        /// <summary>Use Gravity</summary>
        [JsonProperty("useGravity")]
        public bool useGravity = true;

        /// <summary>Is Kinematic</summary>
        [JsonProperty("isKinematic")]
        public bool isKinematic = false;

        /// <summary>Interpolation</summary>
        [JsonProperty("interpolation")]
        public RigidbodyInterpolation interpolation = RigidbodyInterpolation.None;

        /// <summary>Collision Detection Mode</summary>
        [JsonProperty("collisionDetectionMode")]
        public CollisionDetectionMode collisionDetectionMode = CollisionDetectionMode.Discrete;

        /// <summary>Cconstraints</summary>
        [JsonProperty("constraints")]
        public RigidbodyConstraints constraints = 0;
    }
}