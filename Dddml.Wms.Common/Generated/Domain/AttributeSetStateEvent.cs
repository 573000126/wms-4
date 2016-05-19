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

	public abstract class AttributeSetStateEventBase : AttributeSetStateProperties, IAttributeSetStateEvent
	{

		public virtual AttributeSetStateEventId StateEventId { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }//TODO CommandId 太特殊了！！！

		AttributeSetStateEventId IGlobalIdentity<AttributeSetStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

		public override string AttributeSetId {
			get {
				return StateEventId.AttributeSetId;//EntityBase.Aggregate.GetStateEventIdPropertyIdName()
			}
			set {
				throw new NotSupportedException ();
			}
		}

		public virtual long Version {
			get {
				return StateEventId.Version;//EntityBase.Aggregate.GetStateEventIdPropertyVersionName()
			}
			set {
				throw new NotSupportedException ();
			}
		}


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
		}

        protected AttributeSetStateEventBase()
        {
        }

        protected AttributeSetStateEventBase(AttributeSetStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        protected AttributeUseStateEventId NewAttributeUseStateEventId(string attributeId)
        {
            var stateEventId = new AttributeUseStateEventId(this.StateEventId.AttributeSetId, attributeId, this.StateEventId.Version);
            return stateEventId;
        }

		protected void ThrowOnInconsistentEventIds(IAttributeUseStateEvent e)
		{
			if (this.StateEventId.AttributeSetId != e.StateEventId.AttributeSetId) 
			{ 
				DomainError.Named("inconsistentEventIds", "Outer Id AttributeSetId {0} but inner id AttributeSetId {1}", 
					this.StateEventId.AttributeSetId, e.StateEventId.AttributeSetId);
			}
		}



	}

	public class AttributeSetStateCreated : AttributeSetStateEventBase, IAttributeSetStateCreated, ISaveable
	{
		public AttributeSetStateCreated ()
		{
		}

		public AttributeSetStateCreated (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeUseStateEventId, IAttributeUseStateCreated> _attributeUseEvents = new Dictionary<AttributeUseStateEventId, IAttributeUseStateCreated>();
		
		public virtual IEnumerable<IAttributeUseStateCreated> AttributeUseEvents {
			get {
				return this._attributeUseEvents.Values;
			}
		}
	
		public virtual void AddAttributeUseEvent(IAttributeUseStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeUseEvents[e.StateEventId] = e;
		}

        public virtual AttributeUseStateCreated NewAttributeUseStateCreated(string attributeId)
        {
            var stateEvent = new AttributeUseStateCreated(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeUseStateCreated e in this.AttributeUseEvents) {
				(ApplicationContext.Current["AttributeUseStateEventDao"] as IAttributeUseStateEventDao).Save(e);
			}
		}

	}


	public class AttributeSetStateMergePatched : AttributeSetStateEventBase, IAttributeSetStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySerialNumberAttributeIdRemoved { get; set; }

		public virtual bool IsPropertyLotAttributeIdRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeSetStateMergePatched ()
		{
		}

		public AttributeSetStateMergePatched (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeUseStateEventId, IAttributeUseStateEvent> _attributeUseEvents = new Dictionary<AttributeUseStateEventId, IAttributeUseStateEvent>();
		
		public virtual IEnumerable<IAttributeUseStateEvent> AttributeUseEvents {
			get {
				return this._attributeUseEvents.Values;
			}
		}
	
		public virtual void AddAttributeUseEvent(IAttributeUseStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeUseEvents[e.StateEventId] = e;
		}

        public virtual AttributeUseStateCreated NewAttributeUseStateCreated(string attributeId)
        {
            var stateEvent = new AttributeUseStateCreated(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

        public virtual AttributeUseStateMergePatched NewAttributeUseStateMergePatched(string attributeId)
        {
            var stateEvent = new AttributeUseStateMergePatched(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

        public virtual AttributeUseStateRemoved NewAttributeUseStateRemoved(string attributeId)
        {
            var stateEvent = new AttributeUseStateRemoved(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeUseStateEvent e in this.AttributeUseEvents) {
				(ApplicationContext.Current["AttributeUseStateEventDao"] as IAttributeUseStateEventDao).Save(e);
			}
		}


	}


	public class AttributeSetStateDeleted : AttributeSetStateEventBase, IAttributeSetStateDeleted
	{
		public AttributeSetStateDeleted ()
		{
		}

		public AttributeSetStateDeleted (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

	}



}

