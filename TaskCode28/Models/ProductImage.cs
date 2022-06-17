namespace TaskCode28.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public Product MyProperty { get; set; }
    }
}
