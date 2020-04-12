using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Task6.BLL.DTO;
using Task6.BLL.Interfaces;
using Task6.DAL.Entities;
using Task6.DAL.Interfaces;

namespace Task6.BLL.Services
{
    public class ProductService : IProductService
    {
        protected readonly IMapper _mp;
        protected readonly IUnitOfWork _db;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db = unitOfWork;
            _mp = mapper;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            IEnumerable<Product> products = _db.Products.GetAll();

            return _mp.Map<IEnumerable<ProductDTO>>(products);
        }

        public void Create(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return;
            }

            Product product = _mp.Map<Product>(productDTO);

            _db.Products.Add(product);
            _db.Save();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<ProductDTO> GetAllByOrderId(int id)
        {
            Order order = _db.Orders.Get(id);
            if (order == null)
            {
                return null;
            }

            IEnumerable<Product> products = order.Products;

            return _mp.Map<IEnumerable<ProductDTO>>(products);
        }

        public void AddToOrder(ProductDTO productDTO, int orderId)
        {
            if (productDTO == null)
            {
                return;
            }

            Order order = _db.Orders.Get(orderId);

            if (order == null)
            {
                return;
            }

            Product product = _mp.Map<Product>(productDTO);

            order.Products.Add(product);

            //_db.Products.Add(product);
            _db.Save();
        }
    }
}
