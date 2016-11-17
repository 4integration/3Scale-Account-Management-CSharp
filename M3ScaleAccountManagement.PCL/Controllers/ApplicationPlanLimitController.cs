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
    public partial class ApplicationPlanLimitController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ApplicationPlanLimitController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ApplicationPlanLimitController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ApplicationPlanLimitController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Deletes a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic DeleteAdminApiApplicationPlansMetricsLimitsIdXml(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id)
        {
            Task<dynamic> t = DeleteAdminApiApplicationPlansMetricsLimitsIdXmlAsync(accessToken, applicationPlanId, metricId, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DeleteAdminApiApplicationPlansMetricsLimitsIdXmlAsync(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/application_plans/{application_plan_id}/metrics/{metric_id}/limits/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "application_plan_id", applicationPlanId },
                { "metric_id", metricId },
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
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

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
        /// Updates a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="period">Required parameter: Example: minute</param>
        /// <param name="mvalue">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateAdminApiApplicationPlansMetricsLimitsIdXml(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id,
                PeriodEnum period,
                int? mvalue = null)
        {
            Task<dynamic> t = UpdateAdminApiApplicationPlansMetricsLimitsIdXmlAsync(accessToken, applicationPlanId, metricId, id, period, mvalue);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="period">Required parameter: Example: minute</param>
        /// <param name="mvalue">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateAdminApiApplicationPlansMetricsLimitsIdXmlAsync(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id,
                PeriodEnum period,
                int? mvalue = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/application_plans/{application_plan_id}/metrics/{metric_id}/limits/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "application_plan_id", applicationPlanId },
                { "metric_id", metricId },
                { "id", id }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken },
                { "period", PeriodEnumHelper.ToValue(period) },
                { "value", mvalue }
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
        /// Returns a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiApplicationPlansMetricsLimitsIdXml(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id)
        {
            Task<dynamic> t = GetAdminApiApplicationPlansMetricsLimitsIdXmlAsync(accessToken, applicationPlanId, metricId, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a limit on a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiApplicationPlansMetricsLimitsIdXmlAsync(
                string accessToken,
                int applicationPlanId,
                int metricId,
                int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/application_plans/{application_plan_id}/metrics/{metric_id}/limits/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "application_plan_id", applicationPlanId },
                { "metric_id", metricId },
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
        /// Adds a limit to a metric of an application plan. All applications with the application plan (application_plan_id) will be constrained by this new limit on the metric (metric_id).
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="period">Required parameter: Example: minute</param>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateAdminApiApplicationPlansMetricsLimitsXml(
                string accessToken,
                int applicationPlanId,
                int metricId,
                PeriodEnum period,
                int mvalue)
        {
            Task<dynamic> t = CreateAdminApiApplicationPlansMetricsLimitsXmlAsync(accessToken, applicationPlanId, metricId, period, mvalue);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Adds a limit to a metric of an application plan. All applications with the application plan (application_plan_id) will be constrained by this new limit on the metric (metric_id).
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <param name="period">Required parameter: Example: minute</param>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateAdminApiApplicationPlansMetricsLimitsXmlAsync(
                string accessToken,
                int applicationPlanId,
                int metricId,
                PeriodEnum period,
                int mvalue)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/application_plans/{application_plan_id}/metrics/{metric_id}/limits.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "application_plan_id", applicationPlanId },
                { "metric_id", metricId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken },
                { "period", PeriodEnumHelper.ToValue(period) },
                { "value", mvalue }
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
        /// Returns the list of all limits associated to a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetLimits(string accessToken, int applicationPlanId, int metricId)
        {
            Task<dynamic> t = GetLimitsAsync(accessToken, applicationPlanId, metricId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the list of all limits associated to a metric of an application plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="applicationPlanId">Required parameter: Example: </param>
        /// <param name="metricId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetLimitsAsync(string accessToken, int applicationPlanId, int metricId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/application_plans/{application_plan_id}/metrics/{metric_id}/limits.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "application_plan_id", applicationPlanId },
                { "metric_id", metricId }
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

    }
} 