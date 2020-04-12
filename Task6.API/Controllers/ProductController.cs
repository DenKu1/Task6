using AutoMapper;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Task6.API.Models;
using Task6.BLL.DTO;
using Task6.BLL.Interfaces;

namespace Task6.API.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;      
        private readonly IMapper _mp;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _productService = productService;          
            _mp = mapper;
        }

        [HttpGet]
        [Route("api/products")]
        public IEnumerable<ProductModel> GetProducts()
        {
            return _mp.Map<IEnumerable<ProductModel>>(_productService.GetAll());
        }

        [HttpPost]
        [Route("api/products")]
        public IHttpActionResult PostProduct([ModelBinder]ProductModel product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _productService.Create(_mp.Map<ProductDTO>(product));
            return Ok();
          
        }

        [HttpGet]
        [Route("api/orders/{id}/products")]
        public IEnumerable<ProductModel> GetProductsByOrder(int id)
        {
            return _mp.Map<IEnumerable<ProductModel>>(_productService.GetAllByOrderId(id));
        }

        [HttpPut]
        [Route("api/orders/{id}/products")]
        public void PutProductsByOrder([FromUri]int id, [ModelBinder]ProductModel product)
        {
            _productService.AddToOrder(_mp.Map<ProductDTO>(product), id);
        }
    }
}
