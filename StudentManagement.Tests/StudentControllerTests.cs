
using Xunit;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Controllers;

namespace StudentManagement.Tests;

public class StudentControllerTests
{
    [Fact]
    public void Info_ReturnsCorrectStudentData()
    {
        var controller = new StudentController();

        var result = controller.Info();

        var view = Assert.IsType<ViewResult>(result);

        Assert.Equal("CNTT", view.Model);
        Assert.Equal(20, controller.ViewData["Age"]);
        Assert.Equal("{Phạm Minh Đức}", 
                     (string)controller.ViewBag.Name);
    }
}
