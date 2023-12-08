// <auto-generated/>
using GitHub.Octokit.Repos.Item.Item.Git.MatchingRefs.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Git.MatchingRefs {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\git\matching-refs
    /// </summary>
    public class MatchingRefsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.git.matchingRefs.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithRefItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("ref", position);
            return new WithRefItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MatchingRefsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MatchingRefsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/git/matching-refs", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MatchingRefsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MatchingRefsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/git/matching-refs", rawUrl) {
        }
    }
}