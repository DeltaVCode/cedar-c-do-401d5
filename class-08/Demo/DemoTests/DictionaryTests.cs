using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoTests
{
    public class DictionaryTests
    {
        [Fact]
        public void Dictionary_works()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Keith", 2);
            dict.Add("Craig", 2);
            dict.Add("Stacey", 2);
            dict["Misti"] = 5;

            Assert.NotEmpty(dict.Values); // 2, 2, 2, 5

            Assert.Equal(
                new[] { "Keith", "Craig", "Stacey", "Misti" },
                dict.Keys);

            // Get a value by key
            Assert.Equal(5, dict["Misti"]);
        }

    }
}
