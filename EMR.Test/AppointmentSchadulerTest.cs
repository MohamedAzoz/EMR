﻿using EMR.Uer_App.Services;
using FakeItEasy;
using EMR.Uer_App.Models;
using Moq;

namespace EMR.Test
{
    public class AppointmentSchadulerTest
    {
        [Fact]
        public void Schaduler_WhenUserIsNotFound_AggregateExceptionThrowExcption()
        {
            // Arrange
            var fake=A.Fake<IUserRepository>();
            A.CallTo(()=>fake.GetById(A<int>.Ignored)).Returns(null);
            var sut = new AppointmentSchaduler(fake);

            //Act \ Asset  // Only When Reuslt give Any Type from Exception
            Assert.Throws<AggregateException>(() => sut.Schaduler(1));
           
            //Asset

        }

        [Fact]
        public void Schaduler_WhenUserIsFound_ReturnUser()
        {
            // Arrange
            #region Use By Fake 
            //var fake =A.Fake<IUserRepository>();
            //A.CallTo(()=>fake.GetById(A<int>.Ignored)).Returns(new User{ Id = 1,Name = "Ali",Email = "Ali@gmail.com",Password = "123456"});
            //var sut = new AppointmentSchaduler(fake);
            #endregion
            #region Use By Moq
            var moq = new Mock<IUserRepository>();
            var setup=moq.Setup(x=>x.GetById(It.IsAny<int>())).Returns(new User{ Id = 1,Name = "Ali",Email = "Ali@gmail.com",Password = "123456"});
            var sut = new AppointmentSchaduler(moq.Object);

            #endregion
            //Act 
            var reuslt =sut.Schaduler(1);
           
            //Asset
            Assert.True(reuslt.Id==1);
        }

        [Theory]
        [InlineData( 1, "Ali",  "Ali@gmail.com", "123456","Ali")]
        [InlineData( 2, "Ahmed", "Ahmed@gmail.com", "123456", "Ahmed")]
        [InlineData( 3, "Mahmoud", "Mahmoud@gmail.com", "123456", "Mahmoud")]
        [InlineData( 4, "Mohamed", "Mohamed@gmail.com", "123456", "Mohamed")]
        [InlineData( 5, "Omer", "Omer@gmail.com", "123456", "Omer")]
        public void Schaduler_WhenUserTestAll_ReternResult(int id ,string name,string email,string password,string extendUser)
        {
            // Arrange
            User user = new User { Id = id, Name = name, Email = email, Password = password };
            var fake = A.Fake<IUserRepository>();
            A.CallTo(() => fake.GetById(A<int>.Ignored)).Returns(user);
            var sut = new AppointmentSchaduler(fake);
            var reuslt = sut.Schaduler(id);

            //Act \ Asset  // Only When Reuslt give Any Type from Exception
            Assert.Equal(extendUser,reuslt.Name);

            //Asset

        }
    }
}
