using APP.Dtos.Requests;
using APP.Dtos.Responses;
using APP.Util.Result;
using System.Net.Http.Json;

namespace APP.Services.Api.Product
{
    internal class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result<List<ProductDTO>>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("");

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadFromJsonAsync<ApiErrorDTO>();
                return Result<List<ProductDTO>>.Failure(errorMessage?.message ?? "Requisição falhou");
            }

            var data = await response.Content.ReadFromJsonAsync<List<ProductDTO>>();

            if (data == null)
            {
                return Result<List<ProductDTO>>.Failure("Falha ao receber a resposta da API");
            }

            return Result<List<ProductDTO>>.Success(data);
        }

        public async Task<Result<CreatedProductDTO>> RegisterProductAsync(RegisterProductDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync("", dto);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadFromJsonAsync<ApiErrorDTO>();
                return Result<CreatedProductDTO>.Failure(errorMessage?.message ?? "Requisição falhou");
            }

            var data = await response.Content.ReadFromJsonAsync<CreatedProductDTO>();

            if (data == null)
            {
                return Result<CreatedProductDTO>.Failure("Falha ao receber a resposta da API");
            }

            return Result<CreatedProductDTO>.Success(data);
        }
    }
}
