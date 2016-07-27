﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{
    public partial class InOutAggregate : AggregateBase, IInOutAggregate
    {

        readonly IInOutState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IInOutState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public InOutAggregate(IInOutState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IInOutStateProperties)_state).Version == InOutState.VersionZero)
            {
                if (IsCommandCreate((IInOutCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IInOutCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IInOutCommand c)
        {
            return c.Version == InOutState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateInOut c)
        {
            IInOutStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchInOut c)
        {
            IInOutStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteInOut c)
        {
            IInOutStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IInOutStateCreated Map(ICreateInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateCreated e = NewInOutStateCreated(stateEventId);
		
            e.IsSOTransaction = c.IsSOTransaction;
            NewInOutDocumentActionCommandAndExecute(c, _state, e);
            e.Posted = c.Posted;
            e.Processing = c.Processing;
            e.Processed = c.Processed;
            e.DocumentType = c.DocumentType;
            e.Description = c.Description;
            e.OrderNumber = c.OrderNumber;
            e.DateOrdered = c.DateOrdered;
            e.IsPrinted = c.IsPrinted;
            e.MovementType = c.MovementType;
            e.MovementDate = c.MovementDate;
            e.BusinessPartnerId = c.BusinessPartnerId;
            e.WarehouseId = c.WarehouseId;
            e.POReference = c.POReference;
            e.FreightAmount = c.FreightAmount;
            e.ShipperId = c.ShipperId;
            e.ChargeAmount = c.ChargeAmount;
            e.DatePrinted = c.DatePrinted;
            e.SalesRepresentative = c.SalesRepresentative;
            e.NumberOfPackages = c.NumberOfPackages;
            e.PickDate = c.PickDate;
            e.ShipDate = c.ShipDate;
            e.TrackingNumber = c.TrackingNumber;
            e.DateReceived = c.DateReceived;
            e.IsInTransit = c.IsInTransit;
            e.IsApproved = c.IsApproved;
            e.IsInDispute = c.IsInDispute;
            e.Volume = c.Volume;
            e.Weight = c.Weight;
            e.RmaNumber = c.RmaNumber;
            e.ReversalNumber = c.ReversalNumber;
            e.IsDropShip = c.IsDropShip;
            e.DropShipBusinessPartnerId = c.DropShipBusinessPartnerId;
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;

            foreach (ICreateInOutLine innerCommand in c.InOutLines)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInOutLineStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddInOutLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IInOutStateMergePatched Map(IMergePatchInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateMergePatched e = NewInOutStateMergePatched(stateEventId);

            e.IsSOTransaction = c.IsSOTransaction;
            NewInOutDocumentActionCommandAndExecute(c, _state, e);
            e.Posted = c.Posted;
            e.Processing = c.Processing;
            e.Processed = c.Processed;
            e.DocumentType = c.DocumentType;
            e.Description = c.Description;
            e.OrderNumber = c.OrderNumber;
            e.DateOrdered = c.DateOrdered;
            e.IsPrinted = c.IsPrinted;
            e.MovementType = c.MovementType;
            e.MovementDate = c.MovementDate;
            e.BusinessPartnerId = c.BusinessPartnerId;
            e.WarehouseId = c.WarehouseId;
            e.POReference = c.POReference;
            e.FreightAmount = c.FreightAmount;
            e.ShipperId = c.ShipperId;
            e.ChargeAmount = c.ChargeAmount;
            e.DatePrinted = c.DatePrinted;
            e.SalesRepresentative = c.SalesRepresentative;
            e.NumberOfPackages = c.NumberOfPackages;
            e.PickDate = c.PickDate;
            e.ShipDate = c.ShipDate;
            e.TrackingNumber = c.TrackingNumber;
            e.DateReceived = c.DateReceived;
            e.IsInTransit = c.IsInTransit;
            e.IsApproved = c.IsApproved;
            e.IsInDispute = c.IsInDispute;
            e.Volume = c.Volume;
            e.Weight = c.Weight;
            e.RmaNumber = c.RmaNumber;
            e.ReversalNumber = c.ReversalNumber;
            e.IsDropShip = c.IsDropShip;
            e.DropShipBusinessPartnerId = c.DropShipBusinessPartnerId;
            e.Active = c.Active;
            e.IsPropertyIsSOTransactionRemoved = c.IsPropertyIsSOTransactionRemoved;
            e.IsPropertyPostedRemoved = c.IsPropertyPostedRemoved;
            e.IsPropertyProcessingRemoved = c.IsPropertyProcessingRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyDocumentTypeRemoved = c.IsPropertyDocumentTypeRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyOrderNumberRemoved = c.IsPropertyOrderNumberRemoved;
            e.IsPropertyDateOrderedRemoved = c.IsPropertyDateOrderedRemoved;
            e.IsPropertyIsPrintedRemoved = c.IsPropertyIsPrintedRemoved;
            e.IsPropertyMovementTypeRemoved = c.IsPropertyMovementTypeRemoved;
            e.IsPropertyMovementDateRemoved = c.IsPropertyMovementDateRemoved;
            e.IsPropertyBusinessPartnerIdRemoved = c.IsPropertyBusinessPartnerIdRemoved;
            e.IsPropertyWarehouseIdRemoved = c.IsPropertyWarehouseIdRemoved;
            e.IsPropertyPOReferenceRemoved = c.IsPropertyPOReferenceRemoved;
            e.IsPropertyFreightAmountRemoved = c.IsPropertyFreightAmountRemoved;
            e.IsPropertyShipperIdRemoved = c.IsPropertyShipperIdRemoved;
            e.IsPropertyChargeAmountRemoved = c.IsPropertyChargeAmountRemoved;
            e.IsPropertyDatePrintedRemoved = c.IsPropertyDatePrintedRemoved;
            e.IsPropertySalesRepresentativeRemoved = c.IsPropertySalesRepresentativeRemoved;
            e.IsPropertyNumberOfPackagesRemoved = c.IsPropertyNumberOfPackagesRemoved;
            e.IsPropertyPickDateRemoved = c.IsPropertyPickDateRemoved;
            e.IsPropertyShipDateRemoved = c.IsPropertyShipDateRemoved;
            e.IsPropertyTrackingNumberRemoved = c.IsPropertyTrackingNumberRemoved;
            e.IsPropertyDateReceivedRemoved = c.IsPropertyDateReceivedRemoved;
            e.IsPropertyIsInTransitRemoved = c.IsPropertyIsInTransitRemoved;
            e.IsPropertyIsApprovedRemoved = c.IsPropertyIsApprovedRemoved;
            e.IsPropertyIsInDisputeRemoved = c.IsPropertyIsInDisputeRemoved;
            e.IsPropertyVolumeRemoved = c.IsPropertyVolumeRemoved;
            e.IsPropertyWeightRemoved = c.IsPropertyWeightRemoved;
            e.IsPropertyRmaNumberRemoved = c.IsPropertyRmaNumberRemoved;
            e.IsPropertyReversalNumberRemoved = c.IsPropertyReversalNumberRemoved;
            e.IsPropertyIsDropShipRemoved = c.IsPropertyIsDropShipRemoved;
            e.IsPropertyDropShipBusinessPartnerIdRemoved = c.IsPropertyDropShipBusinessPartnerIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;

            foreach (IInOutLineCommand innerCommand in c.InOutLineCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInOutLineStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddInOutLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IInOutStateDeleted Map(IDeleteInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateDeleted e = NewInOutStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }


        protected void ThrowOnInconsistentCommands(IInOutCommand command, IInOutLineCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteInOut;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveInOutLine;
            if (properties == null || innerProperties == null) { return; }
            var outerDocumentNumberName = "DocumentNumber";
            var outerDocumentNumberValue = properties.DocumentNumber;
            var innerInOutDocumentNumberName = "InOutDocumentNumber";
            var innerInOutDocumentNumberValue = innerProperties.InOutDocumentNumber;
            SetNullInnerIdOrThrowOnInconsistentIds(innerProperties, innerInOutDocumentNumberName, innerInOutDocumentNumberValue, outerDocumentNumberName, outerDocumentNumberValue);

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IInOutLineStateEvent Map(IInOutLineCommand c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateInOutLine) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchInOutLine) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveInOutLine) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IInOutLineStateCreated MapCreate(ICreateInOutLine c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.SkuId, version);
            IInOutLineStateCreated e = NewInOutLineStateCreated(stateEventId);
            var s = outerState.InOutLines.Get(c.SkuId);

            e.LineNumber = c.LineNumber;
            e.Description = c.Description;
            e.LocatorId = c.LocatorId;
            e.Product = c.Product;
            e.UomId = c.UomId;
            e.MovementQuantity = c.MovementQuantity;
            e.ConfirmedQuantity = c.ConfirmedQuantity;
            e.ScrappedQuantity = c.ScrappedQuantity;
            e.TargetQuantity = c.TargetQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.IsDescription = c.IsDescription;
            e.Processed = c.Processed;
            e.QuantityEntered = c.QuantityEntered;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IInOutLineStateMergePatched MapMergePatch(IMergePatchInOutLine c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.SkuId, version);
            IInOutLineStateMergePatched e = NewInOutLineStateMergePatched(stateEventId);
            var s = outerState.InOutLines.Get(c.SkuId);

            e.LineNumber = c.LineNumber;
            e.Description = c.Description;
            e.LocatorId = c.LocatorId;
            e.Product = c.Product;
            e.UomId = c.UomId;
            e.MovementQuantity = c.MovementQuantity;
            e.ConfirmedQuantity = c.ConfirmedQuantity;
            e.ScrappedQuantity = c.ScrappedQuantity;
            e.TargetQuantity = c.TargetQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.IsDescription = c.IsDescription;
            e.Processed = c.Processed;
            e.QuantityEntered = c.QuantityEntered;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Active = c.Active;
            e.IsPropertyLineNumberRemoved = c.IsPropertyLineNumberRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyProductRemoved = c.IsPropertyProductRemoved;
            e.IsPropertyUomIdRemoved = c.IsPropertyUomIdRemoved;
            e.IsPropertyMovementQuantityRemoved = c.IsPropertyMovementQuantityRemoved;
            e.IsPropertyConfirmedQuantityRemoved = c.IsPropertyConfirmedQuantityRemoved;
            e.IsPropertyScrappedQuantityRemoved = c.IsPropertyScrappedQuantityRemoved;
            e.IsPropertyTargetQuantityRemoved = c.IsPropertyTargetQuantityRemoved;
            e.IsPropertyPickedQuantityRemoved = c.IsPropertyPickedQuantityRemoved;
            e.IsPropertyIsInvoicedRemoved = c.IsPropertyIsInvoicedRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyIsDescriptionRemoved = c.IsPropertyIsDescriptionRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyQuantityEnteredRemoved = c.IsPropertyQuantityEnteredRemoved;
            e.IsPropertyRmaLineNumberRemoved = c.IsPropertyRmaLineNumberRemoved;
            e.IsPropertyReversalLineNumberRemoved = c.IsPropertyReversalLineNumberRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IInOutLineStateRemoved MapRemove(IRemoveInOutLine c, IInOutCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.SkuId, version);
            IInOutLineStateRemoved e = NewInOutLineStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////

        protected void NewInOutDocumentActionCommandAndExecute(IMergePatchInOut c, IInOutState s, IInOutStateMergePatched e)
        {
            var pCommandHandler = this.InOutDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<DocumentAction, string> { Content = pCmdContent, GetState = () => s.DocumentStatus, SetState = p => e.DocumentStatus = p, OuterCommandType = CommandType.MergePatch };
            pCommandHandler.Execute(pCmd);
        }

        protected void NewInOutDocumentActionCommandAndExecute(ICreateInOut c, IInOutState s, IInOutStateCreated e)
        {
            var pCommandHandler = this.InOutDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<DocumentAction, string> { Content = pCmdContent, GetState = () => s.DocumentStatus, SetState = p => e.DocumentStatus = p, OuterCommandType = CommandType.Create };
            pCommandHandler.Execute(pCmd);
        }

        protected IPropertyCommandHandler<DocumentAction, string> InOutDocumentActionCommandHandler
        {
            get
            {
                return ApplicationContext.Current["InOutDocumentActionCommandHandler"] as IPropertyCommandHandler<DocumentAction, string>;
            }
        }

        private void SetNullInnerIdOrThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (innerIdValue == null)
            {
                ReflectUtils.SetPropertyValue(innerIdName, innerObject, outerIdValue);
            }
            else if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected InOutStateCreated NewInOutStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected InOutStateMergePatched NewInOutStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected InOutStateDeleted NewInOutStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private InOutStateCreated NewInOutStateCreated(InOutStateEventId stateEventId)
		{
			return new InOutStateCreated(stateEventId);			
		}

        private InOutStateMergePatched NewInOutStateMergePatched(InOutStateEventId stateEventId)
		{
			return new InOutStateMergePatched(stateEventId);
		}

        private InOutStateDeleted NewInOutStateDeleted(InOutStateEventId stateEventId)
		{
			return new InOutStateDeleted(stateEventId);
		}


		private InOutLineStateCreated NewInOutLineStateCreated(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateCreated(stateEventId);
		}

        private InOutLineStateMergePatched NewInOutLineStateMergePatched(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateMergePatched(stateEventId);
		}

        private InOutLineStateRemoved NewInOutLineStateRemoved(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateRemoved(stateEventId);
		}


    }

}

