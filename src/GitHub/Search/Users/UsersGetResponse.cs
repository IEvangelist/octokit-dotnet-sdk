// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Search.Users {
    #pragma warning disable CS1591
    public class UsersGetResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The incomplete_results property</summary>
        public bool? IncompleteResults { get; set; }
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSearchResultItem>? Items { get; set; }
#nullable restore
#else
        public List<UserSearchResultItem> Items { get; set; }
#endif
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="UsersGetResponse"/> and sets the default values.
        /// </summary>
        public UsersGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UsersGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UsersGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsersGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"incomplete_results", n => { IncompleteResults = n.GetBoolValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<UserSearchResultItem>(UserSearchResultItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("incomplete_results", IncompleteResults);
            writer.WriteCollectionOfObjectValues<UserSearchResultItem>("items", Items);
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
