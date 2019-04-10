using ApiAndRefit.Service.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;
using System.Threading.Tasks; 

namespace ApiAndRefit.Service.IntegrationTests
{
    [TestClass]
    public class GitHubApiTest
    {
        private IApiService _apiService;

        [TestInitialize]
        public void Initialize()
        {
            _apiService = TestHelper.GetService();
        }

        [TestMethod]
        public async Task RenderAsMarkdownAsyncTest()
        {
            // Arrange
            var gitHubApi = _apiService;

            var input = new RenderRequest
            {
                Text = "Hello **world**, this is sample markdown [with a URL](http://www.somewhere.com)",
                Mode = "markdown"
            };

            // Act
            var response = await gitHubApi.RenderAsMarkdownAsync(input);

            // Assert
            Assert.IsNotNull(response);
        }
    }
}
