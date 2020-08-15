// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_HumanAvatar
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// VGO Human Avatar
    /// </summary>
    [Serializable]
    [JsonObject("humanAvatar")]
    public class VGO_HumanAvatar
    {
        /// <summary>The name of this human avatar.</summary>
        [JsonProperty("name")]
        public string name;

        /// <summary>List of the human bone.</summary>
        [JsonProperty("humanBones")]
        public List<VGO_HumanBone> humanBones = new List<VGO_HumanBone>();

        ///// <summary>List of the node index of the skeleton bone.</summary>
        //[JsonProperty("skeletonBones")]
        //public List<int> skeletonBones = new List<int>();
    }
}