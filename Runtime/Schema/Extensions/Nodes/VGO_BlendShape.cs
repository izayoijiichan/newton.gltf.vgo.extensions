// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : VGO_BlendShape
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using VgoGltf;

    /// <summary>
    /// glTF Node VGO BlendShape
    /// </summary>
    [Serializable]
    [JsonObject("node.vgo.blendshape")]
    public class VGO_BlendShape
    {
        /// <summary>The name of this BlendShape.</summary>
        [JsonProperty("name")]
        public string name;

        /// <summary>The kind of the BlendShape.</summary>
        [JsonProperty("kind")]
        public VgoBlendShapeKind kind;

        /// <summary>List of face parts.</summary>
        [JsonProperty("faceParts")]
        public List<VGO_BlendShapeFacePart> faceParts = new List<VGO_BlendShapeFacePart>();

        /// <summary>List of blink.</summary>
        [JsonProperty("blinks")]
        public List<VGO_BlendShapeBlink> blinks = new List<VGO_BlendShapeBlink>();

        /// <summary>Visemes.</summary>
        [JsonProperty("visemes")]
        public List<VGO_BlendShapeViseme> visemes = new List<VGO_BlendShapeViseme>();

        /// <summary>List of preset.</summary>
        [JsonProperty("presets")]
        public List<VGO_BlendShapePreset> presets = new List<VGO_BlendShapePreset>();
    }
}