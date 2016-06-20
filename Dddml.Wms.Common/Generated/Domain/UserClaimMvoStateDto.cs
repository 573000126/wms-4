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

	public partial class UserClaimMvoStateDto : StateDtoBase, IUserClaimMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private UserClaimMvoState _state;

        public UserClaimMvoStateDto()
        {
            this._state = new UserClaimMvoState();
        }

		public UserClaimMvoStateDto(UserClaimMvoState state)
		{
            this._state = state;
		}

		internal UserClaimMvoState ToUserClaimMvoState()
		{
			return this._state;
		}


        public UserClaimIdDto UserClaimId
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserClaimId"))
                {
					return new UserClaimIdDto(_state.UserClaimId);
                }
                return null;
            }
            set
            {
                _state.UserClaimId = value.ToUserClaimId();
            }
        }


        UserClaimId IUserClaimMvoStateProperties.UserClaimId
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserClaimId;
            }
            set 
            {
                this._state.UserClaimId = value;
            }
        }

		public virtual string ClaimType
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("ClaimType"))
                {
                    return _state.ClaimType;
                }
                return null;
            }
            set
            {
                _state.ClaimType = value;
            }
        }

        string IUserClaimMvoStateProperties.ClaimType
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).ClaimType;
            }
            set 
            {
                this._state.ClaimType = value;
            }
        }

		public virtual string ClaimValue
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("ClaimValue"))
                {
                    return _state.ClaimValue;
                }
                return null;
            }
            set
            {
                _state.ClaimValue = value;
            }
        }

        string IUserClaimMvoStateProperties.ClaimValue
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).ClaimValue;
            }
            set 
            {
                this._state.ClaimValue = value;
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

        long IUserClaimMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
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

        bool IUserClaimMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual string UserUserName
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserUserName"))
                {
                    return _state.UserUserName;
                }
                return null;
            }
            set
            {
                _state.UserUserName = value;
            }
        }

        string IUserClaimMvoStateProperties.UserUserName
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserUserName;
            }
            set 
            {
                this._state.UserUserName = value;
            }
        }

		public virtual int? UserAccessFailedCount
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserAccessFailedCount"))
                {
                    return _state.UserAccessFailedCount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserAccessFailedCount = value.Value;
                }
            }
        }

        int IUserClaimMvoStateProperties.UserAccessFailedCount
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserAccessFailedCount;
            }
            set 
            {
                this._state.UserAccessFailedCount = value;
            }
        }

		public virtual string UserEmail
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserEmail"))
                {
                    return _state.UserEmail;
                }
                return null;
            }
            set
            {
                _state.UserEmail = value;
            }
        }

        string IUserClaimMvoStateProperties.UserEmail
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserEmail;
            }
            set 
            {
                this._state.UserEmail = value;
            }
        }

		public virtual bool? UserEmailConfirmed
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserEmailConfirmed"))
                {
                    return _state.UserEmailConfirmed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserEmailConfirmed = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserEmailConfirmed
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserEmailConfirmed;
            }
            set 
            {
                this._state.UserEmailConfirmed = value;
            }
        }

		public virtual bool? UserLockoutEnabled
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserLockoutEnabled"))
                {
                    return _state.UserLockoutEnabled;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserLockoutEnabled = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserLockoutEnabled
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserLockoutEnabled;
            }
            set 
            {
                this._state.UserLockoutEnabled = value;
            }
        }

		public virtual DateTime? UserLockoutEndDateUtc
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserLockoutEndDateUtc"))
                {
                    return _state.UserLockoutEndDateUtc;
                }
                return null;
            }
            set
            {
                _state.UserLockoutEndDateUtc = value;
            }
        }

        DateTime? IUserClaimMvoStateProperties.UserLockoutEndDateUtc
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserLockoutEndDateUtc;
            }
            set 
            {
                this._state.UserLockoutEndDateUtc = value;
            }
        }

		public virtual string UserPasswordHash
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserPasswordHash"))
                {
                    return _state.UserPasswordHash;
                }
                return null;
            }
            set
            {
                _state.UserPasswordHash = value;
            }
        }

        string IUserClaimMvoStateProperties.UserPasswordHash
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserPasswordHash;
            }
            set 
            {
                this._state.UserPasswordHash = value;
            }
        }

		public virtual string UserPhoneNumber
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserPhoneNumber"))
                {
                    return _state.UserPhoneNumber;
                }
                return null;
            }
            set
            {
                _state.UserPhoneNumber = value;
            }
        }

        string IUserClaimMvoStateProperties.UserPhoneNumber
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserPhoneNumber;
            }
            set 
            {
                this._state.UserPhoneNumber = value;
            }
        }

		public virtual bool? UserPhoneNumberConfirmed
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserPhoneNumberConfirmed"))
                {
                    return _state.UserPhoneNumberConfirmed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserPhoneNumberConfirmed = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserPhoneNumberConfirmed
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserPhoneNumberConfirmed;
            }
            set 
            {
                this._state.UserPhoneNumberConfirmed = value;
            }
        }

		public virtual bool? UserTwoFactorEnabled
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserTwoFactorEnabled"))
                {
                    return _state.UserTwoFactorEnabled;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserTwoFactorEnabled = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserTwoFactorEnabled
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserTwoFactorEnabled;
            }
            set 
            {
                this._state.UserTwoFactorEnabled = value;
            }
        }

		public virtual string UserSecurityStamp
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserSecurityStamp"))
                {
                    return _state.UserSecurityStamp;
                }
                return null;
            }
            set
            {
                _state.UserSecurityStamp = value;
            }
        }

        string IUserClaimMvoStateProperties.UserSecurityStamp
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserSecurityStamp;
            }
            set 
            {
                this._state.UserSecurityStamp = value;
            }
        }

		public virtual string UserCreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserCreatedBy"))
                {
                    return _state.UserCreatedBy;
                }
                return null;
            }
            set
            {
                _state.UserCreatedBy = value;
            }
        }

        string IUserClaimMvoStateProperties.UserCreatedBy
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserCreatedBy;
            }
            set 
            {
                this._state.UserCreatedBy = value;
            }
        }

		public virtual DateTime? UserCreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserCreatedAt"))
                {
                    return _state.UserCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserCreatedAt = value.Value;
                }
            }
        }

        DateTime IUserClaimMvoStateProperties.UserCreatedAt
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserCreatedAt;
            }
            set 
            {
                this._state.UserCreatedAt = value;
            }
        }

		public virtual string UserUpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserUpdatedBy"))
                {
                    return _state.UserUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UserUpdatedBy = value;
            }
        }

        string IUserClaimMvoStateProperties.UserUpdatedBy
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserUpdatedBy;
            }
            set 
            {
                this._state.UserUpdatedBy = value;
            }
        }

		public virtual DateTime? UserUpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserUpdatedAt"))
                {
                    return _state.UserUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserUpdatedAt = value.Value;
                }
            }
        }

        DateTime IUserClaimMvoStateProperties.UserUpdatedAt
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserUpdatedAt;
            }
            set 
            {
                this._state.UserUpdatedAt = value;
            }
        }

		public virtual bool? UserActive
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserActive"))
                {
                    return _state.UserActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserActive = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserActive
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserActive;
            }
            set 
            {
                this._state.UserActive = value;
            }
        }

		public virtual bool? UserDeleted
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserDeleted"))
                {
                    return _state.UserDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserDeleted = value.Value;
                }
            }
        }

        bool IUserClaimMvoStateProperties.UserDeleted
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserDeleted;
            }
            set 
            {
                this._state.UserDeleted = value;
            }
        }

		public virtual long? UserVersion
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserVersion"))
                {
                    return _state.UserVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserVersion = value.Value;
                }
            }
        }

        long IUserClaimMvoStateProperties.UserVersion
        {
            get 
            {
                return (this._state as IUserClaimMvoStateProperties).UserVersion;
            }
            set 
            {
                this._state.UserVersion = value;
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

		UserClaimId IGlobalIdentity<UserClaimId>.GlobalId
		{
			get { return (_state as IUserClaimMvoState).GlobalId; }
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
            get { return (_state as IUserClaimMvoState).CreatedBy; }
            set { (_state as IUserClaimMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserClaimMvoState).CreatedAt; }
            set { (_state as IUserClaimMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserClaimMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserClaimMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.UserVersion; }
		}

		#endregion

        bool IUserClaimMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == UserClaimMvoState.VersionZero; }
        }

        public virtual UserLoginDto[] UserUserLogins
        {
            get 
            {
                if (!(this as IStateDto).ReturnedFieldsContains("UserUserLogins"))
                {
                    return null;
                }
                var dtos = new List<UserLoginDto>();
                if (this._state.UserUserLogins != null)
                {
                    foreach (var s in this._state.UserUserLogins)
                    {
                        var dto = new UserLoginDto(s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "UserUserLogins");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDto).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDto).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { return; }
                var states = new HashSet<UserLogin>();
                foreach (var s in value)
                {
                    states.Add(s.ToUserLogin());
                }
                this._state.UserUserLogins = states;
            }
        }

        ISet<UserLogin> IUserClaimMvoState.UserUserLogins 
        {
            get { return _state.UserUserLogins; }
            set { _state.UserUserLogins = value; }
        }


		void IUserClaimMvoState.When(IUserClaimMvoStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IUserClaimMvoState.When(IUserClaimMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserClaimMvoState.When(IUserClaimMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IUserClaimMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class UserClaimMvoStateDtoCollection : StateDtoCollectionBase<UserClaimMvoStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserClaimMvoStateDto._collectionFieldNames, fieldName);
        }

    }

}

