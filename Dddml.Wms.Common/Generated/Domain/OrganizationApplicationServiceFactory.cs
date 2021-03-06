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

    public partial class OrganizationApplicationServiceFactory : IOrganizationApplicationServiceFactory
    {

        public virtual IOrganizationApplicationService OrganizationApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrganizationApplicationService"] as IOrganizationApplicationService;
		    }
        }

        public virtual ICreateOrganization NewCreateOrganization()
        {
		    return new CreateOrganization();
        }

        public virtual IMergePatchOrganization NewMergePatchOrganization()
        {
            return new MergePatchOrganization();
        }

        public virtual IDeleteOrganization NewDeleteOrganization()
        {
            return new DeleteOrganization();
        }

    }


}

