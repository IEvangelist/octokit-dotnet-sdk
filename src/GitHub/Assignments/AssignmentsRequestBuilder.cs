// <auto-generated/>
using GitHub.Assignments.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Assignments
{
    /// <summary>
    /// Builds and executes requests for operations under \assignments
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class AssignmentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.assignments.item collection</summary>
        /// <param name="position">The unique identifier of the classroom assignment.</param>
        /// <returns>A <see cref="global::GitHub.Assignments.Item.WithAssignment_ItemRequestBuilder"/></returns>
        public global::GitHub.Assignments.Item.WithAssignment_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("assignment_id", position);
                return new global::GitHub.Assignments.Item.WithAssignment_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Assignments.AssignmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignmentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/assignments", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Assignments.AssignmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignmentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/assignments", rawUrl)
        {
        }
    }
}
