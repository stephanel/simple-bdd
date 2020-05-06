using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SimpleBDD.Tests
{
    public class CalculatorAddFeatures
    {
        private readonly IFeature<CalculatorAdd> spec 
            = new Feature<CalculatorAdd>("calculator test");

        [Fact]
        public void Should_Sum_Entered_Values()
        {
            spec
                .Given(new CalculatorAdd())
                .When(enter_3)
                .And(enter_5)
                .And(enter_13)
                .Then(result_should_be_21);
        }

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

        private void result_should_be_21(CalculatorAdd value)
        {
            Assert.Equal(21, value.Add());
        }

        class CalculatorAdd
        {
            List<int> values = new List<int>();

            public void EnterValue(int value)
            {
                values.Add(value);
            }

            public int Add()
            {
                return values.Sum();
            }

        }
    }
}
