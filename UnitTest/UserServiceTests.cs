using Service;

namespace UnitTest
{
    public class UserServiceTests
    {
        private UserService _service;

        [SetUp]
        public void Setup()
        {
            _service = new UserService();
        }

        [Test]
        public void TestGetAllUser()
        {
            var users = _service.GetAll();

            Assert.IsNotEmpty(users);
        }
    }
}