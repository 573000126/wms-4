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

	public abstract class UserRoleCommandBase : IUserRoleCommand
	{
		public virtual string RoleId { get; set; }


		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual bool? Active { get; set; }

		// Outer Id:

		public virtual string UserId { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class UserRoleIdGeneratorBase : IIdGenerator<string, ICreateUserRole>
    {
        public abstract string GenerateId(ICreateUserRole command);

        public abstract string GetNextId();

        public virtual string GetOrGenerateId(ICreateUserRole command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateUserRole : UserRoleCommandBase, ICreateUserRole
	{
		
		public CreateUserRole ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchUserRole :UserRoleCommandBase, IMergePatchUserRole
	{

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchUserRole ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveUserRole : UserRoleCommandBase, IRemoveUserRole
	{
		public RemoveUserRole ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }
	}



}
