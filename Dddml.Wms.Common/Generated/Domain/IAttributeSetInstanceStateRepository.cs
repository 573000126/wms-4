﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;


namespace Dddml.Wms.Domain
{
	public interface IAttributeSetInstanceStateRepository
	{
        IAttributeSetInstanceState Get(string id);

        IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults);
        
        void Save(IAttributeSetInstanceState state);
        
        IEnumerable<IAttributeSetInstanceState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

	}

}

