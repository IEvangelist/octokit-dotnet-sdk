// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Create a new snapshot of a repository&apos;s dependencies.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class Snapshot : IParsable
    {
        /// <summary>A description of the detector used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Snapshot_detector? Detector { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Snapshot_detector Detector { get; set; }
#endif
        /// <summary>The job property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Snapshot_job? Job { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Snapshot_job Job { get; set; }
#endif
        /// <summary>A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Snapshot_manifests? Manifests { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Snapshot_manifests Manifests { get; set; }
#endif
        /// <summary>User-defined metadata to store domain-specific information limited to 8 keys with scalar values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Metadata? Metadata { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Metadata Metadata { get; set; }
#endif
        /// <summary>The repository branch that triggered this snapshot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>The time at which the snapshot was scanned.</summary>
        public DateTimeOffset? Scanned { get; set; }
        /// <summary>The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The version of the repository snapshot submission.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Snapshot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Snapshot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Snapshot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detector", n => { Detector = n.GetObjectValue<global::GitHub.Models.Snapshot_detector>(global::GitHub.Models.Snapshot_detector.CreateFromDiscriminatorValue); } },
                { "job", n => { Job = n.GetObjectValue<global::GitHub.Models.Snapshot_job>(global::GitHub.Models.Snapshot_job.CreateFromDiscriminatorValue); } },
                { "manifests", n => { Manifests = n.GetObjectValue<global::GitHub.Models.Snapshot_manifests>(global::GitHub.Models.Snapshot_manifests.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::GitHub.Models.Metadata>(global::GitHub.Models.Metadata.CreateFromDiscriminatorValue); } },
                { "ref", n => { Ref = n.GetStringValue(); } },
                { "scanned", n => { Scanned = n.GetDateTimeOffsetValue(); } },
                { "sha", n => { Sha = n.GetStringValue(); } },
                { "version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.Snapshot_detector>("detector", Detector);
            writer.WriteObjectValue<global::GitHub.Models.Snapshot_job>("job", Job);
            writer.WriteObjectValue<global::GitHub.Models.Snapshot_manifests>("manifests", Manifests);
            writer.WriteObjectValue<global::GitHub.Models.Metadata>("metadata", Metadata);
            writer.WriteStringValue("ref", Ref);
            writer.WriteDateTimeOffsetValue("scanned", Scanned);
            writer.WriteStringValue("sha", Sha);
            writer.WriteIntValue("version", Version);
        }
    }
}
