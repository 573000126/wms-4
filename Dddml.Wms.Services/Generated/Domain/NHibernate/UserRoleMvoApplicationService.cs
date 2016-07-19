﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class UserRoleMvoApplicationService : UserRoleMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IUserRoleMvoStateRepository _stateRepository;

		protected override IUserRoleMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		public UserRoleMvoApplicationService(IEventStore eventStore, IUserRoleMvoStateRepository stateRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(UserRoleId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IUserRoleMvoAggregate GetUserRoleMvoAggregate(IUserRoleMvoState state)
		{
			return new UserRoleMvoAggregate(state);
		}

	}

}

