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
    
    public partial class EmployeeQualification
    {
        public int Qid { get; set; }
        public Nullable<int> Empid { get; set; }
        public string SchoolName { get; set; }
        public string Board { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string CertType { get; set; }
        public string CertTitle { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public string Grade { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CertificateID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual employee_master employee_master { get; set; }
        public virtual employee_master employee_master1 { get; set; }
    }
}
