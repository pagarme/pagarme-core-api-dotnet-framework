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
    public class GetPixPayerResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string document;
        private string documentType;
        private Models.GetPixBankAccountResponse bankAccount;

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("document_type")]
        public string DocumentType 
        { 
            get 
            {
                return this.documentType; 
            } 
            set 
            {
                this.documentType = value;
                onPropertyChanged("DocumentType");
            }
        }

        /// <summary>
        /// Payer's bank details.
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.GetPixBankAccountResponse BankAccount 
        { 
            get 
            {
                return this.bankAccount; 
            } 
            set 
            {
                this.bankAccount = value;
                onPropertyChanged("BankAccount");
            }
        }
    }
} 