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
    
    public partial class tblRackMaster
    {
        public tblRackMaster()
        {
            this.tblStockCountingVoucherMasters = new HashSet<tblStockCountingVoucherMaster>();
        }
    
        public int RackID { get; set; }
        public string RackName { get; set; }
        public Nullable<int> GodownID { get; set; }
        public string RackCode { get; set; }
        public string RackBarCode { get; set; }
        public Nullable<int> CompanyID { get; set; }
    
        public virtual ICollection<tblStockCountingVoucherMaster> tblStockCountingVoucherMasters { get; set; }
    }
}
