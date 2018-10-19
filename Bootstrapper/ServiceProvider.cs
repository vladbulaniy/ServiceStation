using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Bootstrapper
{
    public class ServiceProvider : IAppServiceLocator
    {
        private readonly IUnityContainer _container = null;

        public ServiceProvider (IUnityContainer unityContainer)
        {
            this._container = unityContainer;            
        }

        public T GetService<T>()
        {
            return this._container.Resolve<T>();
        }
    }
}
