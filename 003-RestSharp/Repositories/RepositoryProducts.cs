using _003_RestSharp.Models;
using RestSharp;
namespace _003_RestSharp.Repositories
{

    public interface IRepositoryProducts
    {
        Task<Product> Delete(int id);
        Task<List<Product>> GetAllProducts();
        Task<Product> GetByID(int id);
        Task<Product> PostProduct(Product product);
    }
    public class RepositoryProducts : IRepositoryProducts
    {
       public async Task<List<Product>> GetAllProducts()
        {
           var client = new RestClient("https://localhost:7207/v1/product");
            var request = new RestRequest();
            var response = await client.GetAsync<List<Product>>(request);
            return response;          
        }

        public async Task<Product> GetByID(int id)
        {
            var client = new RestClient("https://localhost:7207/v1/product");
            var request = new RestRequest($"{id}",Method.Get);             
            var response = await client.GetAsync<Product>(request);
            return response;
        }


       public async Task<Product> PostProduct(Product product)
        {
            var client = new RestClient("https://localhost:7207/v1/product");
            var request = new RestRequest();
            request.AddBody(product);
            var response = await client.PostAsync<Product>(request);            
            return  response;
           
        }
        public async Task<Product> Delete(int id)
        {
            var client = new RestClient("https://localhost:7207/v1/product");
            var request = new RestRequest($"{id}",Method.Delete);
            var response = await client.DeleteAsync<Product>(request);
            return response;
        }
    }
    
}
