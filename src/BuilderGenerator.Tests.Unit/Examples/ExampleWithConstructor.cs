using System;

namespace BuilderGenerator.Tests.Unit.Examples;

/// <summary>An example class with constructor parameters.</summary>
public class PersonWithConstructor
{
    /// <summary>Initializes a new instance of the <see cref="PersonWithConstructor"/> class.</summary>
    /// <param name="firstName">The person's first name.</param>
    /// <param name="lastName">The person's last name.</param>
    public PersonWithConstructor(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    /// <summary>The Person's first name.</summary>
    public string FirstName { get; set; }

    /// <summary>The Person's last name.</summary>
    public string LastName { get; set; }

    /// <summary>The Person's age (not in constructor).</summary>
    public int Age { get; set; }

    /// <summary>The Person's email (not in constructor).</summary>
    public string Email { get; set; }
}
