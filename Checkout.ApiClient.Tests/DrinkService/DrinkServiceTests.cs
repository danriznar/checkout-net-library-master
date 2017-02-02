using System;
using System.Net;
using Checkout.ApiServices.Drinks.RequestModels;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture(Category = "DrinksApi")]
    public class DrinksApiTests : BaseServiceTests
    {
        [Test]
        public void GetDrink()
        {
            var response = CheckoutClient.DrinkService.GetDrink("drink_1");

            //response.Should().NotBeNull();
            //response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            //response.Model.Id.Should().Be("drink_1");
            //response.Model.Id.Should().StartWith("cust_");
            //drink.ShouldBeEquivalentTo(response.Model);
        }
    }
}
