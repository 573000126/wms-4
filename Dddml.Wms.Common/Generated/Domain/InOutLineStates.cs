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

    public class InOutLineStates : IInOutLineStates
    {
        
		protected IInOutLineStateDao InOutLineStateDao
		{
			get
			{
				return ApplicationContext.Current["InOutLineStateDao"] as IInOutLineStateDao;
			}
		}

		private Dictionary<InOutLineId, IInOutLineState> _loadedInOutLineStates = new Dictionary<InOutLineId, IInOutLineState>();

        private List<IInOutLineState> _removedInOutLineStates = new List<IInOutLineState>();

		protected virtual IEnumerable<IInOutLineState> LoadedInOutLineStates {
			get {
				return this._loadedInOutLineStates.Values;
			}
		}

        private IInOutState _inOutState;

        private IEnumerable<IInOutLineState> _innerEnumerable;

        private IEnumerable<IInOutLineState> InnerEnumeralbe
        {
            get
            {
                if (_innerEnumerable == null)
                {
                    _innerEnumerable = InOutLineStateDao.FindByInOutDocumentNumber(_inOutState.DocumentNumber);
                }
                return _innerEnumerable;
            }
        }

        public InOutLineStates(IInOutState outerState)
        {
            this._inOutState = outerState;
        }

        public IEnumerator<IInOutLineState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IInOutLineState state)
        {
            this._removedInOutLineStates.Add(state);
        }

        public virtual IInOutLineState Get(SkuId skuId)
		{
			InOutLineId globalId = new InOutLineId(_inOutState.DocumentNumber, skuId);
            if (_loadedInOutLineStates.ContainsKey(globalId)) {
                return _loadedInOutLineStates[globalId];
            }
            var state = InOutLineStateDao.Get(globalId);
			_loadedInOutLineStates.Add (globalId, state);
			return state;
		}

        public virtual void AddToSave(IInOutLineState state)
        {
            this._loadedInOutLineStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IInOutLineState s in this.LoadedInOutLineStates) {
                InOutLineStateDao.Save(s);
			}
            foreach(IInOutLineState s in this._removedInOutLineStates)
            {
                InOutLineStateDao.Delete(s);
            }
		}

		#endregion


    }



}


