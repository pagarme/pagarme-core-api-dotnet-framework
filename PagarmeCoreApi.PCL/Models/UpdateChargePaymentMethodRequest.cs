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
    public class UpdateChargePaymentMethodRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool updateSubscription;
        private string paymentMethod;
        private Models.CreateCreditCardPaymentRequest creditCard;
        private Models.CreateDebitCardPaymentRequest debitCard;
        private Models.CreateBoletoPaymentRequest boleto;
        private Models.CreateVoucherPaymentRequest voucher;
        private Models.CreateCashPaymentRequest cash;
        private Models.CreateBankTransferPaymentRequest bankTransfer;
        private Models.CreatePrivateLabelPaymentRequest privateLabel;

        /// <summary>
        /// Indicates if the payment method from the subscription must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription 
        { 
            get 
            {
                return this.updateSubscription; 
            } 
            set 
            {
                this.updateSubscription = value;
                onPropertyChanged("UpdateSubscription");
            }
        }

        /// <summary>
        /// The new payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// The settings for creating a credit card payment
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// The settings for creating a debit card payment
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.CreateDebitCardPaymentRequest DebitCard 
        { 
            get 
            {
                return this.debitCard; 
            } 
            set 
            {
                this.debitCard = value;
                onPropertyChanged("DebitCard");
            }
        }

        /// <summary>
        /// Contains the settings for creating a boleto payment
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// The settings for creating a voucher payment
        /// </summary>
        [JsonProperty("voucher")]
        public Models.CreateVoucherPaymentRequest Voucher 
        { 
            get 
            {
                return this.voucher; 
            } 
            set 
            {
                this.voucher = value;
                onPropertyChanged("Voucher");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cash")]
        public Models.CreateCashPaymentRequest Cash 
        { 
            get 
            {
                return this.cash; 
            } 
            set 
            {
                this.cash = value;
                onPropertyChanged("Cash");
            }
        }

        /// <summary>
        /// Request for creating a bank transfer payment
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.CreateBankTransferPaymentRequest BankTransfer 
        { 
            get 
            {
                return this.bankTransfer; 
            } 
            set 
            {
                this.bankTransfer = value;
                onPropertyChanged("BankTransfer");
            }
        }

        /// <summary>
        /// The settings for creating a private label payment
        /// </summary>
        [JsonProperty("private_label")]
        public Models.CreatePrivateLabelPaymentRequest PrivateLabel 
        { 
            get 
            {
                return this.privateLabel; 
            } 
            set 
            {
                this.privateLabel = value;
                onPropertyChanged("PrivateLabel");
            }
        }
    }
} 