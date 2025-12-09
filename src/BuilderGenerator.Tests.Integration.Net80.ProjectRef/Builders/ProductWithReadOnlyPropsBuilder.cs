using BuilderGenerator.Tests.Integration.Net80.ProjectRef.Models.Entities;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Builders;

/// <summary>Builder for ProductWithReadOnlyProps with constructor parameters.</summary>
[BuilderFor(typeof(ProductWithReadOnlyProps))]
public partial class ProductWithReadOnlyPropsBuilder
{
    public static ProductWithReadOnlyPropsBuilder Simple()
    {
        return new ProductWithReadOnlyPropsBuilder()
            .WithName("Test Product")
            .WithPrice(99.99m);
    }
}
