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
    
    public partial class tblInvoiceTypeMaster
    {
        public int InvoiceTypeID { get; set; }
        public string InvoiceType { get; set; }
        public string PreFix { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<bool> IsOnline { get; set; }
    }
}
