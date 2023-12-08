// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class CodeScanningSarifsStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The REST API URL for getting the analyses associated with the upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnalysesUrl { get; private set; }
#nullable restore
#else
        public string AnalysesUrl { get; private set; }
#endif
        /// <summary>Any errors that ocurred during processing of the delivery.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Errors { get; private set; }
#nullable restore
#else
        public List<string> Errors { get; private set; }
#endif
        /// <summary>`pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.</summary>
        public CodeScanningSarifsStatus_processing_status? ProcessingStatus { get; set; }
        /// <summary>
        /// Instantiates a new codeScanningSarifsStatus and sets the default values.
        /// </summary>
        public CodeScanningSarifsStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningSarifsStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningSarifsStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"analyses_url", n => { AnalysesUrl = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"processing_status", n => { ProcessingStatus = n.GetEnumValue<CodeScanningSarifsStatus_processing_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CodeScanningSarifsStatus_processing_status>("processing_status", ProcessingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}