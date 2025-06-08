using System.Collections.Generic;
using System.Linq;
using Xunit;
using static SimpleBDD.Specification;

namespace SimpleBDD.Tests;

public class CalculatorAddFeatures
{
    [Fact]
    public void Should_Sum_Entered_Values()
        => Given(new CalculatorAdd())
            .When(enter_3)
            .And(enter_5)
            .And(enter_13)
            .Then(result_is_21);

    private CalculatorAdd enter_3(CalculatorAdd value)
    {
        value.EnterValue(3);
        return value;
    }

    private CalculatorAdd enter_5(CalculatorAdd value)
    {
        value.EnterValue(5);
        return value;
    }

    private CalculatorAdd enter_13(CalculatorAdd value)
    {
        value.EnterValue(13);
        return value;
    }

    private void result_is_21(CalculatorAdd value)
        => Assert.Equal(21, value.Add());

    class CalculatorAdd
    {
        private readonly List<int> _values = [];

        public void EnterValue(int value)
            => _values.Add(value);

        public int Add()
            => _values.Sum();
    }
}