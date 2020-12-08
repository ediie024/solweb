using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace SimulacionPokerTest.PruebasUnitarias
{
    public class AlgoritmoTest
    {
        
        [Test]
        public void IndexRetrunView()
        {
            var CookieAuthService = new Mock<ICartaService>();
           
            
            
            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}