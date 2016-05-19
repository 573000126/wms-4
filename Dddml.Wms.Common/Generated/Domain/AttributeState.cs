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

	public partial class AttributeState : AttributeStateProperties, IAttributeState, ISaveable
	{

		public virtual long Version { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.AttributeId;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IAttributeValueStates _attributeValues;
      
        public virtual IAttributeValueStates AttributeValues
        {
            get
            {
                return this._attributeValues;
            }
        }

        protected internal virtual void SetAttributeValues(IAttributeValueStates value)
        {
            this._attributeValues = value;
        }



		public AttributeState ()
		{
            _attributeValues = new AttributeValueStates(this);

		}



		#region Saveable Implements

        public virtual void Save()
        {
            _attributeValues.Save();

        }


		#endregion


		public virtual void When(IAttributeStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;
			this.OrganizationId = e.OrganizationId;
			this.Description = e.Description;
			this.IsMandatory = e.IsMandatory;
			this.IsInstanceAttribute = e.IsInstanceAttribute;
			this.AttributeValueType = e.AttributeValueType;
			this.AttributeValueLength = e.AttributeValueLength;
			this.IsList = e.IsList;
			this.FieldName = e.FieldName;
			this.ReferenceId = e.ReferenceId;
			this.Active = e.Active;
			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IAttributeValueStateCreated innerEvent in e.AttributeValueEvents) {
				IAttributeValueState innerState = this.AttributeValues.Get(innerEvent.GlobalId.Value);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IAttributeStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.IsPropertyNameRemoved)
			{
				this.Name = default(string);
			}
			else
			{
				if (e.Name != null)
				{
					this.Name = e.Name;
				}
			}
			if (e.IsPropertyOrganizationIdRemoved)
			{
				this.OrganizationId = default(string);
			}
			else
			{
				if (e.OrganizationId != null)
				{
					this.OrganizationId = e.OrganizationId;
				}
			}
			if (e.IsPropertyDescriptionRemoved)
			{
				this.Description = default(string);
			}
			else
			{
				if (e.Description != null)
				{
					this.Description = e.Description;
				}
			}
			if (e.IsPropertyIsMandatoryRemoved)
			{
				this.IsMandatory = default(bool);
			}
			else
			{
				if (e.IsMandatory != null)
				{
					this.IsMandatory = e.IsMandatory;
				}
			}
			if (e.IsPropertyIsInstanceAttributeRemoved)
			{
				this.IsInstanceAttribute = default(bool);
			}
			else
			{
				if (e.IsInstanceAttribute != null)
				{
					this.IsInstanceAttribute = e.IsInstanceAttribute;
				}
			}
			if (e.IsPropertyAttributeValueTypeRemoved)
			{
				this.AttributeValueType = default(string);
			}
			else
			{
				if (e.AttributeValueType != null)
				{
					this.AttributeValueType = e.AttributeValueType;
				}
			}
			if (e.IsPropertyAttributeValueLengthRemoved)
			{
				this.AttributeValueLength = default(int?);
			}
			else
			{
				if (e.AttributeValueLength != null)
				{
					this.AttributeValueLength = e.AttributeValueLength;
				}
			}
			if (e.IsPropertyIsListRemoved)
			{
				this.IsList = default(bool);
			}
			else
			{
				if (e.IsList != null)
				{
					this.IsList = e.IsList;
				}
			}
			if (e.IsPropertyFieldNameRemoved)
			{
				this.FieldName = default(string);
			}
			else
			{
				if (e.FieldName != null)
				{
					this.FieldName = e.FieldName;
				}
			}
			if (e.IsPropertyReferenceIdRemoved)
			{
				this.ReferenceId = default(string);
			}
			else
			{
				if (e.ReferenceId != null)
				{
					this.ReferenceId = e.ReferenceId;
				}
			}
			if (e.IsPropertyActiveRemoved)
			{
				this.Active = default(bool);
			}
			else
			{
				if (e.Active != null)
				{
					this.Active = e.Active;
				}
			}

			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IAttributeValueStateEvent innerEvent in e.AttributeValueEvents)
            {
                IAttributeValueState innerState = this.AttributeValues.Get(innerEvent.GlobalId.Value);

                var removed = innerEvent as IAttributeValueStateRemoved;
                if (removed != null)
                {
                    this.AttributeValues.Remove(innerState);
                }
                else
                {
                    innerState.Mutate(innerEvent);
                }
            }

		}

		public virtual void When(IAttributeStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;
		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeStateEvent stateEvent)
		{
			var stateEntityId = this.AttributeId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.AttributeId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}
			var stateVersion = this.Version;
			var eventVersion = stateEvent.StateEventId.Version;//EntityBase.Aggregate.GetStateEventIdPropertyVersionName()
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

