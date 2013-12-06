using System;
using FlitBit.IoC.Web.Common.IoC;

namespace FlitBit.IoC.Owin
{
    public class FlitBitServiceProvider : IServiceProvider
    {
        IContainer _container;
        public IScopedDependencyResolverManager DependencyResolver { get; set; }
        public FlitBitServiceProvider(IContainer container)
        {
            _container = container;
            DependencyResolver = Create.New<IScopedDependencyResolverManager>();
        }

        public object GetService(Type serviceType)
        {
            return DependencyResolver.GetService(_container, serviceType);
        }
    }
}