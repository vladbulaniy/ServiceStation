using Bootstrapper;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceStation.Controllers
{
    public class BaseController : ApiController
    {
        protected IAppServiceLocator AppServiceLocator { get; }
        public BaseController()
        {
            AppServiceLocator = ServiceProviderFactory.CreateServiceProvider();
        }
    }
}
