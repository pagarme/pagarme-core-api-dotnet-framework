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
    public class GetCardResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string lastFourDigits;
        private string brand;
        private string holderName;
        private int expMonth;
        private int expYear;
        private string status;
        private DateTime createdAt;
        private DateTime updatedAt;
        private Models.GetBillingAddressResponse billingAddress;
        private Models.GetCustomerResponse customer;
        private Dictionary<string, string> metadata;
        private string type;
        private string holderDocument;
        private DateTime? deletedAt;
        private string firstSixDigits;
        private string label;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("last_four_digits")]
        public string LastFourDigits 
        { 
            get 
            {
                return this.lastFourDigits; 
            } 
            set 
            {
                this.lastFourDigits = value;
                onPropertyChanged("LastFourDigits");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("brand")]
        public string Brand 
        { 
            get 
            {
                return this.brand; 
            } 
            set 
            {
                this.brand = value;
                onPropertyChanged("Brand");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// Response object for getting a billing address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress 
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
        /// Response object for getting a customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// Card type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Document number for the card's holder
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument 
        { 
            get 
            {
                return this.holderDocument; 
            } 
            set 
            {
                this.holderDocument = value;
                onPropertyChanged("HolderDocument");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt 
        { 
            get 
            {
                return this.deletedAt; 
            } 
            set 
            {
                this.deletedAt = value;
                onPropertyChanged("DeletedAt");
            }
        }

        /// <summary>
        /// First six digits
        /// </summary>
        [JsonProperty("first_six_digits")]
        public string FirstSixDigits 
        { 
            get 
            {
                return this.firstSixDigits; 
            } 
            set 
            {
                this.firstSixDigits = value;
                onPropertyChanged("FirstSixDigits");
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