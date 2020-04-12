using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Task6.API.Models;
using Task6.BLL.DTO;
using Task6.BLL.Interfaces;


namespace Task6.API.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mp;

        public OrderController(IMapper mapper, IOrderService orderService)
        {
            _orderService = orderService;
            _mp = mapper;
        }

        [HttpGet]
        [Route("api/orders")]
        public IEnumerable<OrderModel> GetProducts()
        {
            return _mp.Map<IEnumerable<OrderModel>>(_orderService.GetAll());
        }

        [HttpPost]
        [Route("api/orders")]
        public IHttpActionResult PostProduct()
        {
            _orderService.Create();

            return Ok();
        }

        [HttpGet]
        [Route("api/orders/{id}")]
        public IHttpActionResult GetProducts(int id)
        {
            var order = _mp.Map<OrderModel>(_orderService.GetById(id));

            return order == null ? BadRequest() : (IHttpActionResult)Ok(order);
        }
    }
}
