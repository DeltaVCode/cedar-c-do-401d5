using System.Collections;
using Xunit;

namespace DemoTests
{
    public class IEnumerableTests
    {
        [Fact]
        public void ArrayIsIEnumerable()
        {
            int[] numbers = new[] { 1, 2, 3 };

            ForeachAndAssertNotZero(numbers);

            EnumerateAndAssertNotZero(numbers);
        }

        private void EnumerateAndAssertNotZero(IEnumerable sequence)
        {
            IEnumerator enumerator = sequence.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object number = enumerator.Current;
                Assert.NotEqual(0, number);
            }
        }

        private void ForeachAndAssertNotZero(IEnumerable seq)
        {
            // Cross our fingers that number is actually an int
            foreach (int number in seq)
            {
                Assert.NotEqual(0, number);
            }
        }

        [Fact]
        public void ArrayListIsIEnumerable()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            //numbers.Add("3"); // compiler can't prevent this
            numbers.Add(4);

            EnumerateAndAssertNotZero(numbers);

            ForeachAndAssertNotZero(numbers);
        }
    }
}
