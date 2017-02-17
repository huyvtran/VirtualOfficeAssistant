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
    
    public partial class Company_master
    {
        public Company_master()
        {
            this.EmployeeInsurances = new HashSet<EmployeeInsurance>();
            this.Other_Expenses = new HashSet<Other_Expenses>();
            this.TravelExpences = new HashSet<TravelExpence>();
            this.VehicleMasters = new HashSet<VehicleMaster>();
            this.VehicleRepairings = new HashSet<VehicleRepairing>();
        }
    
        public int id { get; set; }
        public string Compcode { get; set; }
        public string CompName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Logo { get; set; }
        public string Sign { get; set; }
        public Nullable<int> PCompId { get; set; }
    
        public virtual ICollection<EmployeeInsurance> EmployeeInsurances { get; set; }
        public virtual ICollection<Other_Expenses> Other_Expenses { get; set; }
        public virtual ICollection<TravelExpence> TravelExpences { get; set; }
        public virtual ICollection<VehicleMaster> VehicleMasters { get; set; }
        public virtual ICollection<VehicleRepairing> VehicleRepairings { get; set; }
    }
}