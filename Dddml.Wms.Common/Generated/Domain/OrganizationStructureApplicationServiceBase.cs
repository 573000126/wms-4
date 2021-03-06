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
	public abstract partial class OrganizationStructureApplicationServiceBase : IOrganizationStructureApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrganizationStructureStateRepository StateRepository { get; }

		protected OrganizationStructureApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrganizationStructureCommand c, Action<IOrganizationStructureAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetOrganizationStructureAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IOrganizationStructureStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IOrganizationStructureCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrganizationStructureState state)
		{
			bool repeated = false;
			if (((IOrganizationStructureStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IOrganizationStructureStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateOrganizationStructure c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrganizationStructure c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteOrganizationStructure c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IOrganizationStructureState Get(OrganizationStructureId id)
        {
            var state = StateRepository.Get(id);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IOrganizationStructureState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrganizationStructureState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrganizationStructureState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrganizationStructureState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IOrganizationStructureStateEvent GetStateEvent(OrganizationStructureId id, long version)
        {
            var e = (IOrganizationStructureStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(id), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IOrganizationStructureAggregate GetOrganizationStructureAggregate(IOrganizationStructureState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrganizationStructureId aggregateId);


	}

}

