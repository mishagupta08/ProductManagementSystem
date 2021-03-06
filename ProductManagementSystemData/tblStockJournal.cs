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
    
    public partial class tblStockJournal
    {
        public tblStockJournal()
        {
            this.tblStockJournalToExpenses = new HashSet<tblStockJournalToExpense>();
            this.tblStockJournalToItems = new HashSet<tblStockJournalToItem>();
            this.tblStockJournalToPartyToItems = new HashSet<tblStockJournalToPartyToItem>();
        }
    
        public int StockJournalID { get; set; }
        public Nullable<int> StockJournalType { get; set; }
        public Nullable<int> StockCountingVoucherID { get; set; }
        public Nullable<System.DateTime> StkJrnllDate { get; set; }
        public string StkJrnlCode { get; set; }
        public string StkJrnlSubject { get; set; }
        public string stkJrnlRemark { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<int> ConsunptionTypeID { get; set; }
        public Nullable<int> GodownIDFrom { get; set; }
        public Nullable<int> GodownIDTo { get; set; }
        public string LRNo { get; set; }
        public string DispatchThrough { get; set; }
        public string Destination { get; set; }
        public string DeliveryTerms { get; set; }
        public Nullable<int> StoreID { get; set; }
    
        public virtual ICollection<tblStockJournalToExpense> tblStockJournalToExpenses { get; set; }
        public virtual ICollection<tblStockJournalToItem> tblStockJournalToItems { get; set; }
        public virtual ICollection<tblStockJournalToPartyToItem> tblStockJournalToPartyToItems { get; set; }
    }
}
