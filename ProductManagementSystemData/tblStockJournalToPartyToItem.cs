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
    
    public partial class tblStockJournalToPartyToItem
    {
        public int RecordID { get; set; }
        public Nullable<int> StockJournalID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<int> GodownID { get; set; }
        public string BatchNo { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsCredit { get; set; }
    
        public virtual tblStockJournal tblStockJournal { get; set; }
    }
}
