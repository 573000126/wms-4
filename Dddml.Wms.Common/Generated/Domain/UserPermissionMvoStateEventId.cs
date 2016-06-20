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

	public class UserPermissionMvoStateEventId
	{

		private UserPermissionId _userPermissionId = new UserPermissionId();

		public virtual UserPermissionId UserPermissionId { 
			get { return this._userPermissionId; } 
			internal set { _userPermissionId = value; } 
		}

		private long _userVersion;

		public virtual long UserVersion { 
			get { return this._userVersion; } 
			internal set { _userVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string UserPermissionIdUserId {
			get { return UserPermissionId.UserId; }
			internal set { UserPermissionId.UserId = value; }
		}

		public virtual string UserPermissionIdPermissionId {
			get { return UserPermissionId.PermissionId; }
			internal set { UserPermissionId.PermissionId = value; }
		}

        #endregion

		internal UserPermissionMvoStateEventId ()
		{
		}

		public UserPermissionMvoStateEventId (UserPermissionId userPermissionId, long userVersion)
		{
			this._userPermissionId = userPermissionId;
			this._userVersion = userVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionMvoStateEventId other = obj as UserPermissionMvoStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserPermissionId, other.UserPermissionId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserPermissionId != null) {
				hash += 13 * this.UserPermissionId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

