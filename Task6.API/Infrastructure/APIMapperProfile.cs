using AutoMapper;

namespace Task6.API.Infrastructure
{
    public class APIMapperProfile : Profile
    {
        public APIMapperProfile()
        {
            CreateMap<BLL.DTO.ProductDTO, API.Models.ProductModel>();
            CreateMap<BLL.DTO.OrderDTO, Models.OrderModel>();
      
            CreateMap<API.Models.ProductModel, BLL.DTO.ProductDTO>();
            CreateMap<API.Models.OrderModel, BLL.DTO.OrderDTO>();
        }
    }
}