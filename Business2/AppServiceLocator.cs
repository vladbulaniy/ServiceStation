using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AppServiceLocator : IAppServiceLocator
    {
        public T GetService<T>()
        {
            throw new NotImplementedException();
        }
    }
}
