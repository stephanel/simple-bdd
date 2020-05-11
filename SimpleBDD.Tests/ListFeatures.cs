using System.Collections.Generic;
using Xunit;

namespace SimpleBDD.Tests
{
    public class ListFeatures
    {
        private readonly ISpecification<List<string>> spec = new Specification<List<string>>();

        [Fact]
        public void Should_Apply_Transformations_To_List_Values()
        {
            spec
                .Given(new List<string>() { "abc", "def", "ghi" })
                .When(remove_entry_def)
                .And(add_entry_xyz_at_first_position)
                .Then(list_should_not_contain_def);
        }

        private List<string> remove_entry_def(List<string> value)
        {
            value.Remove("def");

            return value;
        }

        private List<string> add_entry_xyz_at_first_position(List<string> value)
        {
            value.Insert(0, "xyz");

            return value;
        }

        private void list_should_not_contain_def(List<string> value)
        {
            Assert.Equal(3, value.Count);
            Assert.Collection(value,
                p => Assert.Equal("xyz", p),
                p => Assert.Equal("abc", p),
                p => Assert.Equal("ghi", p)
            );
        }
    }
}
