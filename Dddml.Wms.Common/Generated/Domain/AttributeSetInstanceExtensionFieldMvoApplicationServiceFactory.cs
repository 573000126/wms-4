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

    public partial class AttributeSetInstanceExtensionFieldMvoApplicationServiceFactory : IAttributeSetInstanceExtensionFieldMvoApplicationServiceFactory
    {

        public virtual IAttributeSetInstanceExtensionFieldMvoApplicationService AttributeSetInstanceExtensionFieldMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["AttributeSetInstanceExtensionFieldMvoApplicationService"] as IAttributeSetInstanceExtensionFieldMvoApplicationService;
		    }
        }

        public virtual ICreateAttributeSetInstanceExtensionFieldMvo NewCreateAttributeSetInstanceExtensionFieldMvo()
        {
		    return new CreateAttributeSetInstanceExtensionFieldMvo();
        }

        public virtual IMergePatchAttributeSetInstanceExtensionFieldMvo NewMergePatchAttributeSetInstanceExtensionFieldMvo()
        {
            return new MergePatchAttributeSetInstanceExtensionFieldMvo();
        }

        public virtual IDeleteAttributeSetInstanceExtensionFieldMvo NewDeleteAttributeSetInstanceExtensionFieldMvo()
        {
            return new DeleteAttributeSetInstanceExtensionFieldMvo();
        }

    }


}
