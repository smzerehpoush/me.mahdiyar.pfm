using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace me.mahdiyar.pfm.Pages
{
    public class Index_Tests : pfmWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
