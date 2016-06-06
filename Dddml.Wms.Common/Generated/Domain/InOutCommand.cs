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

	public abstract class InOutCommandBase : IInOutCommand
	{
		public virtual string DocumentNumber { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.DocumentNumber;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual bool? IsSOTransaction { get; set; }

		public virtual DocumentAction DocumentAction { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processing { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual int? DocumentType { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderNumber { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool? IsPrinted { get; set; }

		public virtual string MovementType { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual decimal? FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual decimal? ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string SalesRepresentative { get; set; }

		public virtual int? NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual bool? IsInDispute { get; set; }

		public virtual decimal? Volume { get; set; }

		public virtual decimal? Weight { get; set; }

		public virtual string RmaNumber { get; set; }

		public virtual string ReversalNumber { get; set; }

		public virtual bool? IsDropShip { get; set; }

		public virtual string DropShipBusinessPartnerId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class InOutIdGeneratorBase : IIdGenerator<string, ICreateInOut>
    {
        public abstract string GenerateId(ICreateInOut command);

        public abstract string GetNextId();

        public virtual string GetOrGenerateId(ICreateInOut command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateInOut : InOutCommandBase, ICreateInOut
	{
		
		public CreateInOut ()
		{
		}


        private CreateInOutLineCommands _inOutLines = new CreateInOutLineCommands();

        public ICreateInOutLineCommands InOutLines
        {
            get
            {
                return this._inOutLines;
            }
        }

        public CreateInOutLine NewCreateInOutLine()
        {
            var c = new CreateInOutLine();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        ICreateInOutLine ICreateInOut.NewCreateInOutLine()
        {
            return this.NewCreateInOutLine();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInOut :InOutCommandBase, IMergePatchInOut
	{

		public virtual bool IsPropertyIsSOTransactionRemoved { get; set; }

		public virtual bool IsPropertyPostedRemoved { get; set; }

		public virtual bool IsPropertyProcessingRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyDocumentTypeRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyOrderNumberRemoved { get; set; }

		public virtual bool IsPropertyDateOrderedRemoved { get; set; }

		public virtual bool IsPropertyIsPrintedRemoved { get; set; }

		public virtual bool IsPropertyMovementTypeRemoved { get; set; }

		public virtual bool IsPropertyMovementDateRemoved { get; set; }

		public virtual bool IsPropertyBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyPOReferenceRemoved { get; set; }

		public virtual bool IsPropertyFreightAmountRemoved { get; set; }

		public virtual bool IsPropertyShipperIdRemoved { get; set; }

		public virtual bool IsPropertyChargeAmountRemoved { get; set; }

		public virtual bool IsPropertyDatePrintedRemoved { get; set; }

		public virtual bool IsPropertySalesRepresentativeRemoved { get; set; }

		public virtual bool IsPropertyNumberOfPackagesRemoved { get; set; }

		public virtual bool IsPropertyPickDateRemoved { get; set; }

		public virtual bool IsPropertyShipDateRemoved { get; set; }

		public virtual bool IsPropertyTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyDateReceivedRemoved { get; set; }

		public virtual bool IsPropertyIsInTransitRemoved { get; set; }

		public virtual bool IsPropertyIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyIsInDisputeRemoved { get; set; }

		public virtual bool IsPropertyVolumeRemoved { get; set; }

		public virtual bool IsPropertyWeightRemoved { get; set; }

		public virtual bool IsPropertyRmaNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalNumberRemoved { get; set; }

		public virtual bool IsPropertyIsDropShipRemoved { get; set; }

		public virtual bool IsPropertyDropShipBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchInOut ()
		{
		}

        private InOutLineCommands _inOutLineCommands = new InOutLineCommands();

        public IInOutLineCommands InOutLineCommands
        {
            get
            {
                return this._inOutLineCommands;
            }
        }


        public CreateInOutLine NewCreateInOutLine()
        {
            var c = new CreateInOutLine();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        ICreateInOutLine IMergePatchInOut.NewCreateInOutLine()
        {
            return this.NewCreateInOutLine();
        }

        public MergePatchInOutLine NewMergePatchInOutLine()
        {
            var c = new MergePatchInOutLine();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        IMergePatchInOutLine IMergePatchInOut.NewMergePatchInOutLine()
        {
            return this.NewMergePatchInOutLine();
        }


        public RemoveInOutLine NewRemoveInOutLine()
        {
            var c = new RemoveInOutLine();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        IRemoveInOutLine IMergePatchInOut.NewRemoveInOutLine()
        {
            return this.NewRemoveInOutLine();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInOut : InOutCommandBase, IDeleteInOut
	{
		public DeleteInOut ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreateInOutLineCommands : ICreateInOutLineCommands
    {
        private List<ICreateInOutLine> _innerCommands = new List<ICreateInOutLine>();

        public void Add(ICreateInOutLine c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateInOutLine c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateInOutLine> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class InOutLineCommands : IInOutLineCommands
    {
        private List<IInOutLineCommand> _innerCommands = new List<IInOutLineCommand>();

        public void Add(IInOutLineCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IInOutLineCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IInOutLineCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }




}

