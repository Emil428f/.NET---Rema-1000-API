namespace Rema1000___Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Unit { get; set; }
        public int AmountInPackage { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }
        public int AmountInStorage { get; set; }
        public Supplier Supplier { get; set; }
    }
}
