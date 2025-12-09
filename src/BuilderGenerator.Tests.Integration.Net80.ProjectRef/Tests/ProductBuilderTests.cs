using BuilderGenerator.Tests.Integration.Net80.ProjectRef.Builders;
using NUnit.Framework;
using Shouldly;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Tests;

[TestFixture]
public class ProductBuilderTests
{
    [Test]
    public void Should_Build_Product_With_Constructor_Parameters()
    {
        // Arrange & Act
        var product = ProductBuilder.Simple().Build();

        // Assert
        product.ShouldNotBeNull();
        product.Name.ShouldBe("Test Product");
        product.Price.ShouldBe(99.99m);
        product.Description.ShouldBeNull();
        product.StockQuantity.ShouldBe(0);
    }

    [Test]
    public void Should_Build_Product_With_All_Properties()
    {
        // Arrange & Act
        var product = ProductBuilder.WithFullDetails().Build();

        // Assert
        product.ShouldNotBeNull();
        product.Name.ShouldBe("Test Product");
        product.Price.ShouldBe(99.99m);
        product.Description.ShouldBe("A test product with full details");
        product.StockQuantity.ShouldBe(100);
    }

    [Test]
    public void Should_Override_Constructor_Parameters()
    {
        // Arrange & Act
        var product = ProductBuilder.Simple()
            .WithName("Custom Name")
            .WithPrice(49.99m)
            .Build();

        // Assert
        product.Name.ShouldBe("Custom Name");
        product.Price.ShouldBe(49.99m);
    }

    [Test]
    public void Should_Set_Non_Constructor_Properties()
    {
        // Arrange & Act
        var product = ProductBuilder.Simple()
            .WithDescription("Custom Description")
            .WithStockQuantity(50)
            .Build();

        // Assert
        product.Description.ShouldBe("Custom Description");
        product.StockQuantity.ShouldBe(50);
    }
}
