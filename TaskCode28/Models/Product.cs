using System.Collections.Generic;

namespace TaskCode28.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
