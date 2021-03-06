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

    public class UserPermissionStates : IUserPermissionStates
    {
        
		protected IUserPermissionStateDao UserPermissionStateDao
		{
			get
			{
				return ApplicationContext.Current["UserPermissionStateDao"] as IUserPermissionStateDao;
			}
		}

		private Dictionary<UserPermissionId, IUserPermissionState> _loadedUserPermissionStates = new Dictionary<UserPermissionId, IUserPermissionState>();

        private List<IUserPermissionState> _removedUserPermissionStates = new List<IUserPermissionState>();

		protected virtual IEnumerable<IUserPermissionState> LoadedUserPermissionStates {
			get {
				return this._loadedUserPermissionStates.Values;
			}
		}

        private IUserState _userState;

        private IEnumerable<IUserPermissionState> _innerEnumerable;

        private IEnumerable<IUserPermissionState> InnerEnumeralbe
        {
            get
            {
                if (_innerEnumerable == null)
                {
                    _innerEnumerable = UserPermissionStateDao.FindByUserId(_userState.UserId);
                }
                return _innerEnumerable;
            }
        }

        public UserPermissionStates(IUserState outerState)
        {
            this._userState = outerState;
        }

        public IEnumerator<IUserPermissionState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IUserPermissionState state)
        {
            this._removedUserPermissionStates.Add(state);
        }

        public virtual IUserPermissionState Get(string permissionId)
		{
			UserPermissionId globalId = new UserPermissionId(_userState.UserId, permissionId);
            if (_loadedUserPermissionStates.ContainsKey(globalId)) {
                return _loadedUserPermissionStates[globalId];
            }
            var state = UserPermissionStateDao.Get(globalId);
			_loadedUserPermissionStates.Add (globalId, state);
			return state;
		}

        public virtual void AddToSave(IUserPermissionState state)
        {
            this._loadedUserPermissionStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IUserPermissionState s in this.LoadedUserPermissionStates) {
                UserPermissionStateDao.Save(s);
			}
            foreach(IUserPermissionState s in this._removedUserPermissionStates)
            {
                UserPermissionStateDao.Delete(s);
            }
		}

		#endregion


    }



}


