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

	public abstract class RolePermissionStateEventDtoBase : IStateEventDto, IRolePermissionStateCreated, IRolePermissionStateMergePatched, IRolePermissionStateDeleted
	{

		public virtual RolePermissionStateEventIdDto StateEventId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		RolePermissionStateEventId IGlobalIdentity<RolePermissionStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToRolePermissionStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IRolePermissionStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IRolePermissionStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        RolePermissionStateEventId IRolePermissionStateEvent.StateEventId
        {
            get { return this.StateEventId.ToRolePermissionStateEventId(); }
        }

        protected RolePermissionStateEventDtoBase()
        {
        }

        protected RolePermissionStateEventDtoBase(RolePermissionStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class RolePermissionStateCreatedOrMergePatchedOrDeletedDto : RolePermissionStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class RolePermissionStateCreatedDto : RolePermissionStateCreatedOrMergePatchedOrDeletedDto
	{
		public RolePermissionStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class RolePermissionStateMergePatchedDto : RolePermissionStateCreatedOrMergePatchedOrDeletedDto
	{
		public RolePermissionStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class RolePermissionStateDeletedDto : RolePermissionStateCreatedOrMergePatchedOrDeletedDto
	{
		public RolePermissionStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class RolePermissionStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IRolePermissionStateCreated>, IEnumerable<IRolePermissionStateMergePatched>, IEnumerable<IRolePermissionStateDeleted>
    {
        private List<RolePermissionStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<RolePermissionStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual RolePermissionStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<RolePermissionStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        public IEnumerator<IRolePermissionStateCreated> GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IRolePermissionStateMergePatched> IEnumerable<IRolePermissionStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IRolePermissionStateDeleted> IEnumerable<IRolePermissionStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddRolePermissionEvent(IRolePermissionStateCreated e)
        {
            _innerStateEvents.Add((RolePermissionStateCreatedDto)e);
        }

        public void AddRolePermissionEvent(IRolePermissionStateEvent e)
        {
            _innerStateEvents.Add((RolePermissionStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddRolePermissionEvent(IRolePermissionStateDeleted e)
        {
            _innerStateEvents.Add((RolePermissionStateDeletedDto)e);
        }

    }


}

