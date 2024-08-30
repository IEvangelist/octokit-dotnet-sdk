// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// A description of the machine powering a codespace.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class NullableCodespaceMachine : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How many cores are available to the codespace.</summary>
        public int? Cpus { get; set; }
        /// <summary>The display name of the machine includes cores, memory, and storage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>How much memory is available to the codespace.</summary>
        public int? MemoryInBytes { get; set; }
        /// <summary>The name of the machine.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The operating system of the machine.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; set; }
#nullable restore
#else
        public string OperatingSystem { get; set; }
#endif
        /// <summary>Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be &quot;null&quot; if prebuilds are not supported or prebuild availability could not be determined. Value will be &quot;none&quot; if no prebuild is available. Latest values &quot;ready&quot; and &quot;in_progress&quot; indicate the prebuild availability status.</summary>
        public global::GitHub.Models.NullableCodespaceMachine_prebuild_availability? PrebuildAvailability { get; set; }
        /// <summary>How much storage is available to the codespace.</summary>
        public int? StorageInBytes { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.NullableCodespaceMachine"/> and sets the default values.
        /// </summary>
        public NullableCodespaceMachine()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.NullableCodespaceMachine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.NullableCodespaceMachine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.NullableCodespaceMachine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cpus", n => { Cpus = n.GetIntValue(); } },
                { "display_name", n => { DisplayName = n.GetStringValue(); } },
                { "memory_in_bytes", n => { MemoryInBytes = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "operating_system", n => { OperatingSystem = n.GetStringValue(); } },
                { "prebuild_availability", n => { PrebuildAvailability = n.GetEnumValue<global::GitHub.Models.NullableCodespaceMachine_prebuild_availability>(); } },
                { "storage_in_bytes", n => { StorageInBytes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("cpus", Cpus);
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteIntValue("memory_in_bytes", MemoryInBytes);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("operating_system", OperatingSystem);
            writer.WriteEnumValue<global::GitHub.Models.NullableCodespaceMachine_prebuild_availability>("prebuild_availability", PrebuildAvailability);
            writer.WriteIntValue("storage_in_bytes", StorageInBytes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
