using System.Threading.Tasks;
using HRManager.Web.Controllers;
using Shouldly;
using Xunit;

namespace HRManager.Web.Tests.Controllers
{
    public class HomeController_Tests: HRManagerWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
