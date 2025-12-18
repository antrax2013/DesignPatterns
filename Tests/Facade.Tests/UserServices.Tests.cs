using Facade.API;

namespace Facade.Tests;

public class FacadeTests
{
    [Test]
    public void GetUser_Should_ReturnsExpectedUserWithOnePetAndOneVehicle()
    {
        // Arrange
        int id = 1;
        IUserServices userServices = new UserServices();

        // Act
        var user = userServices.GetUser(id).Result;

        // Assert
        Assert.That(user, Is.Not.Null);
        using (Assert.EnterMultipleScope())
        {
            Assert.That(user, Has.Property("Id").EqualTo(1));
            Assert.That(user.Pets, Has.Count.EqualTo(1));
            Assert.That(user.Vehicles, Has.Count.EqualTo(1));
        }
    }
}
