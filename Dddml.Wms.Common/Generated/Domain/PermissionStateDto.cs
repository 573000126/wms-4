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

	public partial class PermissionStateDto : StateDtoBase, IPermissionState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private PermissionState _state;

        public PermissionStateDto()
        {
            this._state = new PermissionState();
        }

		public PermissionStateDto(PermissionState state)
		{
            this._state = state;
		}

		internal PermissionState ToPermissionState()
		{
			return this._state;
		}

		public virtual string PermissionId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PermissionId"))
                {
                    return _state.PermissionId;
                }
                return null;
            }
            set
            {
                _state.PermissionId = value;
            }
        }

        string IPermissionStateProperties.PermissionId
        {
            get 
            {
                return (this._state as IPermissionStateProperties).PermissionId;
            }
            set 
            {
                this._state.PermissionId = value;
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

        string IPermissionStateProperties.Name
        {
            get 
            {
                return (this._state as IPermissionStateProperties).Name;
            }
            set 
            {
                this._state.Name = value;
            }
        }

		public virtual string ParentPermissionId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("ParentPermissionId"))
                {
                    return _state.ParentPermissionId;
                }
                return null;
            }
            set
            {
                _state.ParentPermissionId = value;
            }
        }

        string IPermissionStateProperties.ParentPermissionId
        {
            get 
            {
                return (this._state as IPermissionStateProperties).ParentPermissionId;
            }
            set 
            {
                this._state.ParentPermissionId = value;
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

        string IPermissionStateProperties.Description
        {
            get 
            {
                return (this._state as IPermissionStateProperties).Description;
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

        bool IPermissionStateProperties.Active
        {
            get 
            {
                return (this._state as IPermissionStateProperties).Active;
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

        long IPermissionStateProperties.Version
        {
            get 
            {
                return (this._state as IPermissionStateProperties).Version;
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
			get { return (_state as IPermissionState).GlobalId; }
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
            get { return (_state as IPermissionState).CreatedBy; }
            set { (_state as IPermissionState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IPermissionState).CreatedAt; }
            set { (_state as IPermissionState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IPermissionState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IPermissionState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IPermissionState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == PermissionState.VersionZero; }
        }


		void IPermissionState.When(IPermissionStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IPermissionState.When(IPermissionStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IPermissionState.When(IPermissionStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IPermissionState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class PermissionStateDtoCollection : StateDtoCollectionBase<PermissionStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(PermissionStateDto._collectionFieldNames, fieldName);
        }

    }

}

