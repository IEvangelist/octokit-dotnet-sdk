// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A GitHub Security Advisory.
    /// </summary>
    public class GlobalAdvisory : IParsable 
    {
        /// <summary>The users who contributed to the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GlobalAdvisory_credits>? Credits { get; private set; }
#nullable restore
#else
        public List<GlobalAdvisory_credits> Credits { get; private set; }
#endif
        /// <summary>The Common Vulnerabilities and Exposures (CVE) ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CveId { get; private set; }
#nullable restore
#else
        public string CveId { get; private set; }
#endif
        /// <summary>The cvss property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GlobalAdvisory_cvss? Cvss { get; set; }
#nullable restore
#else
        public GlobalAdvisory_cvss Cvss { get; set; }
#endif
        /// <summary>The cwes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GlobalAdvisory_cwes>? Cwes { get; set; }
#nullable restore
#else
        public List<GlobalAdvisory_cwes> Cwes { get; set; }
#endif
        /// <summary>A detailed description of what the advisory entails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The GitHub Security Advisory ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GhsaId { get; private set; }
#nullable restore
#else
        public string GhsaId { get; private set; }
#endif
        /// <summary>The date and time of when the advisory was reviewed by GitHub, in ISO 8601 format.</summary>
        public DateTimeOffset? GithubReviewedAt { get; private set; }
        /// <summary>The URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; private set; }
#nullable restore
#else
        public string HtmlUrl { get; private set; }
#endif
        /// <summary>The identifiers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GlobalAdvisory_identifiers>? Identifiers { get; private set; }
#nullable restore
#else
        public List<GlobalAdvisory_identifiers> Identifiers { get; private set; }
#endif
        /// <summary>The date and time when the advisory was published in the National Vulnerability Database, in ISO 8601 format.This field is only populated when the advisory is imported from the National Vulnerability Database.</summary>
        public DateTimeOffset? NvdPublishedAt { get; private set; }
        /// <summary>The date and time of when the advisory was published, in ISO 8601 format.</summary>
        public DateTimeOffset? PublishedAt { get; private set; }
        /// <summary>The references property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? References { get; set; }
#nullable restore
#else
        public List<string> References { get; set; }
#endif
        /// <summary>The API URL for the repository advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryAdvisoryUrl { get; private set; }
#nullable restore
#else
        public string RepositoryAdvisoryUrl { get; private set; }
#endif
        /// <summary>The severity of the advisory.</summary>
        public GlobalAdvisory_severity? Severity { get; set; }
        /// <summary>The URL of the advisory&apos;s source code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceCodeLocation { get; set; }
#nullable restore
#else
        public string SourceCodeLocation { get; set; }
#endif
        /// <summary>A short summary of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>The type of advisory.</summary>
        public GlobalAdvisory_type? Type { get; private set; }
        /// <summary>The date and time of when the advisory was last updated, in ISO 8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The API URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>The products and respective version ranges affected by the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Vulnerability>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<Vulnerability> Vulnerabilities { get; set; }
#endif
        /// <summary>The date and time of when the advisory was withdrawn, in ISO 8601 format.</summary>
        public DateTimeOffset? WithdrawnAt { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GlobalAdvisory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GlobalAdvisory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GlobalAdvisory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"credits", n => { Credits = n.GetCollectionOfObjectValues<GlobalAdvisory_credits>(GlobalAdvisory_credits.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cve_id", n => { CveId = n.GetStringValue(); } },
                {"cvss", n => { Cvss = n.GetObjectValue<GlobalAdvisory_cvss>(GlobalAdvisory_cvss.CreateFromDiscriminatorValue); } },
                {"cwes", n => { Cwes = n.GetCollectionOfObjectValues<GlobalAdvisory_cwes>(GlobalAdvisory_cwes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"ghsa_id", n => { GhsaId = n.GetStringValue(); } },
                {"github_reviewed_at", n => { GithubReviewedAt = n.GetDateTimeOffsetValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"identifiers", n => { Identifiers = n.GetCollectionOfObjectValues<GlobalAdvisory_identifiers>(GlobalAdvisory_identifiers.CreateFromDiscriminatorValue)?.ToList(); } },
                {"nvd_published_at", n => { NvdPublishedAt = n.GetDateTimeOffsetValue(); } },
                {"published_at", n => { PublishedAt = n.GetDateTimeOffsetValue(); } },
                {"references", n => { References = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"repository_advisory_url", n => { RepositoryAdvisoryUrl = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<GlobalAdvisory_severity>(); } },
                {"source_code_location", n => { SourceCodeLocation = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<GlobalAdvisory_type>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<Vulnerability>(Vulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
                {"withdrawn_at", n => { WithdrawnAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GlobalAdvisory_cvss>("cvss", Cvss);
            writer.WriteCollectionOfObjectValues<GlobalAdvisory_cwes>("cwes", Cwes);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("references", References);
            writer.WriteEnumValue<GlobalAdvisory_severity>("severity", Severity);
            writer.WriteStringValue("source_code_location", SourceCodeLocation);
            writer.WriteStringValue("summary", Summary);
            writer.WriteCollectionOfObjectValues<Vulnerability>("vulnerabilities", Vulnerabilities);
        }
    }
}
