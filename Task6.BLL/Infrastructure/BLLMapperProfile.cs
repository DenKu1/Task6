using AutoMapper;

namespace Task6.BLL.Infrastructure
{
    public class BLLMapperProfile : Profile
    {
        public BLLMapperProfile()
        {
            CreateMap<BLL.DTO.OrderDTO, DAL.Entities.Order>();
            CreateMap<BLL.DTO.ProductDTO, DAL.Entities.Product>();          

            CreateMap<DAL.Entities.Order, BLL.DTO.OrderDTO>();
            CreateMap<DAL.Entities.Product, BLL.DTO.ProductDTO>();     
        }
    }
}