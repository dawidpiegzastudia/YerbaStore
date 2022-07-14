using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaFrontEnd.Models;

namespace YerbaFrontEnd.Serivces.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
