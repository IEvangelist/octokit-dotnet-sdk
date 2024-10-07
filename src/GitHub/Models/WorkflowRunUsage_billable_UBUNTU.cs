// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class WorkflowRunUsage_billable_UBUNTU : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The job_runs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU_job_runs>? JobRuns { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU_job_runs> JobRuns { get; set; }
#endif
        /// <summary>The jobs property</summary>
        public int? Jobs { get; set; }
        /// <summary>The total_ms property</summary>
        public int? TotalMs { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU"/> and sets the default values.
        /// </summary>
        public WorkflowRunUsage_billable_UBUNTU()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "job_runs", n => { JobRuns = n.GetCollectionOfObjectValues<global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU_job_runs>(global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU_job_runs.CreateFromDiscriminatorValue)?.AsList(); } },
                { "jobs", n => { Jobs = n.GetIntValue(); } },
                { "total_ms", n => { TotalMs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.WorkflowRunUsage_billable_UBUNTU_job_runs>("job_runs", JobRuns);
            writer.WriteIntValue("jobs", Jobs);
            writer.WriteIntValue("total_ms", TotalMs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
