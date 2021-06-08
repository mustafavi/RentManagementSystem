using System;

namespace RentManagementSystem.Data
{
    public class Bill
    {
        public int BillId { get; set; }
        public string Description { get; set; }
        public DateTime? BillDueDate { get; set; }
        public DateTime? BillPaidDate { get; set; }
        public Char BillType { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
