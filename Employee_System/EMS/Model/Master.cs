//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Master
    {
        public Master()
        {
            this.Masters_Tran = new HashSet<Masters_Tran>();
        }
    
        public int MId { get; set; }
        public string MasterType { get; set; }
        public string MasterDesc { get; set; }
        public string MasterCode { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<Masters_Tran> Masters_Tran { get; set; }
    }
}
