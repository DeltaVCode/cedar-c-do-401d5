using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace DemoTests
{
    public class IEnumerableGenericTests
    {
        [Fact]
        public void ArrayIsIEnumerable()
        {
            int[] numbers = new[] { 1, 2, 3 };

            ForeachAndAssertNotZero(numbers);

            EnumerateAndAssertNotZero(numbers);
        }

        private void EnumerateAndAssertNotZero(IEnumerable<int> sequence)
        {
            IEnumerator<int> enumerator = sequence.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int number = enumerator.Current;
                Assert.NotEqual(0, number);
            }
        }

        private void ForeachAndAssertNotZero(IEnumerable<int> seq)
        {
            // Cross our fingers that number is actually an int
            foreach (int number in seq)
            {
                Assert.NotEqual(0, number);
            }
        }

        [Fact]
        public void ListIsIEnumerable()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            // numbers.Add("3"); // compiler *can* prevent this
            numbers.Add(4);

            EnumerateAndAssertNotZero(numbers);

            ForeachAndAssertNotZero(numbers);
        }
    }
}
