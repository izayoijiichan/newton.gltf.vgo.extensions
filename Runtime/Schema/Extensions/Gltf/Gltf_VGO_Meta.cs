﻿// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : Gltf_VGO_Meta
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// glTF VGO Meta
    /// </summary>
    [Serializable]
    [JsonObject("vgo.meta")]
    public class Gltf_VGO_Meta
    {
        #region Fields

        /// <summary>Generator Name</summary>
        [JsonProperty("generatorName", Required = Required.Always)]
        public string generatorName = null;

        /// <summary>Generator Version</summary>
        [JsonProperty("generatorVersion", Required = Required.Always)]
        public string generatorVersion = null;

        /// <summary>Specification Version</summary>
        [JsonProperty("specVersion", Required = Required.Always)]
        public string specVersion = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of glTF_VGO_Meta.
        /// </summary>
        public Gltf_VGO_Meta() { }

        /// <summary>
        /// Create a new instance of glTF_VGO_Meta by specifying glTF_VGO_Meta.
        /// </summary>
        /// <param name="meta"></param>
        public Gltf_VGO_Meta(Gltf_VGO_Meta meta)
        {
            if (meta != null)
            {
                generatorName = meta.generatorName;
                generatorVersion = meta.generatorVersion;
                specVersion = meta.specVersion;
            }
        }

        #endregion
    }
}