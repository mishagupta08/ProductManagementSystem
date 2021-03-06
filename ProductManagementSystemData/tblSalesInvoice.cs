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
    
    public partial class tblSalesInvoice
    {
        public tblSalesInvoice()
        {
            this.tblSalesInvoiceItems = new HashSet<tblSalesInvoiceItem>();
            this.tblSalesInvoiceToDiscounts = new HashSet<tblSalesInvoiceToDiscount>();
            this.tblSalesInvoiceToLedgers = new HashSet<tblSalesInvoiceToLedger>();
            this.tblSalesInvoiceToTaxes = new HashSet<tblSalesInvoiceToTax>();
        }
    
        public int SalesInvoiceID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string InvoiceCode { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string DeleveryNoteNo { get; set; }
        public string DocNo { get; set; }
        public string TransportCompany { get; set; }
        public Nullable<int> TransportType { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public Nullable<int> PaymentTerms { get; set; }
        public string DeleveryTerms { get; set; }
        public string OtherTerms { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string FlightNo { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string CountryTo { get; set; }
        public Nullable<int> OutWardID { get; set; }
        public Nullable<bool> IsCombinedVoucher { get; set; }
        public Nullable<double> BillingAmount { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<double> RoundOff { get; set; }
        public Nullable<double> CashDisc { get; set; }
        public Nullable<int> InvoiceType { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<double> total { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerDetail { get; set; }
        public string SalesPerson { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> StatusTypeID { get; set; }
        public string FPOrderNo { get; set; }
        public string FPBarcode { get; set; }
        public Nullable<int> FPCustomerID { get; set; }
        public Nullable<int> FPStatus1 { get; set; }
        public Nullable<int> FPStatus2 { get; set; }
        public string TransactionRef { get; set; }
        public string OrderItemID { get; set; }
        public Nullable<double> ShippingCharges { get; set; }
        public Nullable<double> SettlementAmount { get; set; }
        public Nullable<bool> MultiPaymentStatus { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<bool> IsDublicate { get; set; }
        public Nullable<System.DateTime> FPReturnDate { get; set; }
        public string ReasonForEdit { get; set; }
        public Nullable<int> GodownID { get; set; }
        public string InvoiceCode2 { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<double> CSTPerValue { get; set; }
        public Nullable<int> TAXCategory { get; set; }
        public Nullable<bool> IsTAXIncluding { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> TaxProfileCategoryID { get; set; }
        public Nullable<bool> IsTaxInclusive { get; set; }
        public Nullable<int> PartyAddressID { get; set; }
        public Nullable<int> StoreID { get; set; }
        public string ConsigneeTinNo { get; set; }
        public Nullable<System.DateTime> DispatchDate { get; set; }
        public Nullable<double> SumOfCostRate { get; set; }
        public string ShippingBillNo { get; set; }
        public string DeliveryFrom { get; set; }
        public string DeliveryTo { get; set; }
    
        public virtual ICollection<tblSalesInvoiceItem> tblSalesInvoiceItems { get; set; }
        public virtual ICollection<tblSalesInvoiceToDiscount> tblSalesInvoiceToDiscounts { get; set; }
        public virtual ICollection<tblSalesInvoiceToLedger> tblSalesInvoiceToLedgers { get; set; }
        public virtual ICollection<tblSalesInvoiceToTax> tblSalesInvoiceToTaxes { get; set; }
    }
}
