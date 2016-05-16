﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{
	public interface IAttributeSetInstanceExtensionFieldCommand : ICommand
	{
	}

	public interface ICreateAttributeSetInstanceExtensionField : IAttributeSetInstanceExtensionFieldCommand, IAttributeSetInstanceExtensionFieldStateProperties
	{
	}


	public interface IMergePatchAttributeSetInstanceExtensionField : IAttributeSetInstanceExtensionFieldCommand, IAttributeSetInstanceExtensionFieldStateProperties
	{

		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyTypeRemoved { get; set; }

		bool IsPropertyLengthRemoved { get; set; }

		bool IsPropertyAliasRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveAttributeSetInstanceExtensionField : IAttributeSetInstanceExtensionFieldCommand, IAttributeSetInstanceExtensionFieldStateProperties
	{
	}


}
