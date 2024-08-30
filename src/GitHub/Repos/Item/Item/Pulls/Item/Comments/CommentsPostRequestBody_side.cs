// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Comments
{
    /// <summary>In a split diff view, the side of the diff that the pull request&apos;s changes appear on. Can be `LEFT` or `RIGHT`. Use `LEFT` for deletions that appear in red. Use `RIGHT` for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see &quot;[Diff view options](https://docs.github.com/articles/about-comparing-branches-in-pull-requests#diff-view-options)&quot; in the GitHub Help documentation.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum CommentsPostRequestBody_side
    {
        [EnumMember(Value = "LEFT")]
        #pragma warning disable CS1591
        LEFT,
        #pragma warning restore CS1591
        [EnumMember(Value = "RIGHT")]
        #pragma warning disable CS1591
        RIGHT,
        #pragma warning restore CS1591
    }
}
