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

    public partial class UserApplicationServiceProxy : IUserApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public UserApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public UserApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UserApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateUserDto c)
        {
            var idObj = (c as ICreateUser).UserId;
            var uriParameters = new UserUriParameters();
            uriParameters.Id = idObj;

            var req = new UserPutRequest(uriParameters, (CreateUserDto)c);
                
            var resp = await _ramlClient.User.Put(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateUserDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchUserDto c)
        {
            var idObj = (c as IMergePatchUser).UserId;
            var uriParameters = new UserUriParameters();
            uriParameters.Id = idObj;

            var req = new UserPatchRequest(uriParameters, (MergePatchUserDto)c);
            var resp = await _ramlClient.User.Patch(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUserDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteUserDto c)
        {
            var idObj = (c as IDeleteUser).UserId;
            var uriParameters = new UserUriParameters();
            uriParameters.Id = idObj;

            var q = new UserDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new UserDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.User.Delete(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUserDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IUserApplicationService.When(ICreateUser c)
        {
            this.When((CreateUserDto)c);
        }

        void IUserApplicationService.When(IMergePatchUser c)
        {
            this.When((MergePatchUserDto)c);
        }

        void IUserApplicationService.When(IDeleteUser c)
        {
            this.When((DeleteUserDto)c);
        }

        public async Task<IUserState> GetAsync(string userId)
        {
            IUserState state = null;
            var idObj = userId;
            var uriParameters = new UserUriParameters();
            uriParameters.Id = idObj;

            var req = new UserGetRequest(uriParameters);

            var resp = await _ramlClient.User.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IUserState Get(string userId)
        {
            return GetAsync(userId).GetAwaiter().GetResult();
        }


        public IEnumerable<IUserState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUserState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserState> states = null;
			var q = new UsersGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UserProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UsersGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Users.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IUserState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUserState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserState> states = null;
			var q = new UsersGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UserProxyUtils.GetFilterQueryValueString(filter);
            var req = new UsersGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Users.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UsersCountGetQuery();
            q.FilterTag = UserProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UsersCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UsersCount.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new UsersCountGetQuery();
            q.Filter = UserProxyUtils.GetFilterQueryValueString(filter);
            var req = new UsersCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UsersCount.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IUserStateEvent> GetStateEventAsync(string userId, long version)
        {
            var idObj = userId;
            var uriParameters = new UserStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.UserStateEvent.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IUserStateEvent GetStateEvent(string userId, long version)
        {
            return GetStateEventAsync(userId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IUserRoleState> GetUserRoleAsync(string userId, string roleId)
        {
            var uriParameters = new UserRoleUriParameters();
            uriParameters.UserId = userId;
            uriParameters.RoleId = roleId;

            var req = new UserRoleGetRequest(uriParameters);
            var resp = await _ramlClient.UserRole.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserRoleState GetUserRole(string userId, string roleId)
        {
            return GetUserRoleAsync(userId, roleId).GetAwaiter().GetResult();
        }

        public async virtual Task<IUserClaimState> GetUserClaimAsync(string userId, int claimId)
        {
            var uriParameters = new UserClaimUriParameters();
            uriParameters.UserId = userId;
            uriParameters.ClaimId = claimId;

            var req = new UserClaimGetRequest(uriParameters);
            var resp = await _ramlClient.UserClaim.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserClaimState GetUserClaim(string userId, int claimId)
        {
            return GetUserClaimAsync(userId, claimId).GetAwaiter().GetResult();
        }

        public async virtual Task<IUserPermissionState> GetUserPermissionAsync(string userId, string permissionId)
        {
            var uriParameters = new UserPermissionUriParameters();
            uriParameters.UserId = userId;
            uriParameters.PermissionId = permissionId;

            var req = new UserPermissionGetRequest(uriParameters);
            var resp = await _ramlClient.UserPermission.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserPermissionState GetUserPermission(string userId, string permissionId)
        {
            return GetUserPermissionAsync(userId, permissionId).GetAwaiter().GetResult();
        }

        public async virtual Task<IUserLoginState> GetUserLoginAsync(string userId, LoginKey loginKey)
        {
            var uriParameters = new UserLoginUriParameters();
            uriParameters.UserId = userId;
            uriParameters.LoginKey = (new LoginKeyFlattenedDtoFormatter()).ToString(new LoginKeyFlattenedDto(loginKey));

            var req = new UserLoginGetRequest(uriParameters);
            var resp = await _ramlClient.UserLogin.Get(req);
            UserProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IUserLoginState GetUserLogin(string userId, LoginKey loginKey)
        {
            return GetUserLoginAsync(userId, loginKey).GetAwaiter().GetResult();
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


    public partial class UserApplicationServiceProxyFactory : ProxyFactoryBase, IUserApplicationServiceFactory
    {

        public UserApplicationServiceProxyFactory() : base()
        {}

        public UserApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IUserApplicationService UserApplicationService
        {
            get
            {
                return new UserApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateUser NewCreateUser()
        {
            return new CreateUserDto();
        }

        public IMergePatchUser NewMergePatchUser()
        {
            return new MergePatchUserDto();
        }

        public IDeleteUser NewDeleteUser()
        {
            return new DeleteUserDto();
        }
    }

    public static class UserProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IUserState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.UserId);
            }
            return ids;
        }

    }

}

