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
    
    public partial class tblParty_Master
    {
        public tblParty_Master()
        {
            this.tblContraVoucherLedgers = new HashSet<tblContraVoucherLedger>();
            this.tblCrditNoteToLedgers = new HashSet<tblCrditNoteToLedger>();
            this.tblCreditNotes = new HashSet<tblCreditNote>();
            this.tblDebitNoteToLedgers = new HashSet<tblDebitNoteToLedger>();
            this.tblPaymentVoucherToLedgers = new HashSet<tblPaymentVoucherToLedger>();
            this.tblPurchaseInvoiceToLedgers = new HashSet<tblPurchaseInvoiceToLedger>();
            this.tblRecieptVoucherToLegers = new HashSet<tblRecieptVoucherToLeger>();
            this.tblSalesInvoiceToLedgers = new HashSet<tblSalesInvoiceToLedger>();
        }
    
        public int PartyID { get; set; }
        public Nullable<int> Salutation { get; set; }
        public string PartyName { get; set; }
        public Nullable<int> TypeOfParty { get; set; }
        public string IncomeTax { get; set; }
        public string CentralSaleTax { get; set; }
        public string StateSaleTax { get; set; }
        public Nullable<double> OpenBalance { get; set; }
        public Nullable<bool> BalanceType { get; set; }
        public Nullable<double> DefaultCreditPeriod { get; set; }
        public Nullable<int> DefaultCreditPeriodIn { get; set; }
        public Nullable<bool> InterestCalculation { get; set; }
        public Nullable<bool> MaintainInventory { get; set; }
        public Nullable<bool> MaintainBillInfo { get; set; }
        public Nullable<bool> MaintainOrder { get; set; }
        public string OtherDetails { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string ReasonForEdit { get; set; }
        public Nullable<int> PartyGroupID { get; set; }
        public Nullable<bool> IsTaxable { get; set; }
    
        public virtual tblCompanyGroup tblCompanyGroup { get; set; }
        public virtual ICollection<tblContraVoucherLedger> tblContraVoucherLedgers { get; set; }
        public virtual ICollection<tblCrditNoteToLedger> tblCrditNoteToLedgers { get; set; }
        public virtual ICollection<tblCreditNote> tblCreditNotes { get; set; }
        public virtual ICollection<tblDebitNoteToLedger> tblDebitNoteToLedgers { get; set; }
        public virtual ICollection<tblPaymentVoucherToLedger> tblPaymentVoucherToLedgers { get; set; }
        public virtual ICollection<tblPurchaseInvoiceToLedger> tblPurchaseInvoiceToLedgers { get; set; }
        public virtual ICollection<tblRecieptVoucherToLeger> tblRecieptVoucherToLegers { get; set; }
        public virtual ICollection<tblSalesInvoiceToLedger> tblSalesInvoiceToLedgers { get; set; }
    }
}
