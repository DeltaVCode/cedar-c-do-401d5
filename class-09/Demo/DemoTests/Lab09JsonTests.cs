using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoTests
{
    public class Lab09JsonTests
    {
        [Fact]
        public void Can_Read_File()
        {
            string json = File.ReadAllText("data.son");
            Assert.NotEmpty(json);
        }
    }
}
