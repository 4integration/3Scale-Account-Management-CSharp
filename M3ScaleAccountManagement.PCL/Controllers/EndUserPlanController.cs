/*
 * M3ScaleAccountManagement.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 11/17/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3ScaleAccountManagement.PCL;
using M3ScaleAccountManagement.PCL.Http.Request;
using M3ScaleAccountManagement.PCL.Http.Response;
using M3ScaleAccountManagement.PCL.Http.Client;
using M3ScaleAccountManagement.PCL.Exceptions;
using M3ScaleAccountManagement.PCL.Models;

namespace M3ScaleAccountManagement.PCL.Controllers
{
    public partial class EndUserPlanController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EndUserPlanController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EndUserPlanController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EndUserPlanController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Makes the end user plan the default one. New end users will be assigned to the default plan unless an end_user_plan_id is explicity passed on end user creation.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateAdminApiServicesEndUserPlansDefaultXml(string accessToken, int serviceId, int id)
        {
            Task<dynamic> t = UpdateAdminApiServicesEndUserPlansDefaultXmlAsync(accessToken, serviceId, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Makes the end user plan the default one. New end users will be assigned to the default plan unless an end_user_plan_id is explicity passed on end user creation.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateAdminApiServicesEndUserPlansDefaultXmlAsync(string accessToken, int serviceId, int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/services/{service_id}/end_user_plans/{id}/default.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "service_id", serviceId },
                { "id", id }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Put(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateAdminApiServicesEndUserPlansXml(
                string accessToken,
                int serviceId,
                int id,
                string name)
        {
            Task<dynamic> t = UpdateAdminApiServicesEndUserPlansXmlAsync(accessToken, serviceId, id, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateAdminApiServicesEndUserPlansXmlAsync(
                string accessToken,
                int serviceId,
                int id,
                string name)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/services/{service_id}/end_user_plans/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "service_id", serviceId },
                { "id", id }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken },
                { "name", name }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Put(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Returns an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiServicesEndUserPlansXml(string accessToken, int serviceId, int id)
        {
            Task<dynamic> t = GetAdminApiServicesEndUserPlansXmlAsync(accessToken, serviceId, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiServicesEndUserPlansXmlAsync(string accessToken, int serviceId, int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/services/{service_id}/end_user_plans/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "service_id", serviceId },
                { "id", id }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Creates an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateAdminApiServicesEndUserPlansXml(string accessToken, int serviceId, string name)
        {
            Task<dynamic> t = CreateAdminApiServicesEndUserPlansXmlAsync(accessToken, serviceId, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates an end user plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateAdminApiServicesEndUserPlansXmlAsync(string accessToken, int serviceId, string name)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/services/{service_id}/end_user_plans.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "service_id", serviceId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken },
                { "name", name }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Returns the list of all end user plans of a service.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiServicesEndUserPlansXml(string accessToken, int serviceId)
        {
            Task<dynamic> t = GetAdminApiServicesEndUserPlansXmlAsync(accessToken, serviceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the list of all end user plans of a service.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="serviceId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiServicesEndUserPlansXmlAsync(string accessToken, int serviceId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/services/{service_id}/end_user_plans.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "service_id", serviceId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Returns the list of all end user plans across services. Note that end user plans are scoped by service.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiEndUserPlansXml(string accessToken)
        {
            Task<dynamic> t = GetAdminApiEndUserPlansXmlAsync(accessToken);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the list of all end user plans across services. Note that end user plans are scoped by service.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiEndUserPlansXmlAsync(string accessToken)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/end_user_plans.xml");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 