﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateNHibernateTrees.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

    public partial class NHibernateOrganizationTreeRepository : IOrganizationTreeRepository
    {

        private IOrganizationStateRepository _organizationStateRepository;

        public IOrganizationStateRepository OrganizationStateRepository
        {
            get { return this._organizationStateRepository; }
            set { this._organizationStateRepository = value; }
        }

        private IOrganizationStructureStateRepository _organizationStructureStateRepository;

        public IOrganizationStructureStateRepository OrganizationStructureStateRepository
        {
            get { return this._organizationStructureStateRepository; }
            set { this._organizationStructureStateRepository = value; }
        }



        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTree> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToOrganizationTreeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTree> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToOrganizationTreeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }



        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTree> GetRoots(Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToOrganizationTreeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTree> GetChildren(string parentId, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToOrganizationTreeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetRootIds(Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetChildIds(string parentId, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }


        private IEnumerable<IOrganizationTree> ToOrganizationTreeCollection(IEnumerable<IOrganizationState> states)
        {
            var trees = new List<OrganizationTree>();
            foreach (var state in states)
            {
                trees.Add(new OrganizationTree(state, this));
            }
            return trees;
        }

        private IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationState> states)
        {
            var ids = new List<string>();
            foreach (var state in states)
            {
                ids.Add(state.OrganizationId);
            }
            return ids;
        }

        private IEnumerable<IOrganizationTree> ToOrganizationTreeCollection(IEnumerable<IOrganizationStructureState> structureStates)
        {
            var trees = new List<OrganizationTree>();
            foreach (var ss in structureStates)
            {
                var state = OrganizationStateRepository.Get(ss.Id.SubsidiaryId);
                trees.Add(new OrganizationTree(state, this));
            }
            return trees;
        }

        private IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationStructureState> structureStates)
        {
            var ids = new List<string>();
            foreach (var ss in structureStates)
            {
                ids.Add(ss.Id.SubsidiaryId);
            }
            return ids;
        }


    }

}
