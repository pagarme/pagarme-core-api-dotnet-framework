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
    public class UpdateCardRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string holderName;
        private int expMonth;
        private int expYear;
        private string billingAddressId;
        private Models.CreateAddressRequest billingAddress;
        private Dictionary<string, string> metadata;
        private string label;

        /// <summary>
        /// Holder name
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName 
        { 
            get 
            {
                return this.holderName; 
            } 
            set 
            {
                this.holderName = value;
                onPropertyChanged("HolderName");
            }
        }

        /// <summary>
        /// Expiration month
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth 
        { 
            get 
            {
                return this.expMonth; 
            } 
            set 
            {
                this.expMonth = value;
                onPropertyChanged("ExpMonth");
            }
        }

        /// <summary>
        /// Expiration year
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear 
        { 
            get 
            {
                return this.expYear; 
            } 
            set 
            {
                this.expYear = value;
                onPropertyChanged("ExpYear");
            }
        }

        /// <summary>
        /// Id of the address to be used as billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId 
        { 
            get 
            {
                return this.billingAddressId; 
            } 
            set 
            {
                this.billingAddressId = value;
                onPropertyChanged("BillingAddressId");
            }
        }

        /// <summary>
        /// Request for creating a new Address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }
    }
} 