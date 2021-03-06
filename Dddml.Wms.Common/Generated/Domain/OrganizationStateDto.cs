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

	public partial class OrganizationStateDto : StateDtoBase, IOrganizationState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private OrganizationState _state;

        public OrganizationStateDto()
        {
            this._state = new OrganizationState();
        }

		public OrganizationStateDto(OrganizationState state)
		{
            this._state = state;
		}

		internal OrganizationState ToOrganizationState()
		{
			return this._state;
		}

		public virtual string OrganizationId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("OrganizationId"))
                {
                    return _state.OrganizationId;
                }
                return null;
            }
            set
            {
                _state.OrganizationId = value;
            }
        }

        string IOrganizationStateProperties.OrganizationId
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).OrganizationId;
            }
            set 
            {
                this._state.OrganizationId = value;
            }
        }

		public virtual string Name
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Name"))
                {
                    return _state.Name;
                }
                return null;
            }
            set
            {
                _state.Name = value;
            }
        }

        string IOrganizationStateProperties.Name
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Name;
            }
            set 
            {
                this._state.Name = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Description"))
                {
                    return _state.Description;
                }
                return null;
            }
            set
            {
                _state.Description = value;
            }
        }

        string IOrganizationStateProperties.Description
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
            }
        }

		public virtual string Type
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Type"))
                {
                    return _state.Type;
                }
                return null;
            }
            set
            {
                _state.Type = value;
            }
        }

        string IOrganizationStateProperties.Type
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Type;
            }
            set 
            {
                this._state.Type = value;
            }
        }

		public virtual bool? IsSummary
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("IsSummary"))
                {
                    return _state.IsSummary;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsSummary = value.Value;
                }
            }
        }

        bool IOrganizationStateProperties.IsSummary
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).IsSummary;
            }
            set 
            {
                this._state.IsSummary = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Active"))
                {
                    return _state.Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Active = value.Value;
                }
            }
        }

        bool IOrganizationStateProperties.Active
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Version"))
                {
                    return _state.Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Version = value.Value;
                }
            }
        }

        long IOrganizationStateProperties.Version
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }
		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }
		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }
		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IOrganizationState).GlobalId; }
		}

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IOrganizationState).CreatedBy; }
            set { (_state as IOrganizationState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrganizationState).CreatedAt; }
            set { (_state as IOrganizationState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrganizationState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrganizationState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IOrganizationState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == OrganizationState.VersionZero; }
        }


		void IOrganizationState.When(IOrganizationStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationState.When(IOrganizationStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrganizationState.When(IOrganizationStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class OrganizationStateDtoCollection : StateDtoCollectionBase<OrganizationStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrganizationStateDto._collectionFieldNames, fieldName);
        }

    }

}

