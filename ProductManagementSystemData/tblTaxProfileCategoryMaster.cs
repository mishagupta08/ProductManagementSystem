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
    
    public partial class tblTaxProfileCategoryMaster
    {
        public int TaxProfileCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string DisplayCode { get; set; }
        public Nullable<int> BaseStateID { get; set; }
        public Nullable<bool> IsLocalTax { get; set; }
        public Nullable<bool> IsManualTax { get; set; }
        public string Remarks { get; set; }
    }
}
