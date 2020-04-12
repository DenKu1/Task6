using AutoMapper;
using System.Collections.Generic;
using Task6.BLL.DTO;
using Task6.BLL.Interfaces;
using Task6.DAL.Entities;
using Task6.DAL.Interfaces;

namespace Task6.BLL.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IMapper _mp;
        protected readonly IUnitOfWork _db;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db = unitOfWork;
            _mp = mapper;
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            IEnumerable<Order> orders = _db.Orders.GetAll();

            return _mp.Map<IEnumerable<OrderDTO>>(orders);
        }
        public OrderDTO GetById(int id)
        {
            Order order = _db.Orders.Get(id);

            return _mp.Map<OrderDTO>(order);
        }

        public void Create()
        {
            _db.Orders.Add(new Order());
            _db.Save();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
      
    }
}
