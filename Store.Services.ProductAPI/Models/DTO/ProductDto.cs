using System.ComponentModel.DataAnnotations;

namespace Store.Services.ProductAPI.Models.DTO
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
