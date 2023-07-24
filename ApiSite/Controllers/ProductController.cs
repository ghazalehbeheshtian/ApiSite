using ApiSite.Models.Dtos;
using ApiSite.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ProductRepository _productRepository;


        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }







        [Route("Product/Name")]
        [HttpGet]

        public async Task<IActionResult>GetAll()
        {
            var result= await _productRepository.GetAllAsync();
            return Ok(result);
        }




        [Route("product/id")]
        [HttpGet]

        public async Task<IActionResult>GetById(int id)
        {
            var result= await _productRepository.GetByIdAsync(id);
            return Ok(result);  
        }


        [Route("Product/Tag")]
        [HttpGet]

        public async Task<IActionResult>GetByTag(string tag)
        {
            var result= await _productRepository.GetByTagAsync(tag);
            return Ok(result);

        }


        [Route("Product/All")]
        [HttpGet]

        public async Task<IActionResult>GetAllProduct()
        {
            var result= await _productRepository.GetAllAsync();
            return Ok(result);
        }

        [Route("Product/Create")]
        [HttpPost]

        public async Task<IActionResult>Create(ProductRequest request)
        {
            if(ModelState.IsValid)
            {
                return Ok();
                    

            }
            return BadRequest();
        }

    }
}
