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
    
    public partial class FormMaster
    {
        public FormMaster()
        {
            this.FormMenuTrans = new HashSet<FormMenuTran>();
            this.MenuTrans = new HashSet<MenuTran>();
        }
    
        public int FormId { get; set; }
        public string FormTitle { get; set; }
        public string FormName { get; set; }
        public string FormUrl { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<FormMenuTran> FormMenuTrans { get; set; }
        public virtual ICollection<MenuTran> MenuTrans { get; set; }
    }
}
