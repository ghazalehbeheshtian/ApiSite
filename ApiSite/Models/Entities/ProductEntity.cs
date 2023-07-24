using ApiSite.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace ApiSite.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description{ get; set; }=null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; } 
        [Required]
        public string? Tag { get; set; } 


        public static implicit operator ProductResponse(ProductEntity entity)
        {
            return new ProductResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl,



            };
        }
    }
}
