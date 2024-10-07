// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class VariantAnalysesPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The language targeted by the CodeQL query</summary>
        public global::GitHub.Models.CodeScanningVariantAnalysisLanguage? Language { get; set; }
        /// <summary>A Base64-encoded tarball containing a CodeQL query and all its dependencies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueryPack { get; set; }
#nullable restore
#else
        public string QueryPack { get; set; }
#endif
        /// <summary>List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Repositories { get; set; }
#nullable restore
#else
        public List<string> Repositories { get; set; }
#endif
        /// <summary>List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RepositoryLists { get; set; }
#nullable restore
#else
        public List<string> RepositoryLists { get; set; }
#endif
        /// <summary>List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RepositoryOwners { get; set; }
#nullable restore
#else
        public List<string> RepositoryOwners { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.VariantAnalysesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.VariantAnalysesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.VariantAnalysesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "language", n => { Language = n.GetEnumValue<global::GitHub.Models.CodeScanningVariantAnalysisLanguage>(); } },
                { "query_pack", n => { QueryPack = n.GetStringValue(); } },
                { "repositories", n => { Repositories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "repository_lists", n => { RepositoryLists = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "repository_owners", n => { RepositoryOwners = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Models.CodeScanningVariantAnalysisLanguage>("language", Language);
            writer.WriteStringValue("query_pack", QueryPack);
            writer.WriteCollectionOfPrimitiveValues<string>("repositories", Repositories);
            writer.WriteCollectionOfPrimitiveValues<string>("repository_lists", RepositoryLists);
            writer.WriteCollectionOfPrimitiveValues<string>("repository_owners", RepositoryOwners);
        }
    }
}
#pragma warning restore CS0618
