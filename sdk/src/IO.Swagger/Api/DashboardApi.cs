/* 
 * Cohesity REST API
 *
 * This API provides operations for interfacing with the Cohesity Cluster. NOTE: To view the documentation on the responses, click 'Model' next to 'Example Value' and keep clicking to expand the hierarchy.
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDashboardApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters.
        /// </summary>
        /// <remarks>
        /// If no parameters are specified, dashboard for the local cluster is returned.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>DashboardResponse</returns>
        DashboardResponse GetDashboard (long? clusterId = null, bool? allClusters = null);

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters.
        /// </summary>
        /// <remarks>
        /// If no parameters are specified, dashboard for the local cluster is returned.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>ApiResponse of DashboardResponse</returns>
        ApiResponse<DashboardResponse> GetDashboardWithHttpInfo (long? clusterId = null, bool? allClusters = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters.
        /// </summary>
        /// <remarks>
        /// If no parameters are specified, dashboard for the local cluster is returned.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>Task of DashboardResponse</returns>
        System.Threading.Tasks.Task<DashboardResponse> GetDashboardAsync (long? clusterId = null, bool? allClusters = null);

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters.
        /// </summary>
        /// <remarks>
        /// If no parameters are specified, dashboard for the local cluster is returned.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>Task of ApiResponse (DashboardResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DashboardResponse>> GetDashboardAsyncWithHttpInfo (long? clusterId = null, bool? allClusters = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DashboardApi : IDashboardApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DashboardApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DashboardApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters. If no parameters are specified, dashboard for the local cluster is returned.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>DashboardResponse</returns>
        public DashboardResponse GetDashboard (long? clusterId = null, bool? allClusters = null)
        {
             ApiResponse<DashboardResponse> localVarResponse = GetDashboardWithHttpInfo(clusterId, allClusters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters. If no parameters are specified, dashboard for the local cluster is returned.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>ApiResponse of DashboardResponse</returns>
        public ApiResponse< DashboardResponse > GetDashboardWithHttpInfo (long? clusterId = null, bool? allClusters = null)
        {

            var localVarPath = "/public/dashboard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clusterId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clusterId", clusterId)); // query parameter
            if (allClusters != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "allClusters", allClusters)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDashboard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DashboardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DashboardResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DashboardResponse)));
        }

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters. If no parameters are specified, dashboard for the local cluster is returned.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>Task of DashboardResponse</returns>
        public async System.Threading.Tasks.Task<DashboardResponse> GetDashboardAsync (long? clusterId = null, bool? allClusters = null)
        {
             ApiResponse<DashboardResponse> localVarResponse = await GetDashboardAsyncWithHttpInfo(clusterId, allClusters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the dashboard that match the filter criteria specified using parameters. If no parameters are specified, dashboard for the local cluster is returned.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clusterId">Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional)</param>
        /// <param name="allClusters">Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional)</param>
        /// <returns>Task of ApiResponse (DashboardResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DashboardResponse>> GetDashboardAsyncWithHttpInfo (long? clusterId = null, bool? allClusters = null)
        {

            var localVarPath = "/public/dashboard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clusterId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clusterId", clusterId)); // query parameter
            if (allClusters != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "allClusters", allClusters)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDashboard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DashboardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DashboardResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DashboardResponse)));
        }

    }
}
