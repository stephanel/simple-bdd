# Simple BDD
A simple BDD test framework experiment.

We add too much complexity to our tests. They are too often overloaded with overly technical content (mocks, stubs, etc.). The aim of this experiment was to create a fluid API that allows us to write specifications that are easy to read.
To do this, we need to replace complexity with a simple statement that describes the scenario under test without ambiguity of intent.

Many frameworks already exist, but they are often complex and a little cumbersome for what they are trying to solve. They also often require a particular stack, which comes with its share of configuration. This is a simple attempt to create a framework that is easy to use and understand.

### Requirements:
- it should express the intent and clearly document the code.
- it should be easy to use.
- it should be easy to start with.
- it should be just C# code, no additional dependencies.
- it should support any assertion framework.

A simple example of how to use it.

```csharp
using static SimpleBDD.Specification;

Given("abc")
  .When(remove_character_c)
  .And(add_character_f)
  .Then(value_is_equal_to_abf)
  .And(lenght_is_3);
```

A complete example:
```csharp
using Xunit;
using static SimpleBDD.Specification;

public class StringFeatures
{
    [Fact]
    public void Should_Apply_Transformations_To_String_Value() =>
        Given("abc")
            .When(remove_character_c)
            .And(add_character_f)
            .Then(value_is_equal_to_abf)
            .And(lenght_is_3);

    private string remove_character_c(string value) => value.Replace("c", string.Empty);

    private string add_character_f(string value) =>  $"{value}f";

    private void value_is_equal_to_abf(string value) => Assert.Equal("abf", value);

    private void lenght_is_3(string value) =>  Assert.Equal(3, value.Length);
}
```
