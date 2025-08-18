using UerApp;
using UerApp.Models;
using UerApp.Services;

namespace EMR.Test
{
    public class UserRepositoryAPITest
    {
        
        [Fact]
        public void Add_WhenIdIsUniqe_UserShouldAdded()
        {
            // Arrang
            var context = new InMemoryDbContect();
            var sut = new UserRepositoryAPI(context);

            // Act
            var user = new UserAPI()
            {
                Name= "Test",
                Email="Test@gmail.com",
                Password="12345"
            };
            sut.AddUser(user);

            // Asset
            Assert.True(user.Id > 0);
        }
    }
}
