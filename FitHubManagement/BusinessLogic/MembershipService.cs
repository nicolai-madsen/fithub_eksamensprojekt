using FitHubManagement.DataLogic.MembershipDL;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic
{
    public class MembershipService
    {
        // DAL objekter
        private readonly CreateMembershipDL _createMembershipDL = new CreateMembershipDL();
        private readonly UpdateMembershipDL _updateMembershipDL = new UpdateMembershipDL();
        private readonly GetAllMembershipDL _getMembershipDL = new GetAllMembershipDL();
        private readonly GetAllMembershipDL _getAllMembershipDL = new GetAllMembershipDL();
        private readonly DeleteMembershipDL _deleteMembershipDL = new DeleteMembershipDL();

        // Opret Membership
        public MembershipModel CreateMembership(MembershipModel membership)
        {
            // Validering
            if (string.IsNullOrEmpty(membership.MembershipName))
                throw new ArgumentNullException("Aktivitets-navn skal udfyldes");

            if (string.IsNullOrEmpty(membership.MembershipDescription))
                throw new ArgumentNullException("Aktivitets-beskrivelse skal udfyldes");

            if (membership.MonthlyPrice < 0)
                throw new Exception("Månedspris skal være 0 eller større");

            int newId = _createMembershipDL.CreateMembership(membership); // ID fra oprettet objekt bliver gemt som newId

            membership.MembershipId = newId; // newId bliver sat ind som property MembershipId i model objektetet.

            return membership; // return model til validering i UI
        }

        // Opdater Membership
        public int UpdateMembership(MembershipModel membership)
        {
            // Validering
            if (string.IsNullOrEmpty(membership.MembershipName))
                throw new ArgumentNullException("Aktivitets-navn skal udfyldes");

            if (string.IsNullOrEmpty(membership.MembershipDescription))
                throw new ArgumentNullException("Aktivitets-beskrivelse skal udfyldes");

            if (membership.MonthlyPrice < 0)
                throw new Exception("Månedspris skal være 0 eller større");

            return _updateMembershipDL.UpdateMembership(membership);
        }

        // Hent (ID) Membership
        public MembershipModel GetMembership(int memebershipId)
        {
            return _getMembershipDL.GetMembership(memebershipId);
        }

        // Hent alle Membership
        public List<MembershipModel> GetAllMemberships()
        {
            return _getAllMembershipDL.GetAllMembership();
        }

        // Slet Membership
        public int DeleteMembership(int membershipId)
        {
            if (membershipId <= 0)
                throw new ArgumentException("Ugyldigt medlemskabs-ID");

            return _deleteMembershipDL.DeleteMembership(membershipId); 
        }
    }
}
