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
    
    public partial class tblItemToSubItem
    {
        public int RecordID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> SubItemID { get; set; }
        public string SubItemInfo { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> Inunit { get; set; }
        public Nullable<double> Rate { get; set; }
    
        public virtual tblItemMaster tblItemMaster { get; set; }
    }
}
