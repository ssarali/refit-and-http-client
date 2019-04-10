using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAndRefit.Service
{
    public interface IApiServiceFactory
    {
        /// <summary>
        /// Gets an instance of the Api Service
        /// </summary>
        /// <returns></returns>
        IApiService GetApiService(string ServiceUrl);
    }
}
