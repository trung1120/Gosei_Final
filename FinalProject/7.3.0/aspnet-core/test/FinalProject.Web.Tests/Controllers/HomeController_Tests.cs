using System.Threading.Tasks;
using FinalProject.Models.TokenAuth;
using FinalProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace FinalProject.Web.Tests.Controllers
{
    public class HomeController_Tests: FinalProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}