﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;
using Dddml.Wms.Specialization.HttpServices.ClientProxies;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class RolePermissionApplicationServiceProxy : IRolePermissionApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public RolePermissionApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public RolePermissionApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public RolePermissionApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateRolePermissionDto c)
        {
            var idObj = RolePermissionProxyUtils.ToIdString((c as ICreateRolePermission).Id);
            var uriParameters = new RolePermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new RolePermissionPutRequest(uriParameters, (CreateRolePermissionDto)c);
                
            var resp = await _ramlClient.RolePermission.Put(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateRolePermissionDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchRolePermissionDto c)
        {
            var idObj = RolePermissionProxyUtils.ToIdString((c as IMergePatchRolePermission).Id);
            var uriParameters = new RolePermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new RolePermissionPatchRequest(uriParameters, (MergePatchRolePermissionDto)c);
            var resp = await _ramlClient.RolePermission.Patch(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchRolePermissionDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteRolePermissionDto c)
        {
            var idObj = RolePermissionProxyUtils.ToIdString((c as IDeleteRolePermission).Id);
            var uriParameters = new RolePermissionUriParameters();
            uriParameters.Id = idObj;

            var q = new RolePermissionDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new RolePermissionDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.RolePermission.Delete(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteRolePermissionDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IRolePermissionApplicationService.When(ICreateRolePermission c)
        {
            this.When((CreateRolePermissionDto)c);
        }

        void IRolePermissionApplicationService.When(IMergePatchRolePermission c)
        {
            this.When((MergePatchRolePermissionDto)c);
        }

        void IRolePermissionApplicationService.When(IDeleteRolePermission c)
        {
            this.When((DeleteRolePermissionDto)c);
        }

        public async Task<IRolePermissionState> GetAsync(RolePermissionId id)
        {
            IRolePermissionState state = null;
            var idObj = RolePermissionProxyUtils.ToIdString(id);
            var uriParameters = new RolePermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new RolePermissionGetRequest(uriParameters);

            var resp = await _ramlClient.RolePermission.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IRolePermissionState Get(RolePermissionId id)
        {
            return GetAsync(id).GetAwaiter().GetResult();
        }


        public IEnumerable<IRolePermissionState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IRolePermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IRolePermissionState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IRolePermissionState> states = null;
			var q = new RolePermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = RolePermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = RolePermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = RolePermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new RolePermissionsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.RolePermissions.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IRolePermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IRolePermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IRolePermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IRolePermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IRolePermissionState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IRolePermissionState> states = null;
			var q = new RolePermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = RolePermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = RolePermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = RolePermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new RolePermissionsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.RolePermissions.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IRolePermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new RolePermissionsCountGetQuery();
            q.FilterTag = RolePermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new RolePermissionsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.RolePermissionsCount.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new RolePermissionsCountGetQuery();
            q.Filter = RolePermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new RolePermissionsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.RolePermissionsCount.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IRolePermissionStateEvent> GetStateEventAsync(RolePermissionId id, long version)
        {
            var idObj = RolePermissionProxyUtils.ToIdString(id);
            var uriParameters = new RolePermissionStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new RolePermissionStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.RolePermissionStateEvent.Get(req);
            RolePermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IRolePermissionStateEvent GetStateEvent(RolePermissionId id, long version)
        {
            return GetStateEventAsync(id, version).GetAwaiter().GetResult();
        }


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

    }


    public partial class RolePermissionApplicationServiceProxyFactory : ProxyFactoryBase, IRolePermissionApplicationServiceFactory
    {

        public RolePermissionApplicationServiceProxyFactory() : base()
        {}

        public RolePermissionApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IRolePermissionApplicationService RolePermissionApplicationService
        {
            get
            {
                return new RolePermissionApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateRolePermission NewCreateRolePermission()
        {
            return new CreateRolePermissionDto();
        }

        public IMergePatchRolePermission NewMergePatchRolePermission()
        {
            return new MergePatchRolePermissionDto();
        }

        public IDeleteRolePermission NewDeleteRolePermission()
        {
            return new DeleteRolePermissionDto();
        }
    }

    public static class RolePermissionProxyUtils
    {

        private class ProxyTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                throw new NotSupportedException();
            }

            public object ConvertFromString(Type type, string text)
            {
                throw new NotSupportedException();
            }

            public string ConvertToString<T>(T value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(typeof(T), value);
            }

            public string ConvertToString(object value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(value.GetType(), value);
            }

            public string[] ConvertToStringArray(object[] values)
            {
                var list = new List<string>();
                foreach (var o in values)
                {
                    list.Add(ConvertToString(o));
                }
                return list.ToArray();
            }
        }

        public static string ToIdString(RolePermissionId id)
        {
            var formatter = new RolePermissionIdFlattenedDtoFormatter();
            var idDto = new RolePermissionIdFlattenedDto(id);
            var idStr = formatter.ToString(idDto);
            return idStr;
        }


        public static string GetFilterQueryValueString(ICriterion filter)
        {
            if (filter == null) { return null; }
            return WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
        }

        public static string GetFilterTagQueryValueString(IEnumerable<KeyValuePair<string, object>> filter)
        {
            if (filter == null) { return null; }
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Ticks);
            foreach (var p in filter)
            {
                var k = p.Key;
                var v = p.Value;
                sb.Append("&");
                sb.Append(k);
                sb.Append("=");
                if (v != null)
                {
                    string valStr = ApplicationContext.Current.TypeConverter.ConvertToString(v.GetType(), v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        public static string GetReturnedFieldsQueryValueString(IList<string> fields, string separator)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(separator);
            }
            return sb.ToString();
        }

        public static string GetOrdersQueryValueString(IList<string> orders)
        {
            if (orders == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var ord in orders)
            {
                sb.Append(WebUtility.UrlEncode(ord));
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static void ThrowOnHttpResponseError(ApiResponse resp)
        {
            var httpResponseMessage = new HttpResponseMessage()
            {
                StatusCode = resp.StatusCode,
                Content = resp.RawContent,
                ReasonPhrase = resp.ReasonPhrase
            };
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            try
            {
                if (resp.StatusCode == HttpStatusCode.InternalServerError)
                {
                    IEnumerable<string> headerValues = new List<string>();
                    if (resp.RawContent != null && resp.RawContent.Headers != null)
                        resp.RawContent.Headers.TryGetValues("Content-Type", out headerValues);
                    if (headerValues.Any(hv => hv.ToLowerInvariant().Contains("json")))
                    {
                        JObject jObj = JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        var errorName = jObj.GetValue("ErrorName").ToObject<string>();
                        var errorMessage = jObj.GetValue("ErrorMessage").ToObject<string>();
                        throw DomainError.Named(errorName, errorMessage);
                    }
                }
                throw new HttpResponseException(httpResponseMessage);
            }
            catch
            {
                throw new HttpResponseException(httpResponseMessage);
            }
        }

        public static IEnumerable<RolePermissionId> ToIdCollection(IEnumerable<IRolePermissionState> states)
        {
            var ids = new List<RolePermissionId>();
            foreach (var s in states)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

    }

}

