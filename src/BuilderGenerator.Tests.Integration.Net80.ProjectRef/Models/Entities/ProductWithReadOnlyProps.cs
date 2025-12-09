using System;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Models.Entities;

/// <summary>Represents a product with constructor-required fields and read-only properties.</summary>
public class ProductWithReadOnlyProps : Entity
{
    /// <summary>Initializes a new instance of the <see cref="ProductWithReadOnlyProps"/> class.</summary>
    /// <param name="name">The product name.</param>
    /// <param name="price">The product price.</param>
    public ProductWithReadOnlyProps(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    /// <summary>Gets the product name (read-only).</summary>
    public string Name { get; }

    /// <summary>Gets or privately sets the product price.</summary>
    public decimal Price { get; private set; }

    /// <summary>Gets or sets the product description (optional, init-only).</summary>
    public string? Description { get; init; }

    /// <summary>Gets or sets the stock quantity (optional, init-only).</summary>
    public int StockQuantity { get; init; }
}
