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
    
    public partial class tblPurchaseOrderItem
    {
        public tblPurchaseOrderItem()
        {
            this.tblPurchaseOrderItemTaxes = new HashSet<tblPurchaseOrderItemTax>();
            this.tblPurchaseOrderItemToDiscounts = new HashSet<tblPurchaseOrderItemToDiscount>();
        }
    
        public int RecordID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ItemTypeID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<double> ActualQty { get; set; }
        public Nullable<double> BilledQty { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<double> Rate { get; set; }
        public string Remark { get; set; }
        public Nullable<double> MRP { get; set; }
        public Nullable<int> GodownID { get; set; }
        public Nullable<int> TaxProfileID { get; set; }
        public string TaxDescription { get; set; }
        public Nullable<double> OGSPerValue { get; set; }
    
        public virtual tblPurchaseOrder tblPurchaseOrder { get; set; }
        public virtual ICollection<tblPurchaseOrderItemTax> tblPurchaseOrderItemTaxes { get; set; }
        public virtual ICollection<tblPurchaseOrderItemToDiscount> tblPurchaseOrderItemToDiscounts { get; set; }
    }
}