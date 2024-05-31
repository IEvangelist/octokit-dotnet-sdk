// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item.Repos;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\code-scanning\codeql\variant-analyses\{codeql_variant_analysis_id}
    /// </summary>
    public class WithCodeql_variant_analysis_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The repos property</summary>
        public GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item.Repos.ReposRequestBuilder Repos
        {
            get => new GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithCodeql_variant_analysis_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeql_variant_analysis_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/code-scanning/codeql/variant-analyses/{codeql_variant_analysis_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithCodeql_variant_analysis_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeql_variant_analysis_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/code-scanning/codeql/variant-analyses/{codeql_variant_analysis_id}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the summary of a CodeQL variant analysis.OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// API method documentation <see href="https://docs.github.com/rest/code-scanning/code-scanning#get-the-summary-of-a-codeql-variant-analysis" />
        /// </summary>
        /// <returns>A <see cref="CodeScanningVariantAnalysis"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="CodeScanningVariantAnalysis503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodeScanningVariantAnalysis?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CodeScanningVariantAnalysis> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"503", CodeScanningVariantAnalysis503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CodeScanningVariantAnalysis>(requestInfo, CodeScanningVariantAnalysis.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the summary of a CodeQL variant analysis.OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithCodeql_variant_analysis_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithCodeql_variant_analysis_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithCodeql_variant_analysis_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
