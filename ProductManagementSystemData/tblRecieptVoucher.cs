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
    
    public partial class tblRecieptVoucher
    {
        public tblRecieptVoucher()
        {
            this.tblReceiptToRefences = new HashSet<tblReceiptToRefence>();
            this.tblRecieptVoucherToLegers = new HashSet<tblRecieptVoucherToLeger>();
        }
    
        public int RecieptVoucherID { get; set; }
        public Nullable<System.DateTime> RecieptVoucherDate { get; set; }
        public string RecieptVoucherRefNo { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Remark { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<int> RecieptTypeID { get; set; }
        public Nullable<int> RecieptFrom { get; set; }
        public Nullable<double> Kasar { get; set; }
    
        public virtual ICollection<tblReceiptToRefence> tblReceiptToRefences { get; set; }
        public virtual ICollection<tblRecieptVoucherToLeger> tblRecieptVoucherToLegers { get; set; }
    }
}