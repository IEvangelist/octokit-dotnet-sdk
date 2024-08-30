// <auto-generated/>
using GitHub.Models;
using GitHub.Users.Item.Attestations;
using GitHub.Users.Item.Docker;
using GitHub.Users.Item.Events;
using GitHub.Users.Item.Followers;
using GitHub.Users.Item.Following;
using GitHub.Users.Item.Gists;
using GitHub.Users.Item.Gpg_keys;
using GitHub.Users.Item.Hovercard;
using GitHub.Users.Item.Installation;
using GitHub.Users.Item.Keys;
using GitHub.Users.Item.Orgs;
using GitHub.Users.Item.Packages;
using GitHub.Users.Item.Projects;
using GitHub.Users.Item.Received_events;
using GitHub.Users.Item.Repos;
using GitHub.Users.Item.Settings;
using GitHub.Users.Item.Social_accounts;
using GitHub.Users.Item.Ssh_signing_keys;
using GitHub.Users.Item.Starred;
using GitHub.Users.Item.Subscriptions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithUsernameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The attestations property</summary>
        public global::GitHub.Users.Item.Attestations.AttestationsRequestBuilder Attestations
        {
            get => new global::GitHub.Users.Item.Attestations.AttestationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public global::GitHub.Users.Item.Docker.DockerRequestBuilder Docker
        {
            get => new global::GitHub.Users.Item.Docker.DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::GitHub.Users.Item.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Users.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The followers property</summary>
        public global::GitHub.Users.Item.Followers.FollowersRequestBuilder Followers
        {
            get => new global::GitHub.Users.Item.Followers.FollowersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The following property</summary>
        public global::GitHub.Users.Item.Following.FollowingRequestBuilder Following
        {
            get => new global::GitHub.Users.Item.Following.FollowingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gists property</summary>
        public global::GitHub.Users.Item.Gists.GistsRequestBuilder Gists
        {
            get => new global::GitHub.Users.Item.Gists.GistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gpg_keys property</summary>
        public global::GitHub.Users.Item.Gpg_keys.Gpg_keysRequestBuilder Gpg_keys
        {
            get => new global::GitHub.Users.Item.Gpg_keys.Gpg_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hovercard property</summary>
        public global::GitHub.Users.Item.Hovercard.HovercardRequestBuilder Hovercard
        {
            get => new global::GitHub.Users.Item.Hovercard.HovercardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public global::GitHub.Users.Item.Installation.InstallationRequestBuilder Installation
        {
            get => new global::GitHub.Users.Item.Installation.InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public global::GitHub.Users.Item.Keys.KeysRequestBuilder Keys
        {
            get => new global::GitHub.Users.Item.Keys.KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orgs property</summary>
        public global::GitHub.Users.Item.Orgs.OrgsRequestBuilder Orgs
        {
            get => new global::GitHub.Users.Item.Orgs.OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public global::GitHub.Users.Item.Packages.PackagesRequestBuilder Packages
        {
            get => new global::GitHub.Users.Item.Packages.PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public global::GitHub.Users.Item.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.Users.Item.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The received_events property</summary>
        public global::GitHub.Users.Item.Received_events.Received_eventsRequestBuilder Received_events
        {
            get => new global::GitHub.Users.Item.Received_events.Received_eventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public global::GitHub.Users.Item.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.Users.Item.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::GitHub.Users.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::GitHub.Users.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The social_accounts property</summary>
        public global::GitHub.Users.Item.Social_accounts.Social_accountsRequestBuilder Social_accounts
        {
            get => new global::GitHub.Users.Item.Social_accounts.Social_accountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssh_signing_keys property</summary>
        public global::GitHub.Users.Item.Ssh_signing_keys.Ssh_signing_keysRequestBuilder Ssh_signing_keys
        {
            get => new global::GitHub.Users.Item.Ssh_signing_keys.Ssh_signing_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The starred property</summary>
        public global::GitHub.Users.Item.Starred.StarredRequestBuilder Starred
        {
            get => new global::GitHub.Users.Item.Starred.StarredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public global::GitHub.Users.Item.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new global::GitHub.Users.Item.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}", rawUrl)
        {
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account.The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-a-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse>(requestInfo, global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account.The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
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
        /// <returns>A <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Users.Item.WithUsernameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Users.Item.WithUsernameItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.PrivateUser"/>, <see cref="global::GitHub.Models.PublicUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class WithUsernameGetResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.PrivateUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.PublicUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.Users.Item.WithUsernameItemRequestBuilder.WithUsernameGetResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PrivateUser = new global::GitHub.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PublicUser = new global::GitHub.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PrivateUser != null)
                {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null)
                {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.PublicUser>(null, PublicUser);
                }
            }
        }
    }
}
