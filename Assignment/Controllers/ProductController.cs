using Assignment.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }





        // ++++++++++++ GET : api/Product
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await this._unitOfWork.productRepository.GetAllEntity();
            return Ok(products);
        }





        // ++++++++++++ GET : api/Product/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await this._unitOfWork.productRepository.GetEntity(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }





        // ++++++++++++ POST : api/Product
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var result = await this._unitOfWork.productRepository.AddEntity(product);
            if (result)
            {
                await this._unitOfWork.CompleteAsync();
                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
            }
            return BadRequest();
        }



        // ++++++++++++ PUT : api/Product/{id}
        [HttpPut]
        public async Task<IActionResult> UpdateSingleProduct(Product product)
        {
            var result = await this._unitOfWork.productRepository.UpdateEntity(product);
            if (result)
            {
                await this._unitOfWork.CompleteAsync();
                return Ok();
            }
            else return BadRequest();
        }





        // ++++++++++++ DELETE : api/Product/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await this._unitOfWork.productRepository.DeleteEntity(id);
            if (result)
            {
                await this._unitOfWork.CompleteAsync();
                return Ok();
            }
            return BadRequest();
        }


        
    }
}
