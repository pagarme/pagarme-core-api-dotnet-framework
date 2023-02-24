/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;
using PagarmeCoreApi.PCL.Http.Request;
using PagarmeCoreApi.PCL.Http.Response;
using PagarmeCoreApi.PCL.Http.Client;
using PagarmeCoreApi.PCL.Exceptions;

namespace PagarmeCoreApi.PCL.Controllers
{
    public partial class TransactionsController: BaseController, ITransactionsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TransactionsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TransactionsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TransactionsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// GetTransaction
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        public Models.GetTransactionResponse GetTransaction(string transactionId)
        {
            Task<Models.GetTransactionResponse> t = GetTransactionAsync(transactionId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetTransaction
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        public async Task<Models.GetTransactionResponse> GetTransactionAsync(string transactionId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transactions/{transaction_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "transaction_id", transactionId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetTransactionResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 