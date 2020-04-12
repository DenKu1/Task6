using System;
using System.Collections.Generic;
using Task6.BLL.DTO;

namespace Task6.BLL.Interfaces
{
    public interface IProductService : IDisposable
    {
        void Create(ProductDTO item);
        IEnumerable<ProductDTO> GetAll();
        IEnumerable<ProductDTO> GetAllByOrderId(int id);
        void AddToOrder(ProductDTO item, int orderId);
    }
}
