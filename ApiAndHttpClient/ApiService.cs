using ApiAndHttpClient.Service.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiAndHttpClient.Service
{
    public class ApiService
    {      
        public static async Task<string> CallWebAPIAsync()
        {           
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://api.github.com");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

                RenderRequest renderRequest = new RenderRequest
                {
                    Text = "Hello **world**, this is sample markdown [with a URL](http://www.somewhere.com)",
                    Mode = "markdown"
                };

                var result = await httpClient.PostAsJsonAsync("markdown", renderRequest);
                var finalResult = await result.Content.ReadAsStringAsync();
                return finalResult;                
            }
        }       
       
    }
}
