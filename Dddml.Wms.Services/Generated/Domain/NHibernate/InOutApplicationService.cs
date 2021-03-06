﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class InOutApplicationService : InOutApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IInOutStateRepository _stateRepository;

		protected override IInOutStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		public InOutApplicationService(IEventStore eventStore, IInOutStateRepository stateRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IInOutAggregate GetInOutAggregate(IInOutState state)
		{
			return new InOutAggregate(state);
		}

	}

}

