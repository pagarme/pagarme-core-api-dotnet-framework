/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.PCL.Http.Client;

using PagarmeCoreApi.PCL.Models;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;


namespace PagarmeCoreApi.PCL.Exceptions
{
    public class ErrorException : APIException 
    {
        // These fields hold the values for the public properties.
        private string message;
        private object errors;
        private object request;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public object Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("request")]
        public object Request 
        { 
            get 
            {
                return this.request; 
            } 
            private set 
            {
                this.request = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 