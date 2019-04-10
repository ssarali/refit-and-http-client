using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAndRefit.Service
{
    public class ApiServiceFactory : IApiServiceFactory
    {
        public IApiService GetApiService(string ServiceUrl)
        {
            return RestService.For<IApiService>(ServiceUrl);
        }
    }
}
