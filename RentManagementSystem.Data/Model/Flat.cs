namespace RentManagementSystem.Data
{
    //==========================================>  ONE TO MANY RELATIONSHIP BETWEEN PROPERTY AND FLAT CLASSES 'A property can have one or many flats'
    public class Flat //student 
    {
        public int FlatId { get; set; }
        public string FlatAddress { get; set; }
        public int PropertyId { get; set; }
        //  public virtual Property Property { get; set; }
        //  public int TenantId { get; set; }
        // public virtual Tenant Tenant { get; set; }
    }
}
