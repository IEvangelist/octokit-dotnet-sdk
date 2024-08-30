// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CodeScanningVariantAnalysis_skipped_repositories : IAdditionalDataHolder, IParsable
    {
        /// <summary>The access_mismatch_repos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup? AccessMismatchRepos { get; set; }
#nullable restore
#else
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup AccessMismatchRepos { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The no_codeql_db_repos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup? NoCodeqlDbRepos { get; set; }
#nullable restore
#else
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup NoCodeqlDbRepos { get; set; }
#endif
        /// <summary>The not_found_repos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos? NotFoundRepos { get; set; }
#nullable restore
#else
        public global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos NotFoundRepos { get; set; }
#endif
        /// <summary>The over_limit_repos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup? OverLimitRepos { get; set; }
#nullable restore
#else
        public global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup OverLimitRepos { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories"/> and sets the default values.
        /// </summary>
        public CodeScanningVariantAnalysis_skipped_repositories()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "access_mismatch_repos", n => { AccessMismatchRepos = n.GetObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>(global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup.CreateFromDiscriminatorValue); } },
                { "no_codeql_db_repos", n => { NoCodeqlDbRepos = n.GetObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>(global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup.CreateFromDiscriminatorValue); } },
                { "not_found_repos", n => { NotFoundRepos = n.GetObjectValue<global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos>(global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos.CreateFromDiscriminatorValue); } },
                { "over_limit_repos", n => { OverLimitRepos = n.GetObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>(global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>("access_mismatch_repos", AccessMismatchRepos);
            writer.WriteObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>("no_codeql_db_repos", NoCodeqlDbRepos);
            writer.WriteObjectValue<global::GitHub.Models.CodeScanningVariantAnalysis_skipped_repositories_not_found_repos>("not_found_repos", NotFoundRepos);
            writer.WriteObjectValue<global::GitHub.Models.CodeScanningVariantAnalysisSkippedRepoGroup>("over_limit_repos", OverLimitRepos);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
