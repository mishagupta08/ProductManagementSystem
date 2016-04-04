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
    
    public partial class tblPurchaseOrder
    {
        public tblPurchaseOrder()
        {
            this.tblPurchaseOrderDiscounts = new HashSet<tblPurchaseOrderDiscount>();
            this.tblPurchaseOrderItems = new HashSet<tblPurchaseOrderItem>();
            this.tblPurchaseOrderToTaxes = new HashSet<tblPurchaseOrderToTax>();
        }
    
        public int PurchaseOrderID { get; set; }
        public string PurchaseOrderCode { get; set; }
        public string Subject { get; set; }
        public int PartyID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime OrderValidityDate { get; set; }
        public int OrderStatus { get; set; }
        public Nullable<int> QuotRef { get; set; }
        public string PaymentTerms { get; set; }
        public string DeleveryTerm { get; set; }
        public string OtherTerms { get; set; }
        public string SenderParty { get; set; }
        public string RecieverParty { get; set; }
        public int TransportType { get; set; }
        public int TransportCompany { get; set; }
        public string DeliveryAddres { get; set; }
        public string LoadingPort { get; set; }
        public string DespatchPort { get; set; }
        public string CountryTo { get; set; }
        public string ContactPerson { get; set; }
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
        public Nullable<double> BillingAmount { get; set; }
        public string PartySOCode { get; set; }
        public string FOB { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<double> RoundOff { get; set; }
        public Nullable<double> CashDisc { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<int> GodownID { get; set; }
        public string ReasonForEdit { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> TaxProfileCategoryID { get; set; }
        public Nullable<bool> IsTaxInclusive { get; set; }
    
        public virtual ICollection<tblPurchaseOrderDiscount> tblPurchaseOrderDiscounts { get; set; }
        public virtual ICollection<tblPurchaseOrderItem> tblPurchaseOrderItems { get; set; }
        public virtual ICollection<tblPurchaseOrderToTax> tblPurchaseOrderToTaxes { get; set; }
    }
}