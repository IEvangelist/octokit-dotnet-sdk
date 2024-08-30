// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Dependabot.Secrets.Item.Repositories
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class RepositoriesPutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can add and remove individual repositories using the [Set selected repositories for an organization secret](https://docs.github.com/rest/dependabot/secrets#set-selected-repositories-for-an-organization-secret) and [Remove selected repository from an organization secret](https://docs.github.com/rest/dependabot/secrets#remove-selected-repository-from-an-organization-secret) endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SelectedRepositoryIds { get; set; }
#nullable restore
#else
        public List<int?> SelectedRepositoryIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Dependabot.Secrets.Item.Repositories.RepositoriesPutRequestBody"/> and sets the default values.
        /// </summary>
        public RepositoriesPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Dependabot.Secrets.Item.Repositories.RepositoriesPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Dependabot.Secrets.Item.Repositories.RepositoriesPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Dependabot.Secrets.Item.Repositories.RepositoriesPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "selected_repository_ids", n => { SelectedRepositoryIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("selected_repository_ids", SelectedRepositoryIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
