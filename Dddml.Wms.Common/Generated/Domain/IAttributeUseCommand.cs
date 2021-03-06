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
	public interface IAttributeUseCommand : ICommand, ICommandDto
	{

	}


	public interface ICreateOrMergePatchOrRemoveAttributeUse : IAttributeUseCommand
	{
		string AttributeId { get; set; }

		int? SequenceNumber { get; set; }

		bool? Active { get; set; }

		// Outer Id:

		string AttributeSetId { get; set; }


	}

	public interface ICreateAttributeUse : ICreateOrMergePatchOrRemoveAttributeUse
	{
	}

	public interface IMergePatchAttributeUse : ICreateOrMergePatchOrRemoveAttributeUse
	{

		bool IsPropertySequenceNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveAttributeUse : ICreateOrMergePatchOrRemoveAttributeUse
	{
	}


}

