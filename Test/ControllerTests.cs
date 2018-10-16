using System;
using S10E2.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Test 
{
    public class ControllerTests 
    {
        [Fact]
        public void VerifyIndexType() 
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
