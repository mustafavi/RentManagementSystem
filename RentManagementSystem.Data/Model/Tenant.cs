using System;
using System.Collections.Generic;

namespace RentManagementSystem.Data
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string TenantName { get; set; }
        public string NIC { get; set; }
        public DateTime ContractStarted { get; set; }
        public DateTime? ContractExpires { get; set; }
        public int TotalFamilyMembers { get; set; }
        public int? FlatId { get; set; }
        public Flat Flat { get; set; }
        public ICollection<Rent> Rent { get; set; }
        public ICollection<Bill> Bill { get; set; }
    }
}
