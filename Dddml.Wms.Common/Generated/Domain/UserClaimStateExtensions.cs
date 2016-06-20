﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public static partial class UserClaimStateExtensions
	{

        public static IUserClaimCommand ToCreateOrMergePatchUserClaim(this UserClaimState state)
        {
            bool bUnsaved = ((IUserClaimState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUserClaim();
            }
            else 
            {
                return state.ToMergePatchUserClaim();
            }
        }

        public static RemoveUserClaim ToRemoveUserClaim(this UserClaimState state)
        {
            var cmd = new RemoveUserClaim();
            cmd.ClaimId = state.ClaimId;
            return cmd;
        }

        public static MergePatchUserClaim ToMergePatchUserClaim(this UserClaimState state)
        {
            var cmd = new MergePatchUserClaim();

            cmd.ClaimId = state.ClaimId;
            cmd.ClaimType = state.ClaimType;
            cmd.ClaimValue = state.ClaimValue;
            cmd.Active = state.Active;
            cmd.UserId = state.UserId;
            
            if (state.ClaimType == null) { cmd.IsPropertyClaimTypeRemoved = true; }
            if (state.ClaimValue == null) { cmd.IsPropertyClaimValueRemoved = true; }
            return cmd;
        }

        public static CreateUserClaim ToCreateUserClaim(this UserClaimState state)
        {
            var cmd = new CreateUserClaim();

            cmd.ClaimId = state.ClaimId;
            cmd.ClaimType = state.ClaimType;
            cmd.ClaimValue = state.ClaimValue;
            cmd.Active = state.Active;
            cmd.UserId = state.UserId;
            return cmd;
        }
		

	}

}
