// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum NullableRepository_merge_commit_message
    {
        [EnumMember(Value = "PR_BODY")]
        #pragma warning disable CS1591
        PR_BODY,
        #pragma warning restore CS1591
        [EnumMember(Value = "PR_TITLE")]
        #pragma warning disable CS1591
        PR_TITLE,
        #pragma warning restore CS1591
        [EnumMember(Value = "BLANK")]
        #pragma warning disable CS1591
        BLANK,
        #pragma warning restore CS1591
    }
}
