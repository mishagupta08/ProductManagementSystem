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
    
    public partial class tblJournalVoucher
    {
        public tblJournalVoucher()
        {
            this.tblJournalVoucherToDiscounts = new HashSet<tblJournalVoucherToDiscount>();
            this.tblJournalVoucherToTaxes = new HashSet<tblJournalVoucherToTax>();
            this.tblJVToLedgers = new HashSet<tblJVToLedger>();
        }
    
        public int JVID { get; set; }
        public Nullable<System.DateTime> JvDate { get; set; }
        public string JvRefNo { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Remark { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
    
        public virtual ICollection<tblJournalVoucherToDiscount> tblJournalVoucherToDiscounts { get; set; }
        public virtual ICollection<tblJournalVoucherToTax> tblJournalVoucherToTaxes { get; set; }
        public virtual ICollection<tblJVToLedger> tblJVToLedgers { get; set; }
    }
}
