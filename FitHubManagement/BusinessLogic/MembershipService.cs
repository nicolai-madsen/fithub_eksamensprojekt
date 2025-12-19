using FitHubManagement.DataAccess;
using FitHubManagement.Models;

namespace FitHubManagement.BusinessLogic
{
    // NICOLAI - Hele filen
    public class MembershipService
    {


    
        private readonly MembershipDAL _membershipDAL = new MembershipDAL();
        

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

            int newId = _membershipDAL.CreateMembership(membership); // ID fra oprettet objekt bliver gemt som newId

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

            return _membershipDAL.UpdateMembership(membership);
        }

        // Hent (ID) Membership
        public MembershipModel GetMembership(int memebershipId)
        {
            return _membershipDAL.GetMembership(memebershipId);
        }

        // Hent alle Membership
        public List<MembershipModel> GetAllMemberships()
        {
            return _membershipDAL.GetAllMembership();
        }

        public string GetMembershipName(int membershipId)
        {
            return _membershipDAL.GetMembershipName(membershipId);
        }

        // Slet Membership
        public int DeleteMembership(int membershipId)
        {
            if (membershipId <= 0)
                throw new ArgumentException("Ugyldigt medlemskabs-ID");

            return _membershipDAL.DeleteMembership(membershipId);
        }
    }
}
