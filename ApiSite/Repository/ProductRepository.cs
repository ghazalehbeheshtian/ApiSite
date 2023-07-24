using ApiSite.Contexts;
using ApiSite.Models.Dtos;
using ApiSite.Models.Entities;
using Azure;
using Microsoft.EntityFrameworkCore;

namespace ApiSite.Repository
{
    public class ProductRepository
    {
        public readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }




        //GetAll
        public async Task<IEnumerable<ProductEntity>>GetAllAsync()
        {
            var result= await _context.Products.ToListAsync();
            var products = new List<ProductEntity>();
            foreach (var product in result)
            {
                products.Add(product);
            }
            return products;
        }



        //GetById // GetByArtikelnummber //
        public async Task<IEnumerable<ProductResponse>> GetByIdAsync(int id)
        {
           var result= await _context.Products.Where(x => x.Id==id).ToListAsync();
            var products = new List<ProductResponse>();
            foreach (var item in result)
            {
                products.Add(item);
            }
            return products;
        }


        //Get

        public async Task<ProductResponse>GetAsync()
        {
           var result = await _context.Products.FindAsync();
            return result;

        }


          //Creat

        public async Task<ProductResponse>CreatAsync(ProductEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
           
        }


         //Get By Tag

        public async Task<IEnumerable<ProductResponse>>GetByTagAsync(string tag)
        {
            var result= await _context.Products.Where(x =>x.Tag==tag).ToListAsync();    
            var products = new List<ProductResponse>();
            foreach(var item in result)
                products.Add(item);
            return products;
        }
    }
}
