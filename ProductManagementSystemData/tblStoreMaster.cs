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
    
    public partial class tblStoreMaster
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> DefaultGodownID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TINNo { get; set; }
        public string CSTNo { get; set; }
        public string PinCode { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Area { get; set; }
        public string Prefix { get; set; }
    }
}