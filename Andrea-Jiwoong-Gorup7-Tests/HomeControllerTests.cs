using Andrea_Jiwoong_Group7.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace Andrea_Jiwoong_Gorup7_Tests;

public class HomeControllerTests
{
    public HomeController sut;
    public Mock<ILogger<HomeController>> logger;

    public HomeControllerTests()
    {
        logger = new Mock<ILogger<HomeController>>();
        sut = new HomeController(logger.Object);
    }

    [Fact]
    public void Index_ReturnsView()
    {
        // Arrange + Act
        var result = sut.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
        Assert.NotNull(result);
    }

    [Fact]
    public void BookTicket_ReturnsView()
    {
        // Arrange + Act
        var result = sut.BookTicket();

        // Assert
        Assert.IsType<ViewResult>(result);
        Assert.NotNull(result);
    }

    [Fact]
    public void PostBookTicekt_ReturnsView()
    {
        // Arrange
        string dept = "Toronto";
        string arrv = "Vancouver";
        string seatClass = "Business";
        string seatBerth = "Corner";
        string holderName = "John Doe";
        string email = "fake@email.ca";
        int age = 20;
        DateTime departDate = DateTime.Now;
        int noOfPassengers = 1;

        // Arrange
        var result = sut.PostBookTicket(dept, arrv, seatClass, seatBerth, holderName, email, age, departDate, noOfPassengers);

        // Assert
        Assert.IsType<ViewResult>(result);
        Assert.NotNull(result);
    }
}
