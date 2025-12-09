using BuilderGenerator.Tests.Integration.Net80.ProjectRef.Builders;
using NUnit.Framework;
using Shouldly;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Tests;

[TestFixture]
public class ProductWithReadOnlyPropsBuilderTests
{
    [Test]
    public void Should_Build_Product_With_ReadOnly_Constructor_Parameters()
    {
        // Arrange & Act
        var product = ProductWithReadOnlyPropsBuilder.Simple().Build();

        // Assert
        product.ShouldNotBeNull();
        product.Name.ShouldBe("Test Product");
        product.Price.ShouldBe(99.99m);
    }

    [Test]
    public void Should_Allow_WithName_For_ReadOnly_Property()
    {
        // Arrange & Act
        var product = ProductWithReadOnlyPropsBuilder.Simple()
            .WithName("Custom Name")
            .Build();

        // Assert
        product.Name.ShouldBe("Custom Name");
    }

    [Test]
    public void Should_Allow_WithPrice_For_PrivateSetter_Property()
    {
        // Arrange & Act
        var product = ProductWithReadOnlyPropsBuilder.Simple()
            .WithPrice(49.99m)
            .Build();

        // Assert
        product.Price.ShouldBe(49.99m);
    }

    [Test]
    public void Should_Set_InitOnly_Properties()
    {
        // Arrange & Act
        var product = ProductWithReadOnlyPropsBuilder.Simple()
            .WithDescription("Custom Description")
            .WithStockQuantity(50)
            .Build();

        // Assert
        product.Description.ShouldBe("Custom Description");
        product.StockQuantity.ShouldBe(50);
    }
}
