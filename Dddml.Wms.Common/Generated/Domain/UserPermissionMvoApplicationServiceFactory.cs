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

    public partial class UserPermissionMvoApplicationServiceFactory : IUserPermissionMvoApplicationServiceFactory
    {

        public virtual IUserPermissionMvoApplicationService UserPermissionMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["UserPermissionMvoApplicationService"] as IUserPermissionMvoApplicationService;
		    }
        }

        public virtual ICreateUserPermissionMvo NewCreateUserPermissionMvo()
        {
		    return new CreateUserPermissionMvo();
        }

        public virtual IMergePatchUserPermissionMvo NewMergePatchUserPermissionMvo()
        {
            return new MergePatchUserPermissionMvo();
        }

        public virtual IDeleteUserPermissionMvo NewDeleteUserPermissionMvo()
        {
            return new DeleteUserPermissionMvo();
        }

    }


}

