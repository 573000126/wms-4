﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization;


namespace Dddml.Wms.Domain
{

	public class AttributeValueStateEventIdDto
	{

        private AttributeValueStateEventId _value = new AttributeValueStateEventId();

		public AttributeValueStateEventIdDto()
		{
		}

		public AttributeValueStateEventIdDto(AttributeValueStateEventId val)
		{
			this._value = val;
		}

        public AttributeValueStateEventId ToAttributeValueStateEventId()
        {
            return this._value;
        }

		public virtual string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}

		public virtual string Value { 
			get { return _value.Value; } 
			set { _value.Value = value; } 
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

			AttributeValueStateEventIdDto other = obj as AttributeValueStateEventIdDto;
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


