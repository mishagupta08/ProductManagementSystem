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
    
    public partial class tblSalesInvoiceItemToTax
    {
        public int RecordID { get; set; }
        public Nullable<int> TAXID { get; set; }
        public Nullable<int> InvoiceItemID { get; set; }
        public string Formula { get; set; }
        public string ExpCode { get; set; }
        public Nullable<double> PerValue { get; set; }
        public Nullable<int> SelectedExpCode { get; set; }
        public Nullable<double> HardValue { get; set; }
        public string Title { get; set; }
    
        public virtual tblSalesInvoiceItem tblSalesInvoiceItem { get; set; }
    }
}
