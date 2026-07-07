using Moq;
using NUnit.Framework;

namespace MoqDemo;

[TestFixture]
public class Tests
{
    [Test]
    public void Register_ReturnsTrue_WhenEmailIsSent()
    {
        // Arrange
        var mock = new Mock<IEmailService>();

        mock.Setup(x => x.SendEmail(It.IsAny<string>()))
            .Returns(true);

        var service = new OrderService(mock.Object);

        // Act
        bool result = service.Register("rahul@gmail.com");

        // Assert
        Assert.That(result, Is.True);

        mock.Verify(x => x.SendEmail("rahul@gmail.com"), Times.Once());
    }

    [Test]
    public void Register_ReturnsFalse_WhenEmailThrowsException()
    {
        // Arrange
        var mock = new Mock<IEmailService>();

        mock.Setup(x => x.SendEmail(It.IsAny<string>()))
            .Throws(new Exception("Email Server Down"));

        var service = new OrderService(mock.Object);

        // Act
        bool result = service.Register("rahul@gmail.com");

        // Assert
        Assert.That(result, Is.False);

        mock.Verify(x => x.SendEmail("rahul@gmail.com"), Times.Once());
    }

    [Test]
    public void Register_CalledExactlyOnce()
    {
        // Arrange
        var mock = new Mock<IEmailService>();

        mock.Setup(x => x.SendEmail(It.IsAny<string>()))
            .Returns(true);

        var service = new OrderService(mock.Object);

        // Act
        service.Register("rahul@gmail.com");

        // Verify

        mock.Verify(x => x.SendEmail(It.IsAny<string>()), Times.Once());
    }
}