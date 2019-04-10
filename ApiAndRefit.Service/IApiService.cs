using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAndRefit.Service.Model;
using Refit;

namespace ApiAndRefit.Service
{
    [Headers("User-Agent: Refit Demo App")]
    public interface IApiService 
    {
        /// <summary>
        /// Calls GitHub API's RenderAsMarkdown endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Post("/markdown")]
        Task<string> RenderAsMarkdownAsync([Body] RenderRequest request);
    }    
}
