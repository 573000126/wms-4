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

	public static partial class AttributeSetInstanceExtensionFieldMvoStateDtoExtensions
	{

        public static IAttributeSetInstanceExtensionFieldMvoCommand ToCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDto state)
        {
            return state.ToCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo<CreateAttributeSetInstanceExtensionFieldMvoDto, MergePatchAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static DeleteAttributeSetInstanceExtensionFieldMvoDto ToDeleteAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDto state)
        {
            return state.ToDeleteAttributeSetInstanceExtensionFieldMvo<DeleteAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static MergePatchAttributeSetInstanceExtensionFieldMvoDto ToMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDto state)
        {
            return state.ToMergePatchAttributeSetInstanceExtensionFieldMvo<MergePatchAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static CreateAttributeSetInstanceExtensionFieldMvoDto ToCreateAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDto state)
        {
            return state.ToCreateAttributeSetInstanceExtensionFieldMvo<CreateAttributeSetInstanceExtensionFieldMvoDto>();
        }
		

	}

}

