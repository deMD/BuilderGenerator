using System;

namespace BuilderGenerator.Tests.Integration.Net80.ProjectRef.Models.Entities;

/// <summary>Represents a product with constructor-required fields.</summary>
public class Product : Entity
{
    /// <summary>Initializes a new instance of the <see cref="Product"/> class.</summary>
    /// <param name="name">The product name.</param>
    /// <param name="price">The product price.</param>
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    /// <summary>Gets or sets the product name.</summary>
    public string Name { get; set; }

    /// <summary>Gets or sets the product price.</summary>
    public decimal Price { get; set; }

    /// <summary>Gets or sets the product description (optional, not in constructor).</summary>
    public string? Description { get; set; }

    /// <summary>Gets or sets the stock quantity (optional, not in constructor).</summary>
    public int StockQuantity { get; set; }
}
