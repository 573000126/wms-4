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

	public partial class RoleStateDto : StateDtoBase, IRoleState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private RoleState _state;

        public RoleStateDto()
        {
            this._state = new RoleState();
        }

		public RoleStateDto(RoleState state)
		{
            this._state = state;
		}

		internal RoleState ToRoleState()
		{
			return this._state;
		}

		public virtual string RoleId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("RoleId"))
                {
                    return _state.RoleId;
                }
                return null;
            }
            set
            {
                _state.RoleId = value;
            }
        }

        string IRoleStateProperties.RoleId
        {
            get 
            {
                return (this._state as IRoleStateProperties).RoleId;
            }
            set 
            {
                this._state.RoleId = value;
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

        string IRoleStateProperties.Name
        {
            get 
            {
                return (this._state as IRoleStateProperties).Name;
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

        string IRoleStateProperties.Description
        {
            get 
            {
                return (this._state as IRoleStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
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

        bool IRoleStateProperties.Active
        {
            get 
            {
                return (this._state as IRoleStateProperties).Active;
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

        long IRoleStateProperties.Version
        {
            get 
            {
                return (this._state as IRoleStateProperties).Version;
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
			get { return (_state as IRoleState).GlobalId; }
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
            get { return (_state as IRoleState).CreatedBy; }
            set { (_state as IRoleState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IRoleState).CreatedAt; }
            set { (_state as IRoleState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IRoleState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IRoleState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IRoleState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == RoleState.VersionZero; }
        }


		void IRoleState.When(IRoleStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IRoleState.When(IRoleStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IRoleState.When(IRoleStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IRoleState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class RoleStateDtoCollection : StateDtoCollectionBase<RoleStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(RoleStateDto._collectionFieldNames, fieldName);
        }

    }

}

