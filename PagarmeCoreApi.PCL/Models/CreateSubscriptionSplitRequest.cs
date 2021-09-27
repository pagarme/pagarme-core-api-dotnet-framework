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
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;


namespace PagarmeCoreApi.PCL.Models
{
    public class CreateSubscriptionSplitRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool enable;
        private Models.CreateSplitRequest rules;

        /// <summary>
        /// Defines if the split is enabled
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable 
        { 
            get 
            {
                return this.enable; 
            } 
            set 
            {
                this.enable = value;
                onPropertyChanged("Enable");
            }
        }

        /// <summary>
        /// Split
        /// </summary>
        [JsonProperty("rules")]
        public Models.CreateSplitRequest Rules 
        { 
            get 
            {
                return this.rules; 
            } 
            set 
            {
                this.rules = value;
                onPropertyChanged("Rules");
            }
        }
    }
} 