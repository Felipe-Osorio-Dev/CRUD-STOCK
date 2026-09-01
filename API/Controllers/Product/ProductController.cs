using API.DTO.Requests;
using API.DTO.Responses;
using API.Services.Product;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers.Product
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProductsAsync()
        {
            var list = await _productService.GetAllProductsAsync();

            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterProductAsync([FromBody] RegisterProductDTO productDto)
        {
            var result = await _productService.RegisterProductAsync(productDto);

            if(!result.IsSuccess)
            {
                return Conflict(result.MessageError);
            }

            return CreatedAtAction(
                nameof(GetProductById),
                new { id = result.Data.Id},
                result.Data
                );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(long id)
        {
            var result = await _productService.GetProductByIdAsync(id);

            if(!result.IsSuccess)
            {
                return NotFound(result.MessageError);
            }

            return result.Data;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdateProductAsync(long id, [FromBody] UpdateProductDTO productDto)
        {
            var result = await _productService.UpdateProductByIdAsync(id, productDto);

            if(!result.IsSuccess)
            {
                return NotFound(result.MessageError);
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductByIdAsync(long id)
        {
            var result = await _productService.DeleteProductByIdAsync(id);

            if(!result.IsSuccess)
            {
                return NotFound(result.MessageError);
            }

            return NoContent();
        }
    }
}
