using API.DTO.Requests;
using API.DTO.Responses;
using API.Models.Product;
using API.Repositorys.Product;
using API.Util.Result;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var listProducts = await _repository.GetAllProductsAsync();

            return _mapper.Map<IEnumerable<ProductDTO>>(listProducts);
        }

        public async Task<Result<ProductDTO>> GetProductByIdAsync(long id)
        {
            var model = await _repository.GetProductByIdAsync(id);

            if(model == null)
            {
                return Result<ProductDTO>.Failure("Produto não Encontrado/Não Cadastrado!!");
            }

            var response = _mapper.Map<ProductDTO>(model);

            return Result<ProductDTO>.Success(response);
        }

        public async Task<Result<CreatedProductDTO>> RegisterProductAsync(RegisterProductDTO productDTO)
        {
            try
            {
                var model = _mapper.Map<ProductModel>(productDTO);

                await _repository.RegisterProductAsync(model);

                var response = _mapper.Map<CreatedProductDTO>(model);

                return Result<CreatedProductDTO>.Success(response);
            }
            catch(DbUpdateException)
            {
                return Result<CreatedProductDTO>.Failure("Erro ao Registrar o Produto. O Produto ja Esta Cadastrado!!");
            }
        }
    }
}
