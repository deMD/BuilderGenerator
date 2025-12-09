using BuilderGenerator.Tests.Integration.Net80.ProjectRef.Models.Entities;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Builders;

/// <summary>Builder for Product with constructor parameters.</summary>
[BuilderFor(typeof(Product))]
public partial class ProductBuilder
{
    public static ProductBuilder Simple()
    {
        return new ProductBuilder()
            .WithName("Test Product")
            .WithPrice(99.99m);
    }

    public static ProductBuilder WithFullDetails()
    {
        return Simple()
            .WithDescription("A test product with full details")
            .WithStockQuantity(100);
    }
}
