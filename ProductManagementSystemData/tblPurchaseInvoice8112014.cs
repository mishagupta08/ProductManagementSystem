//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagementSystemData
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPurchaseInvoice8112014
    {
        public int PurchaseInvoiceID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceCodeFromSupplier { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string DeleveryNoteNo { get; set; }
        public string DocNo { get; set; }
        public Nullable<int> TransportCompany { get; set; }
        public Nullable<int> TransportType { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string PaymentTerms { get; set; }
        public string DeleveryTerms { get; set; }
        public string OtherTerms { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string FlightNo { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string CountryTo { get; set; }
        public Nullable<int> InWardID { get; set; }
        public Nullable<bool> IsCombinedVoucher { get; set; }
        public Nullable<bool> WithoutInventory { get; set; }
        public Nullable<double> BillingAmount { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<double> RoundOff { get; set; }
        public Nullable<int> InvoiceType { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<bool> TAXIncluding { get; set; }
        public Nullable<int> TAXProfileID { get; set; }
        public Nullable<bool> CSTIncluding { get; set; }
        public Nullable<bool> IsCSTPercentage { get; set; }
        public Nullable<double> CSTPerValue { get; set; }
        public Nullable<int> TaxType { get; set; }
    }
}