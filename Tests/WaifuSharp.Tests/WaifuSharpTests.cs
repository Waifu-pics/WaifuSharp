using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using WaifuSharp.Models.Enums;
using Xunit;

namespace WaifuSharp.Tests
{
    public class WaifuSharpTests
    {
        [Theory]
        [MemberData(nameof(EnumValues), typeof(SfwCategory))]
        public async Task GetSfwImageAsync_CategoryGiven_ReturnImage(SfwCategory category)
        {
            // Arrange
            var client = new WaifuClient();

            // Act
            var result = await client.GetSfwImageAsync(category);

            // Assert
            result.ImageUrl.Should().NotBeNull();
        }

        [Theory]
        [MemberData(nameof(EnumValues), typeof(NsfwCategory))]
        public async Task GetNsfwImageAsync_CategoryGiven_ReturnImage(NsfwCategory category)
        {
            // Arrange
            var client = new WaifuClient();

            // Act
            var result = await client.GetNsfwImageAsync(category);

            // Assert
            result.ImageUrl.Should().NotBeNull();
        }


        public static IEnumerable<object[]> EnumValues(object enumToTest)
        {
            foreach (var thing in Enum.GetValues(enumToTest as Type ?? typeof(SfwCategory))) yield return new[] {thing};
        }
    }
}