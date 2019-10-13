using HAClusterManager;
using HAClusterManager.Controllers;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
  public class ResourceControllerTests
  {
    private IClusterManager mocClusterManager;
    private ResourcesController resourceControler;

    [SetUp]
    public void Setup()
    {
       mocClusterManager = Substitute.For<IClusterManager>();
       resourceControler = new ResourcesController(mocClusterManager);

    }

    [Test]
    public void GetResourcesReturnAnInstanceOfIEnumerableResource()
    {
        //Act
        var result = resourceControler.GetResources();

        //Assert
        Assert.IsInstanceOf<IEnumerable<Resource>>(result);
    }

    [Test]
    public void CreateResourceWhenNoClusterConnectionsShouldReturnNotFoundState()
    {
      //Arange
      var resource = new Resource();
        
      //Act
      var result = resourceControler.CreateResource(resource);

      //Assert
      Assert.IsInstanceOf(typeof(NotFoundResult), result);
    }

    [Test]
    public void CreateNullResourceShouldReturnBadRequestState()
    {
      //Arange
      Resource resource = null;

      //Act
      var result = resourceControler.CreateResource(resource);

      //Assert
      Assert.IsInstanceOf(typeof(BadRequestResult), result);
    }
  }
}
