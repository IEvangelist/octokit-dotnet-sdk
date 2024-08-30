// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Secrets for a GitHub Codespace.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CodespacesOrgSecret : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time at which the secret was created, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The name of the secret</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The API URL at which the list of repositories this secret is visible to can be retrieved</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectedRepositoriesUrl { get; set; }
#nullable restore
#else
        public string SelectedRepositoriesUrl { get; set; }
#endif
        /// <summary>The date and time at which the secret was created, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The type of repositories in the organization that the secret is visible to</summary>
        public global::GitHub.Models.CodespacesOrgSecret_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CodespacesOrgSecret"/> and sets the default values.
        /// </summary>
        public CodespacesOrgSecret()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodespacesOrgSecret"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodespacesOrgSecret CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodespacesOrgSecret();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "selected_repositories_url", n => { SelectedRepositoriesUrl = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::GitHub.Models.CodespacesOrgSecret_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("selected_repositories_url", SelectedRepositoriesUrl);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteEnumValue<global::GitHub.Models.CodespacesOrgSecret_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
