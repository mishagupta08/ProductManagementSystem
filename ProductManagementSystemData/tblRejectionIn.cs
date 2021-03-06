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
    
    public partial class tblRejectionIn
    {
        public tblRejectionIn()
        {
            this.tblRejectionInItems = new HashSet<tblRejectionInItem>();
        }
    
        public int RejectionInID { get; set; }
        public Nullable<System.DateTime> RejectionDate { get; set; }
        public string RejectionCode { get; set; }
        public string Subject { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> GodownID { get; set; }
        public Nullable<double> CashDisc { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<double> CSTPerValue { get; set; }
        public string ReasonForEdit { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> TaxProfileCategoryID { get; set; }
        public Nullable<bool> IsTaxInclusive { get; set; }
        public string DeleveryNoteNo { get; set; }
        public string DocNo { get; set; }
        public Nullable<int> TransportCompany { get; set; }
        public Nullable<int> TransportType { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string PaymentTerms { get; set; }
        public string DeleveryTerms { get; set; }
        public string OtherTerms { get; set; }
        public string ShippingAddress { get; set; }
        public string FlightNo { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string CountryTo { get; set; }
        public string ConsigneeTinNo { get; set; }
        public Nullable<System.DateTime> DispatchDate { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<double> SumOfCostRate { get; set; }
        public string ShippingBillNo { get; set; }
        public string DeliveryFrom { get; set; }
        public string DeliveryTo { get; set; }
    
        public virtual ICollection<tblRejectionInItem> tblRejectionInItems { get; set; }
    }
}
