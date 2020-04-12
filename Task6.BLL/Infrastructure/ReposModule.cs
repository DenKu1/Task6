using Ninject.Modules;
using Ninject.Web.Common;
using Task6.DAL.Interfaces;
using Task6.DAL.Repositories;

namespace Task6.BLL.Infrastructure
{
    public class ReposModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
