// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item {
    /// <summary>The default value for a squash merge commit title:- `PR_TITLE` - default to the pull request&apos;s title.- `COMMIT_OR_PR_TITLE` - default to the commit&apos;s title (if only one commit) or the pull request&apos;s title (when more than one commit).</summary>
    public enum RepoPatchRequestBody_squash_merge_commit_title
    {
        [EnumMember(Value = "PR_TITLE")]
        #pragma warning disable CS1591
        PR_TITLE,
        #pragma warning restore CS1591
        [EnumMember(Value = "COMMIT_OR_PR_TITLE")]
        #pragma warning disable CS1591
        COMMIT_OR_PR_TITLE,
        #pragma warning restore CS1591
    }
}
