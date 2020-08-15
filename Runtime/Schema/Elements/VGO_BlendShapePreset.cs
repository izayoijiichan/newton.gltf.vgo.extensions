// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShapePreset
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using VgoGltf;

    /// <summary>
    /// VGO BlendShape Preset
    /// </summary>
    [Serializable]
    [JsonObject("vgo.blendshape.preset")]
    public class VGO_BlendShapePreset
    {
        /// <summary>The name of preset.</summary>
        [JsonProperty("name")]
        public string name;

        /// <summary>The type of preset.</summary>
        [JsonProperty("type")]
        public VgoBlendShapePresetType type;

        /// <summary>List of binding.</summary>
        [JsonProperty("bindings")]
        public List<VGO_BlendShapeBinding> bindings = new List<VGO_BlendShapeBinding>();
    }
}
