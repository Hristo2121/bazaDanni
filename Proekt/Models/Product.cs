namespace Proekt.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }// m:1
        public Brand Brands { get; set; }//m:1
        public int CategoryId { get; set; } //m:1
        public Category Categories { get; set; }//m:1
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price {  get; set; }
        public DateTime DateRegister {  get; set; }
        public ICollection<Order> Orders { get; set; } //1:m
    }
}
