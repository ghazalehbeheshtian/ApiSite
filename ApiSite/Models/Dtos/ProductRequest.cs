using ApiSite.Models.Entities;

namespace ApiSite.Models.Dtos
{
    public class ProductRequest
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; }=null!;

        public decimal Price { get; set; }


       public static implicit operator ProductEntity(ProductRequest productRequest)
        {
            return new ProductEntity
            {
                Name = productRequest.Name,
                Description = productRequest.Description,
                Price = productRequest.Price,

            };
        }
    }
}
