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
    
    public partial class tblPurchaseOrderItemTax
    {
        public int RecordID { get; set; }
        public Nullable<int> OrderItemID { get; set; }
        public Nullable<int> TAXID { get; set; }
        public string Formula { get; set; }
        public string ExpCode { get; set; }
        public Nullable<double> PerValue { get; set; }
        public Nullable<int> SelectedExpCode { get; set; }
        public Nullable<double> HardValue { get; set; }
        public string Title { get; set; }
    
        public virtual tblPurchaseOrderItem tblPurchaseOrderItem { get; set; }
    }
}
