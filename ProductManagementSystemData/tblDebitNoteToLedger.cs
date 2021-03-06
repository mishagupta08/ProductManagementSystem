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
    
    public partial class tblDebitNoteToLedger
    {
        public tblDebitNoteToLedger()
        {
            this.tblDebitNoteToDiscounts = new HashSet<tblDebitNoteToDiscount>();
            this.tblDebitNoteToLedgerItems = new HashSet<tblDebitNoteToLedgerItem>();
            this.tblDebitNoteToTaxes = new HashSet<tblDebitNoteToTax>();
        }
    
        public int RecordID { get; set; }
        public Nullable<int> DebitNoteID { get; set; }
        public Nullable<int> LedgerID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<int> IsCrdit { get; set; }
        public string Remark { get; set; }
    
        public virtual tblDebitNote tblDebitNote { get; set; }
        public virtual ICollection<tblDebitNoteToDiscount> tblDebitNoteToDiscounts { get; set; }
        public virtual tblParty_Master tblParty_Master { get; set; }
        public virtual ICollection<tblDebitNoteToLedgerItem> tblDebitNoteToLedgerItems { get; set; }
        public virtual ICollection<tblDebitNoteToTax> tblDebitNoteToTaxes { get; set; }
    }
}
