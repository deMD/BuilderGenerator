using System;

namespace BuilderGenerator.Tests.Unit.Examples;

/// <summary>An example class with constructor parameters and read-only properties.</summary>
public class PersonWithReadOnlyConstructor
{
    /// <summary>Initializes a new instance of the <see cref="PersonWithReadOnlyConstructor"/> class.</summary>
    /// <param name="firstName">The person's first name.</param>
    /// <param name="lastName">The person's last name.</param>
    public PersonWithReadOnlyConstructor(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    /// <summary>The Person's first name (read-only).</summary>
    public string FirstName { get; }

    /// <summary>The Person's last name (private setter).</summary>
    public string LastName { get; private set; }

    /// <summary>The Person's age (not in constructor, public setter).</summary>
    public int Age { get; set; }
}
