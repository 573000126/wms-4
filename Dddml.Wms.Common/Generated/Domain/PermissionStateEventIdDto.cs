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

	public class PermissionStateEventIdDto
	{

        private PermissionStateEventId _value = new PermissionStateEventId();

		public PermissionStateEventIdDto()
		{
		}

		public PermissionStateEventIdDto(PermissionStateEventId val)
		{
			this._value = val;
		}

        public PermissionStateEventId ToPermissionStateEventId()
        {
            return this._value;
        }

		public virtual string PermissionId { 
			get { return _value.PermissionId; } 
			set { _value.PermissionId = value; } 
		}

		public virtual long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			PermissionStateEventIdDto other = obj as PermissionStateEventIdDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

}


