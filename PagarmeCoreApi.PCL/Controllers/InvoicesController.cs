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
    public partial class InvoicesController: BaseController, IInvoicesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static InvoicesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static InvoicesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new InvoicesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse UpdateInvoiceMetadata(string invoiceId, Models.UpdateMetadataRequest request, string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = UpdateInvoiceMetadataAsync(invoiceId, request, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceMetadataAsync(string invoiceId, Models.UpdateMetadataRequest request, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}/metadata");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse GetPartialInvoice(string subscriptionId)
        {
            Task<Models.GetInvoiceResponse> t = GetPartialInvoiceAsync(subscriptionId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> GetPartialInvoiceAsync(string subscriptionId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/subscriptions/{subscription_id}/partial-invoice");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId }
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
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse CancelInvoice(string invoiceId, string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = CancelInvoiceAsync(invoiceId, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> CancelInvoiceAsync(string invoiceId, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" },
                { "idempotency-key", idempotencyKey }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <param name="request">Optional parameter: Example: </param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse CreateInvoice(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = CreateInvoiceAsync(subscriptionId, cycleId, request, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <param name="request">Optional parameter: Example: </param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> CreateInvoiceAsync(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/subscriptions/{subscription_id}/cycles/{cycle_id}/pay");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "cycle_id", cycleId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range</param>
        /// <param name="customerDocument">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListInvoicesResponse response from the API call</return>
        public Models.ListInvoicesResponse GetInvoices(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null)
        {
            Task<Models.ListInvoicesResponse> t = GetInvoicesAsync(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range</param>
        /// <param name="customerDocument">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListInvoicesResponse response from the API call</return>
        public async Task<Models.ListInvoicesResponse> GetInvoicesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "customer_id", customerId },
                { "subscription_id", subscriptionId },
                { "created_since", (createdSince.HasValue) ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", (createdUntil.HasValue) ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "status", status },
                { "due_since", (dueSince.HasValue) ? dueSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "due_until", (dueUntil.HasValue) ? dueUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "customer_document", customerDocument }
            },ArrayDeserializationFormat,ParameterSeparator);


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
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListInvoicesResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse GetInvoice(string invoiceId)
        {
            Task<Models.GetInvoiceResponse> t = GetInvoiceAsync(invoiceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> GetInvoiceAsync(string invoiceId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
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
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public Models.GetInvoiceResponse UpdateInvoiceStatus(string invoiceId, Models.UpdateInvoiceStatusRequest request, string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = UpdateInvoiceStatusAsync(invoiceId, request, idempotencyKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceStatusAsync(string invoiceId, Models.UpdateInvoiceStatusRequest request, string idempotencyKey = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/invoices/{invoice_id}/status");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetInvoiceResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 