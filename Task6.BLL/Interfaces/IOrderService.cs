using System.Collections.Generic;
using Task6.BLL.DTO;

namespace Task6.BLL.Interfaces
{
    public interface IOrderService
    {
        void Create();
        IEnumerable<OrderDTO> GetAll();
        OrderDTO GetById(int id);
    }
}
