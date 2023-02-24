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
    public class GetRecipientResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string name;
        private string email;
        private string document;
        private string description;
        private string type;
        private string status;
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime deletedAt;
        private Models.GetBankAccountResponse defaultBankAccount;
        private List<Models.GetGatewayRecipientResponse> gatewayRecipients;
        private Dictionary<string, string> metadata;
        private Models.GetAutomaticAnticipationResponse automaticAnticipationSettings;
        private Models.GetTransferSettingsResponse transferSettings;
        private string code;
        private string paymentMode;

        /// <summary>
        /// Id
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
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Document
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Type
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
        /// Status
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
        /// Creation date
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
        /// Last update date
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
        /// Deletion date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime DeletedAt 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.GetBankAccountResponse DefaultBankAccount 
        { 
            get 
            {
                return this.defaultBankAccount; 
            } 
            set 
            {
                this.defaultBankAccount = value;
                onPropertyChanged("DefaultBankAccount");
            }
        }

        /// <summary>
        /// Info about the recipient on the gateway
        /// </summary>
        [JsonProperty("gateway_recipients")]
        public List<Models.GetGatewayRecipientResponse> GatewayRecipients 
        { 
            get 
            {
                return this.gatewayRecipients; 
            } 
            set 
            {
                this.gatewayRecipients = value;
                onPropertyChanged("GatewayRecipients");
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
        [JsonProperty("automatic_anticipation_settings")]
        public Models.GetAutomaticAnticipationResponse AutomaticAnticipationSettings 
        { 
            get 
            {
                return this.automaticAnticipationSettings; 
            } 
            set 
            {
                this.automaticAnticipationSettings = value;
                onPropertyChanged("AutomaticAnticipationSettings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_settings")]
        public Models.GetTransferSettingsResponse TransferSettings 
        { 
            get 
            {
                return this.transferSettings; 
            } 
            set 
            {
                this.transferSettings = value;
                onPropertyChanged("TransferSettings");
            }
        }

        /// <summary>
        /// Recipient code
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode 
        { 
            get 
            {
                return this.paymentMode; 
            } 
            set 
            {
                this.paymentMode = value;
                onPropertyChanged("PaymentMode");
            }
        }
    }
} 