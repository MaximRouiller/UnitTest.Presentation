using System.Collections.Generic;
using System;
using NUnit.Framework;
using UnitTest.Presentation.Demo1;

namespace UnitTest.Presentation.Tests.Demo1
{
    [TestFixture]
    public class Service_Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void WhenACustomerExistItShouldReturnTrue()
        {
            // arrange
            var service = new Service(new CustomerRepository("Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;"));

            // act
            var exist = service.CustomerExistById(1);

            // assert
            Assert.That(exist, Is.True);
            //Assert.IsTrue(exist);
            //Assert.AreEqual(true, exist);
        }
    }
}