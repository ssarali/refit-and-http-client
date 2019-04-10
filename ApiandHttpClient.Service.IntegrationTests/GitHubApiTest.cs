using ApiAndHttpClient.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ApiandHttpClient.Service.IntegrationTests
{
    [TestClass]
    public class GitHubApiTest
    {
        [TestMethod]
        public async Task CallWebAPIAsyncTest()
        {

            // Act
            var response = await ApiService.CallWebAPIAsync();

            // Assert
            Assert.IsNotNull(response);
        }
    }
}
