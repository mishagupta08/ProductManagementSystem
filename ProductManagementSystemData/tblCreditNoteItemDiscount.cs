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
    
    public partial class tblCreditNoteItemDiscount
    {
        public int RecordID { get; set; }
        public int DiscountID { get; set; }
        public Nullable<int> CRDItemID { get; set; }
        public Nullable<bool> IsPercentage { get; set; }
        public Nullable<double> DiscountValue { get; set; }
        public Nullable<double> PerValue { get; set; }
    
        public virtual tblCreditNoteItem tblCreditNoteItem { get; set; }
    }
}
