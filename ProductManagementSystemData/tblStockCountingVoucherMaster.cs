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
    
    public partial class tblStockCountingVoucherMaster
    {
        public int StockCountingVoucherID { get; set; }
        public Nullable<int> StockCountingCycleID { get; set; }
        public string StockCountingVoucherCode { get; set; }
        public Nullable<int> RackID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Count { get; set; }
        public string Remark { get; set; }
        public Nullable<int> CompanyID { get; set; }
    
        public virtual tblRackMaster tblRackMaster { get; set; }
        public virtual tblStockCountingCycleMaster tblStockCountingCycleMaster { get; set; }
    }
}
