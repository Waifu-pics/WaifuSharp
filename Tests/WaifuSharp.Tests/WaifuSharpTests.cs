using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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


    public static IEnumerable<object[]> EnumValues(object enumToTest)
    {
        foreach (var thing in Enum.GetValues(enumToTest as Type ?? typeof(SfwCategory))) yield return new[] { thing };
    }
}