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
    
    public partial class tblSectionMaster
    {
        public tblSectionMaster()
        {
            this.tblUserPermissions = new HashSet<tblUserPermission>();
        }
    
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public int ModuleID { get; set; }
        public string SectionDescription { get; set; }
        public string Url { get; set; }
        public Nullable<int> ParentSectionID { get; set; }
    
        public virtual tblModuleMaster tblModuleMaster { get; set; }
        public virtual ICollection<tblUserPermission> tblUserPermissions { get; set; }
    }
}