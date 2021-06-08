using System;

namespace RentManagementSystem.Data
{
    public class Rent
    {
        public int RentId { get; set; }
        public decimal AdvancePaid { get; set; }
        public DateTime RentDue { get; set; }
        public DateTime RentPaid { get; set; }
        public decimal RentBalance { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
