using Task6.BLL.Interfaces;
using Task6.BLL.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Task6.API.Infrastructure
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
            Bind<IOrderService>().To<OrderService>();
        }
    }
}