// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Migrations.Item.Archive;
using GitHub.Orgs.Item.Migrations.Item.Repos;
using GitHub.Orgs.Item.Migrations.Item.Repositories;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Migrations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\migrations\{migration_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithMigration_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The archive property</summary>
        public global::GitHub.Orgs.Item.Migrations.Item.Archive.ArchiveRequestBuilder Archive
        {
            get => new global::GitHub.Orgs.Item.Migrations.Item.Archive.ArchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public global::GitHub.Orgs.Item.Migrations.Item.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.Orgs.Item.Migrations.Item.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repositories property</summary>
        public global::GitHub.Orgs.Item.Migrations.Item.Repositories.RepositoriesRequestBuilder Repositories
        {
            get => new global::GitHub.Orgs.Item.Migrations.Item.Repositories.RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMigration_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/migrations/{migration_id}{?exclude*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMigration_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/migrations/{migration_id}{?exclude*}", rawUrl)
        {
        }
        /// <summary>
        /// Fetches the status of a migration.The `state` of a migration can be one of the following values:*   `pending`, which means the migration hasn&apos;t started yet.*   `exporting`, which means the migration is in progress.*   `exported`, which means the migration finished successfully.*   `failed`, which means the migration failed.
        /// API method documentation <see href="https://docs.github.com/rest/migrations/orgs#get-an-organization-migration-status" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Migration"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.Migration?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder.WithMigration_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.Migration> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder.WithMigration_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.Migration>(requestInfo, global::GitHub.Models.Migration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches the status of a migration.The `state` of a migration can be one of the following values:*   `pending`, which means the migration hasn&apos;t started yet.*   `exporting`, which means the migration is in progress.*   `exported`, which means the migration finished successfully.*   `failed`, which means the migration failed.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder.WithMigration_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder.WithMigration_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Migrations.Item.WithMigration_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches the status of a migration.The `state` of a migration can be one of the following values:*   `pending`, which means the migration hasn&apos;t started yet.*   `exporting`, which means the migration is in progress.*   `exported`, which means the migration finished successfully.*   `failed`, which means the migration failed.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class WithMigration_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Exclude attributes from the API response to improve performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("exclude")]
            public global::GitHub.Orgs.Item.Migrations.Item.GetExcludeQueryParameterType[]? Exclude { get; set; }
#nullable restore
#else
            [QueryParameter("exclude")]
            public global::GitHub.Orgs.Item.Migrations.Item.GetExcludeQueryParameterType[] Exclude { get; set; }
#endif
        }
    }
}
