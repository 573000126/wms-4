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

	public class AttributeSetInstanceExtensionFieldIdDto
	{

        private AttributeSetInstanceExtensionFieldId _value = new AttributeSetInstanceExtensionFieldId();

		public AttributeSetInstanceExtensionFieldIdDto()
		{
		}

		public AttributeSetInstanceExtensionFieldIdDto(AttributeSetInstanceExtensionFieldId val)
		{
			this._value = val;
		}

        public AttributeSetInstanceExtensionFieldId ToAttributeSetInstanceExtensionFieldId()
        {
            return this._value;
        }

		public virtual string GroupId { 
			get { return _value.GroupId; } 
			set { _value.GroupId = value; } 
		}

		public virtual string Index { 
			get { return _value.Index; } 
			set { _value.Index = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetInstanceExtensionFieldIdDto other = obj as AttributeSetInstanceExtensionFieldIdDto;
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


