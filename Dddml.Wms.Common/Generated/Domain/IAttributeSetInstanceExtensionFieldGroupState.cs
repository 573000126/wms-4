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
	public interface IAttributeSetInstanceExtensionFieldGroupState : IAttributeSetInstanceExtensionFieldGroupStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IVersioned<long>
	{
		
		void When(IAttributeSetInstanceExtensionFieldGroupStateCreated e);

		void When(IAttributeSetInstanceExtensionFieldGroupStateMergePatched e);

		void When(IAttributeSetInstanceExtensionFieldGroupStateDeleted e);

		void Mutate(IEvent e);


		IAttributeSetInstanceExtensionFieldStates Fields { get; }


	}
}
