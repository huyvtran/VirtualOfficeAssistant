//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMSDomain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Other_Expenses
    {
        public int OEID { get; set; }
        public Nullable<int> CompID { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> ExpID { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Branch_master Branch_master { get; set; }
        public virtual Company_master Company_master { get; set; }
        public virtual employee_master employee_master { get; set; }
        public virtual Masters_Tran Masters_Tran { get; set; }
    }
}