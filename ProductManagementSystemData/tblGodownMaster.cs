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
    
    public partial class tblGodownMaster
    {
        public int GodownID { get; set; }
        public string GodownName { get; set; }
        public string Incharge { get; set; }
        public string Location { get; set; }
        public string OtherDetails { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string VatNo { get; set; }
        public string CSTNo { get; set; }
        public string LRNo { get; set; }
        public string TermsOfDelivery { get; set; }
    }
}
