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

	public static partial class UserLoginMvoStateDtoExtensions
	{

        public static IUserLoginMvoCommand ToCreateOrMergePatchUserLoginMvo(this UserLoginMvoStateDto state)
        {
            return state.ToCreateOrMergePatchUserLoginMvo<CreateUserLoginMvoDto, MergePatchUserLoginMvoDto>();
        }

        public static DeleteUserLoginMvoDto ToDeleteUserLoginMvo(this UserLoginMvoStateDto state)
        {
            return state.ToDeleteUserLoginMvo<DeleteUserLoginMvoDto>();
        }

        public static MergePatchUserLoginMvoDto ToMergePatchUserLoginMvo(this UserLoginMvoStateDto state)
        {
            return state.ToMergePatchUserLoginMvo<MergePatchUserLoginMvoDto>();
        }

        public static CreateUserLoginMvoDto ToCreateUserLoginMvo(this UserLoginMvoStateDto state)
        {
            return state.ToCreateUserLoginMvo<CreateUserLoginMvoDto>();
        }
		

	}

}
