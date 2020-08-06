// ----------------------------------------------------------------------
// @Namespace : NewtonGltf.Serialization
// @Class     : VgoJsonSerializerSettings
// ----------------------------------------------------------------------
namespace NewtonGltf.Serialization
{
    /// <summary>
    /// VGO JSON Serializer Settings
    /// </summary>
    public class VgoJsonSerializerSettings : GltfJsonSerializerSettings
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of VgoJsonSerializerSettings.
        /// </summary>
        public VgoJsonSerializerSettings() : base()
        {
            ContractResolver = new VgoContractResolver();
        }

        #endregion
    }
}
