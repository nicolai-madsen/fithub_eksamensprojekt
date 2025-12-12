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
        // <--- Create Service --->
        private readonly CreateMembershipDL _createMembershipDL;
        public MembershipService(CreateMembershipDL membershipDL) 
        {
            _createMembershipDL = membershipDL; // Injects the DAL into Create Service
        }
        public MembershipModel CreateMembership(MembershipModel membership)
        {
            // Validering (Tomt felt) på MembershipName
            if (string.IsNullOrEmpty(membership.MembershipName))
                throw new ArgumentNullException("Aktivitets-navn skal udfyldes");

            // Validering (Tomt felt) på MembershipDescription
            if (string.IsNullOrEmpty(membership.MembershipDescription))
                throw new ArgumentNullException("Aktivitets-beskrivelse skal udfyldes");

            // Validering (Tomt felt) på MembershipDescription
            if (decimal.(membership.MonthlyPrice))
                throw new ArgumentNullException("Aktivitets-beskrivelse skal udfyldes");


            // Få ID på oprettet row tilbage, så det kan vises i UI
            int newId = _createMembershipDL.CreateMembership(membership);

            // Sæt objekt property til det hentede ID
            membership.MembershipId = newId;

            return membership;
        }

        // <--- Update Service --->
        private readonly UpdateMembershipDL _updateMembershipDL;
        public int UpdateMembership(MembershipModel membership) 
        {
            return _updateMembershipDL.UpdateMembership(membership); // Call update method in UpdateDL on membership object (data for DB)
        }
    }
}
