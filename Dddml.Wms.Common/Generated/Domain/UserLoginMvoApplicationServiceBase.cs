﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{
	public abstract partial class UserLoginMvoApplicationServiceBase : IUserLoginMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserLoginMvoStateRepository StateRepository { get; }

		protected UserLoginMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserLoginMvoCommand c, Action<IUserLoginMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetUserLoginMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IUserLoginMvoStateProperties)state).UserVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IUserLoginMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IUserLoginMvoState state)
		{
			bool repeated = false;
			if (((IUserLoginMvoStateProperties)state).UserVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IUserLoginMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateUserLoginMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUserLoginMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUserLoginMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserLoginMvoState Get(UserLoginId userLoginId)
        {
            var state = StateRepository.Get(userLoginId);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IUserLoginMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateRepository.GetCount(filter);
		}

	    public virtual IUserLoginMvoStateEvent GetStateEvent(UserLoginId userLoginId, long version)
        {
            var e = (IUserLoginMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(userLoginId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IUserLoginMvoAggregate GetUserLoginMvoAggregate(IUserLoginMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(UserLoginId aggregateId);


	}

}

