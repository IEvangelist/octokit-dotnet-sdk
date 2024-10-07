// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum RepositoryAdvisoryCreate_severity
    {
        [EnumMember(Value = "critical")]
        #pragma warning disable CS1591
        Critical,
        #pragma warning restore CS1591
        [EnumMember(Value = "high")]
        #pragma warning disable CS1591
        High,
        #pragma warning restore CS1591
        [EnumMember(Value = "medium")]
        #pragma warning disable CS1591
        Medium,
        #pragma warning restore CS1591
        [EnumMember(Value = "low")]
        #pragma warning disable CS1591
        Low,
        #pragma warning restore CS1591
    }
}
