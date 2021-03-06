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
    public partial class AccountFeatureController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AccountFeatureController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AccountFeatureController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AccountFeatureController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Deletes an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic DeleteAdminApiFeaturesXmlById(string accessToken, int id)
        {
            Task<dynamic> t = DeleteAdminApiFeaturesXmlByIdAsync(accessToken, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DeleteAdminApiFeaturesXmlByIdAsync(string accessToken, int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/features/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
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
        /// Returns an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiFeaturesXmlById(string accessToken, int id)
        {
            Task<dynamic> t = GetAdminApiFeaturesXmlByIdAsync(accessToken, id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiFeaturesXmlByIdAsync(string accessToken, int id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/features/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
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
        /// Returns the list of the features available to accounts. Account features are globally scoped.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAdminApiFeaturesXml(string accessToken)
        {
            Task<dynamic> t = GetAdminApiFeaturesXmlAsync(accessToken);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the list of the features available to accounts. Account features are globally scoped.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAdminApiFeaturesXmlAsync(string accessToken)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/features.xml");

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
        /// Create an account feature. The features of the account are globally scoped. Creating a feature does not associate the feature with an account plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <param name="systemName">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateAdminApiFeaturesXml(string accessToken, string name, string systemName = null)
        {
            Task<dynamic> t = CreateAdminApiFeaturesXmlAsync(accessToken, name, systemName);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an account feature. The features of the account are globally scoped. Creating a feature does not associate the feature with an account plan.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <param name="systemName">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateAdminApiFeaturesXmlAsync(string accessToken, string name, string systemName = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/features.xml");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "access_token", accessToken },
                { "name", name },
                { "system_name", systemName }
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
        /// Updates an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateAdminApiFeaturesXmlById(string accessToken, int id, string name)
        {
            Task<dynamic> t = UpdateAdminApiFeaturesXmlByIdAsync(accessToken, id, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates an account feature.
        /// </summary>
        /// <param name="accessToken">Required parameter: Example: </param>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="name">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateAdminApiFeaturesXmlByIdAsync(string accessToken, int id, string name)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/admin/api/features/{id}.xml");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
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

    }
} 