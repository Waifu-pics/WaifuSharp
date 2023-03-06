using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaifuSharp.Models;
using WaifuSharp.Models.Enums;

namespace WaifuSharp.Tests;

[TestClass]
public class WaifuSharpTests
{
    [TestMethod]
    public void GetSfwImageAsync_CategoryGiven_ReturnImage()
    {
        // Arrange
        var client = new WaifuClient();

        // Act
        var result = client.GetSfwImageAsync(SfwCategory.Neko).Result;

        // Assert
        result.ImageUrl.Should().NotBeNull();
    }

    [TestMethod]
    public void GetNsfwImageAsync_CategoryGiven_ReturnImage()
    {
        // Arrange
        var client = new WaifuClient();

        // Act
        var result = client.GetNsfwImageAsync(NsfwCategory.Neko).Result;

        // Assert
        result.ImageUrl.Should().NotBeNull();
    }

    [TestMethod]
    public void GetManySfwImageAsync_CategoryGiven_ReturnImage()
    {
        // Arrange
        var client = new WaifuClient();
        var settings = new WaifuClientSettings()
        {
            Filters = new string[0]
        };

        // Act
        var result = client.GetManySfwImageAsync(SfwCategory.Neko, settings).Result;

        // Assert
        result.Images.Length.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void GetManyNsfwImageAsync_CategoryGiven_ReturnImage()
    {
        // Arrange
        var client = new WaifuClient();
        var settings = new WaifuClientSettings()
        {
            Filters = new string[0]
        };

        // Act
        var result = client.GetManyNsfwImageAsync(NsfwCategory.Neko, settings).Result;

        // Assert
        result.Images.Length.Should().BeGreaterThan(0);
    }
}