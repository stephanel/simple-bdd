using Xunit;
using static SimpleBDD.Specification;

namespace SimpleBDD.Tests;

public class StringTransformations
{
    [Fact]
    public void Should_Apply_Transformations_To_String_Value()
        => Given("abc")
            .When(remove_character_c)
            .And(add_character_f)
            .Then(value_is_equal_to_abf)
            .And(lenght_is_3);

    private string remove_character_c(string value)
        => value.Replace("c", string.Empty);

    private string add_character_f(string value)
        => $"{value}f";

    private void value_is_equal_to_abf(string value)
        => Assert.Equal("abf", value);

    private void lenght_is_3(string value)
        => Assert.Equal(3, value.Length);
}