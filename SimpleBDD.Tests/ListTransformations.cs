using System.Collections.Generic;
using Xunit;
using static SimpleBDD.Specification;

namespace SimpleBDD.Tests;

public class ListTransformations
{
    [Fact]
    public void Should_Apply_Transformations_To_List_Values()
        => Given(new List<string>{"abc", "def", "ghi"})
            .When(remove_entry_def)
            .And(add_entry_xyz_at_first_position)
            .Then(list_have_3_entries)
            .And(list_contains_xyz)
            .And(list_contains_ghi)
            .And(xyz_is_first_in_list)
            .And(list_does_not_contain_def)
    ;

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

    private void list_have_3_entries(List<string> value)
        => Assert.Equal(3, value.Count);

    private void list_does_not_contain_def(List<string> value)
        => Assert.DoesNotContain(value, x => x == "def");
        
    private void list_contains_ghi(List<string> value)
        => Assert.Contains(value, x => x == "ghi");
        
    private void list_contains_xyz(List<string> value)
        => Assert.Contains(value, x => x == "xyz");

    private void xyz_is_first_in_list(List<string> value)
        => Assert.Equal("xyz", value[0]);
}