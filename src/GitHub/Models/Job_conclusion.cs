// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The outcome of the job.</summary>
    public enum Job_conclusion
    {
        [EnumMember(Value = "success")]
        #pragma warning disable CS1591
        Success,
        #pragma warning restore CS1591
        [EnumMember(Value = "failure")]
        #pragma warning disable CS1591
        Failure,
        #pragma warning restore CS1591
        [EnumMember(Value = "neutral")]
        #pragma warning disable CS1591
        Neutral,
        #pragma warning restore CS1591
        [EnumMember(Value = "cancelled")]
        #pragma warning disable CS1591
        Cancelled,
        #pragma warning restore CS1591
        [EnumMember(Value = "skipped")]
        #pragma warning disable CS1591
        Skipped,
        #pragma warning restore CS1591
        [EnumMember(Value = "timed_out")]
        #pragma warning disable CS1591
        Timed_out,
        #pragma warning restore CS1591
        [EnumMember(Value = "action_required")]
        #pragma warning disable CS1591
        Action_required,
        #pragma warning restore CS1591
    }
}
