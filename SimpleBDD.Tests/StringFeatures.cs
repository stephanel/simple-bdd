using Xunit;

namespace SimpleBDD.Tests
{
    public class StringFeatures
    {
        private readonly ISpecification<string> spec 
            = new Specification<string>("string test");

        [Fact]
        public void Should_Apply_Transformations_To_String_Value()
        {
            spec
                .Given("abc")
                .When(remove_character_c)
                .And(add_f)
                .Then(value_should_be_equal_to_ab);
        }

        private string remove_character_c(string value)
        {
            return value.Replace("c", string.Empty);
        }

        private string add_f(string value)
        {
            return $"{value}f";
        }

        private void value_should_be_equal_to_ab(string value)
        {
            Assert.Equal("abf", value);
        }
    }
}
