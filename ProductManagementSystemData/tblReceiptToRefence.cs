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
    
    public partial class tblReceiptToRefence
    {
        public int RecordID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<int> ReferenceType { get; set; }
        public Nullable<int> ReferenceID { get; set; }
        public Nullable<double> ReceiptAmount { get; set; }
        public Nullable<int> RecieptID { get; set; }
        public Nullable<double> AdjustedAmount { get; set; }
    
        public virtual tblRecieptVoucher tblRecieptVoucher { get; set; }
    }
}