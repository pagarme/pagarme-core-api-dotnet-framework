/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;
using PagarmeCoreApi.PCL.Http.Request;
using PagarmeCoreApi.PCL.Http.Response;
using PagarmeCoreApi.PCL.Http.Client;

namespace PagarmeCoreApi.PCL.Controllers
{
    public partial interface ITokensController
    {
        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="body">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse CreateToken(
                string publicKey,
                Models.CreateTokenRequest body,
                string idempotencyKey = null,
                string appId = null);

        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="body">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> CreateTokenAsync(
                string publicKey,
                Models.CreateTokenRequest body,
                string idempotencyKey = null,
                string appId = null);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse GetToken(string id, string publicKey, string appId = null);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="appId">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> GetTokenAsync(string id, string publicKey, string appId = null);

    }
} 