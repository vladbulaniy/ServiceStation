using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Bootstrapper
{
    public class ServiceProviderFactory
    {
        public static IAppServiceLocator CreateServiceProvider()
        {
            IUnityContainer container = new UnityContainer();
            UnityConfig.RegisterTypes(container);
            return new ServiceProvider(container);
        }
    }
}
