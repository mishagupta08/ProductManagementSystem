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
    
    public partial class tblOutwordToTAX
    {
        public int RecordID { get; set; }
        public Nullable<int> TAXID { get; set; }
        public Nullable<int> OutwordID { get; set; }
        public Nullable<bool> IsPercentage { get; set; }
        public Nullable<double> TAXValue { get; set; }
    
        public virtual tblOutword tblOutword { get; set; }
    }
}