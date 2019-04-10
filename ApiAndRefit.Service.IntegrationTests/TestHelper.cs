using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAndRefit.Service.IntegrationTests
{
    public class TestHelper
    {
        public const string ServiceUrl = "https://api.github.com";

        public static IApiService GetService()
        {
            var serviceFactory = new ApiServiceFactory();

            return serviceFactory.GetApiService(ServiceUrl);
        }
    }
}
