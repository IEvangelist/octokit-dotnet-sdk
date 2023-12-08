// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Orgs.Item.Invitations {
    /// <summary>The role for the new member.  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.   * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.   * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization.  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.</summary>
    public enum InvitationsPostRequestBody_role {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "direct_member")]
        Direct_member,
        [EnumMember(Value = "billing_manager")]
        Billing_manager,
        [EnumMember(Value = "reinstate")]
        Reinstate,
    }
}