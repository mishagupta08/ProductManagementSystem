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
    
    public partial class tblPurchaseInvoiceToExtraCharge
    {
        public int RecordID { get; set; }
        public Nullable<int> PurchaseInvoiceID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> DiscPerValue { get; set; }
        public string Remarks { get; set; }
    }
}
