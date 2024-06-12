using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tangy_Business.Repository.IRepository;
using Tangy_Models;

namespace Tangy_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _productRepository.GetAll());
        }
        [HttpGet("{ProductId}")]
        public async Task<ActionResult> Get(int? ProductId)
        {
            if (ProductId == null || ProductId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invaled Id",
                    StatusCode = StatusCodes.Status400BadRequest

                });
            }
            var product = _productRepository.Get(ProductId.Value);
            if (product == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invaled Id",
                    StatusCode = StatusCodes.Status404NotFound

                });
            }
            return Ok(product);
        }
    }
}
