using BlazorPortoBus.Data;
using BlazorPortoBus.Pages;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlazorPortoBusTests
{
    public class UnitTest1
    {

        [Fact]
        public void ComponentRendersCorrectly()
        {
            // Arrange
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<BusHourService>();
            // Act
            var cut = ctx.RenderComponent<Index>();
            var title = cut.Find("#title");
            // Assert

            title.MarkupMatches(@"<div id=""title"" class=""col""> Input the bus station code and get the bus names and times when the bus is coming</div>");  
        }
    }
}