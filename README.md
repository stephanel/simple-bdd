# Simple BDD
A simple BDD test framework experiment.

We often add some complexity to our tests. The goal of this experiment was to have a fluent API that allows to write easily readable specifications.
For that, we wanted to extract all the complexity from the tests, and to have specifications that expess with no ambiguity the intents.

An example, of the expected result:
```csharp
spec
    .Given("abc")
    .When(remove_character_c)
    .And(add_character_f)
    .Then(value_should_be_equal_to_abf)
    .And(lenght_should_be_3);
```

A complete example:
```csharp
using Xunit;

public class StringFeatures
{
    [Fact]
    public void Should_Apply_Transformations_To_String_Value()
    {
        Specification<string> spec = new Specification<string>();

        spec
            .Given("abc")
            .When(remove_character_c)
            .And(add_character_f)
            .Then(value_should_be_equal_to_abf)
            .And(lenght_should_be_3);
    }

    private string remove_character_c(string value)
    {
        return value.Replace("c", string.Empty);
    }

    private string add_character_f(string value)
    {
        return $"{value}f";
    }

    private void value_should_be_equal_to_abf(string value)
    {
        Assert.Equal("abf", value);
    }

    private void lenght_should_be_3(string value)
    {
        Assert.Equal(3, value.Length);
    }
}
```
