using Autofac;
using B2B.Backend.Core.Repositories;
using B2B.Backend.Core.Services;
using B2B.Backend.Core.UnitOfWorks;
using B2B.Backend.Repository.Contexts;
using B2B.Backend.Repository.Repositories;
using B2B.Backend.Repository.UnitOfWorks;
using B2B.Backend.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace B2B.Backend.API.Modules
{
    public class AutofacRepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<IUnitOfWork>().As<UnitOfWork>();

            var apiAssembly = Assembly.GetEntryAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(B2BDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(Service<>));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
