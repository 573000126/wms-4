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

	public partial class LocatorState : LocatorStateProperties, ILocatorState
	{

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
				return this.LocatorId;
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
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
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

        bool ILocatorState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


		public LocatorState ()
		{
            InitializeProperties();
		}



		public virtual void When(ILocatorStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.WarehouseId = e.WarehouseId;

			this.ParentLocatorId = e.ParentLocatorId;

			this.LocatorType = e.LocatorType;

			this.PriorityNumber = e.PriorityNumber;

            this.IsDefault = (e.IsDefault != null && e.IsDefault.HasValue) ? e.IsDefault.Value : default(bool);

			this.X = e.X;

			this.Y = e.Y;

			this.Z = e.Z;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(ILocatorStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.WarehouseId == null)
			{
				if (e.IsPropertyWarehouseIdRemoved)
				{
					this.WarehouseId = default(string);
				}
			}
			else
			{
				this.WarehouseId = e.WarehouseId;
			}

			if (e.ParentLocatorId == null)
			{
				if (e.IsPropertyParentLocatorIdRemoved)
				{
					this.ParentLocatorId = default(string);
				}
			}
			else
			{
				this.ParentLocatorId = e.ParentLocatorId;
			}

			if (e.LocatorType == null)
			{
				if (e.IsPropertyLocatorTypeRemoved)
				{
					this.LocatorType = default(string);
				}
			}
			else
			{
				this.LocatorType = e.LocatorType;
			}

			if (e.PriorityNumber == null)
			{
				if (e.IsPropertyPriorityNumberRemoved)
				{
					this.PriorityNumber = default(string);
				}
			}
			else
			{
				this.PriorityNumber = e.PriorityNumber;
			}

			if (e.IsDefault == null)
			{
				if (e.IsPropertyIsDefaultRemoved)
				{
					this.IsDefault = default(bool);
				}
			}
			else
			{
				this.IsDefault = (e.IsDefault != null && e.IsDefault.HasValue) ? e.IsDefault.Value : default(bool);
			}

			if (e.X == null)
			{
				if (e.IsPropertyXRemoved)
				{
					this.X = default(string);
				}
			}
			else
			{
				this.X = e.X;
			}

			if (e.Y == null)
			{
				if (e.IsPropertyYRemoved)
				{
					this.Y = default(string);
				}
			}
			else
			{
				this.Y = e.Y;
			}

			if (e.Z == null)
			{
				if (e.IsPropertyZRemoved)
				{
					this.Z = default(string);
				}
			}
			else
			{
				this.Z = e.Z;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(ILocatorStateDeleted e)
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

		protected void ThrowOnWrongEvent(ILocatorStateEvent stateEvent)
		{
			var stateEntityId = this.LocatorId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.LocatorId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}

			var stateVersion = this.Version;
			var eventVersion = stateEvent.StateEventId.Version;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

