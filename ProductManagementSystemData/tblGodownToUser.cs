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
    
    public partial class tblGodownToUser
    {
        public int RecordId { get; set; }
        public Nullable<int> GodownId { get; set; }
        public Nullable<int> InchargeUserID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
