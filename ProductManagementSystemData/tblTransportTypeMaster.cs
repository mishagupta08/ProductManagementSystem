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
    
    public partial class tblTransportTypeMaster
    {
        public tblTransportTypeMaster()
        {
            this.tblTransportComanyMasters = new HashSet<tblTransportComanyMaster>();
        }
    
        public int TransportTypeID { get; set; }
        public string TransportType { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> InsertBy { get; set; }
        public Nullable<System.DateTime> InsertAt { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
    
        public virtual ICollection<tblTransportComanyMaster> tblTransportComanyMasters { get; set; }
    }
}
