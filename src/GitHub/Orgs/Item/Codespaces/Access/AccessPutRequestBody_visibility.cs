// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Codespaces.Access
{
    /// <summary>Which users can access codespaces in the organization. `disabled` means that no users can access codespaces in the organization.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum AccessPutRequestBody_visibility
    {
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "selected_members")]
        #pragma warning disable CS1591
        Selected_members,
        #pragma warning restore CS1591
        [EnumMember(Value = "all_members")]
        #pragma warning disable CS1591
        All_members,
        #pragma warning restore CS1591
        [EnumMember(Value = "all_members_and_outside_collaborators")]
        #pragma warning disable CS1591
        All_members_and_outside_collaborators,
        #pragma warning restore CS1591
    }
}
