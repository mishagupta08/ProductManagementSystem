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
    
    public partial class TempLocationWiseTransaction
    {
        public int RecordID { get; set; }
        public Nullable<int> RowIndex { get; set; }
        public string Trantype { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<int> BatchID { get; set; }
        public string Location { get; set; }
        public Nullable<int> TransID { get; set; }
        public string Estimated { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<double> TransRate { get; set; }
        public Nullable<double> CostRate { get; set; }
        public Nullable<double> OpeningStock { get; set; }
        public Nullable<double> INQty { get; set; }
        public Nullable<double> OutQty { get; set; }
        public Nullable<double> ClosingStock { get; set; }
        public Nullable<double> OpeningStockValuation { get; set; }
        public Nullable<double> INAmt { get; set; }
        public Nullable<double> OutAmt { get; set; }
        public Nullable<double> ClosingStockValuation { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string RowID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public string TransCode { get; set; }
        public Nullable<double> TransMRP { get; set; }
    }
}