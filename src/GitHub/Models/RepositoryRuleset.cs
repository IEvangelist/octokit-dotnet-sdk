// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A set of rules to apply when specified conditions are met.
    /// </summary>
    public class RepositoryRuleset : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The actors that can bypass the rules in this ruleset</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryRulesetBypassActor>? BypassActors { get; set; }
#nullable restore
#else
        public List<RepositoryRulesetBypassActor> BypassActors { get; set; }
#endif
        /// <summary>The conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleset_conditions? Conditions { get; set; }
#nullable restore
#else
        public RepositoryRuleset_conditions Conditions { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The bypass type of the user making the API request for this ruleset. This field is only returned whenquerying the repository-level endpoint.</summary>
        public RepositoryRuleset_current_user_can_bypass? CurrentUserCanBypass { get; set; }
        /// <summary>The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).</summary>
        public RepositoryRuleEnforcement? Enforcement { get; set; }
        /// <summary>The ID of the ruleset</summary>
        public int? Id { get; set; }
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleset__links? Links { get; set; }
#nullable restore
#else
        public RepositoryRuleset__links Links { get; set; }
#endif
        /// <summary>The name of the ruleset</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The rules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryRule>? Rules { get; set; }
#nullable restore
#else
        public List<RepositoryRule> Rules { get; set; }
#endif
        /// <summary>The name of the source</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The type of the source of the ruleset</summary>
        public RepositoryRuleset_source_type? SourceType { get; set; }
        /// <summary>The target of the ruleset</summary>
        public RepositoryRuleset_target? Target { get; set; }
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new repositoryRuleset and sets the default values.
        /// </summary>
        public RepositoryRuleset() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bypass_actors", n => { BypassActors = n.GetCollectionOfObjectValues<RepositoryRulesetBypassActor>(RepositoryRulesetBypassActor.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditions", n => { Conditions = n.GetObjectValue<RepositoryRuleset_conditions>(RepositoryRuleset_conditions.CreateFromDiscriminatorValue); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"current_user_can_bypass", n => { CurrentUserCanBypass = n.GetEnumValue<RepositoryRuleset_current_user_can_bypass>(); } },
                {"enforcement", n => { Enforcement = n.GetEnumValue<RepositoryRuleEnforcement>(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"_links", n => { Links = n.GetObjectValue<RepositoryRuleset__links>(RepositoryRuleset__links.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<RepositoryRule>(RepositoryRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"source", n => { Source = n.GetStringValue(); } },
                {"source_type", n => { SourceType = n.GetEnumValue<RepositoryRuleset_source_type>(); } },
                {"target", n => { Target = n.GetEnumValue<RepositoryRuleset_target>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RepositoryRulesetBypassActor>("bypass_actors", BypassActors);
            writer.WriteObjectValue<RepositoryRuleset_conditions>("conditions", Conditions);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteEnumValue<RepositoryRuleset_current_user_can_bypass>("current_user_can_bypass", CurrentUserCanBypass);
            writer.WriteEnumValue<RepositoryRuleEnforcement>("enforcement", Enforcement);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<RepositoryRuleset__links>("_links", Links);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<RepositoryRule>("rules", Rules);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<RepositoryRuleset_source_type>("source_type", SourceType);
            writer.WriteEnumValue<RepositoryRuleset_target>("target", Target);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes orgRulesetConditions, repositoryRulesetConditions
        /// </summary>
        public class RepositoryRuleset_conditions : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type orgRulesetConditions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.OrgRulesetConditions? OrgRulesetConditions { get; set; }
#nullable restore
#else
            public GitHub.Models.OrgRulesetConditions OrgRulesetConditions { get; set; }
#endif
            /// <summary>Composed type representation for type repositoryRulesetConditions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.RepositoryRulesetConditions? RepositoryRulesetConditions { get; set; }
#nullable restore
#else
            public GitHub.Models.RepositoryRulesetConditions RepositoryRulesetConditions { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static RepositoryRuleset_conditions CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new RepositoryRuleset_conditions();
                result.OrgRulesetConditions = new GitHub.Models.OrgRulesetConditions();
                result.RepositoryRulesetConditions = new GitHub.Models.RepositoryRulesetConditions();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(OrgRulesetConditions != null || RepositoryRulesetConditions != null) {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OrgRulesetConditions, RepositoryRulesetConditions);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<GitHub.Models.OrgRulesetConditions>(null, OrgRulesetConditions, RepositoryRulesetConditions);
            }
        }
    }
}