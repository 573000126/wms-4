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

	public class AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "Id", "Version" };

        string[] IIdFlattenedDto.FieldNames
        {
            get { return _flattenedPropertyNames; }
        }

        object IIdFlattenedDto.GetFieldValue(string fieldName)
        {
            return ReflectUtils.GetPropertyValue(fieldName, this._value);
        }

        void IIdFlattenedDto.SetFieldValue(string fieldName, object fieldValue)
        {
            ReflectUtils.SetPropertyValue(fieldName, this._value, fieldValue);
        }

        Type IIdFlattenedDto.GetFieldType(string fieldName)
        {
            if (fieldName.Equals("Id", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Version", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private AttributeSetInstanceExtensionFieldGroupStateEventId _value = new AttributeSetInstanceExtensionFieldGroupStateEventId();

		public AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto()
		{
		}

		public AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto(AttributeSetInstanceExtensionFieldGroupStateEventId val)
		{
			this._value = val;
		}

        public AttributeSetInstanceExtensionFieldGroupStateEventId ToAttributeSetInstanceExtensionFieldGroupStateEventId()
        {
            return this._value;
        }


		public virtual string Id { 
			get { return _value.Id; } 
			set { _value.Id = value; } 
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

			AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto other = obj as AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto;
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


