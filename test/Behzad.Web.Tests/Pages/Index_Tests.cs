using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Behzad.Pages;

public class Index_Tests : BehzadWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
