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

	public class OrganizationStructureStateEventIdDto
	{

        private OrganizationStructureStateEventId _value = new OrganizationStructureStateEventId();

		public OrganizationStructureStateEventIdDto()
		{
		}

		public OrganizationStructureStateEventIdDto(OrganizationStructureStateEventId val)
		{
			this._value = val;
		}

        public OrganizationStructureStateEventId ToOrganizationStructureStateEventId()
        {
            return this._value;
        }

		public virtual OrganizationStructureIdDto Id { 
			get { return new OrganizationStructureIdDto(_value.Id); } 
			set { _value.Id = value.ToOrganizationStructureId(); } 
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

			OrganizationStructureStateEventIdDto other = obj as OrganizationStructureStateEventIdDto;
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

