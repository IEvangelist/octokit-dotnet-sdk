// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Import.Lfs
{
    /// <summary>Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum LfsPatchRequestBody_use_lfs
    {
        [EnumMember(Value = "opt_in")]
        #pragma warning disable CS1591
        Opt_in,
        #pragma warning restore CS1591
        [EnumMember(Value = "opt_out")]
        #pragma warning disable CS1591
        Opt_out,
        #pragma warning restore CS1591
    }
}
