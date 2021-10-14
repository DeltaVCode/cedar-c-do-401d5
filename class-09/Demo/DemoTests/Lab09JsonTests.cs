using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace DemoTests
{
    public class Lab09JsonTests
    {
        [Fact]
        public void Can_Read_File()
        {
            // Arrange

            // Read the raw JSON data
            string json = File.ReadAllText("data.json");
            Assert.NotEmpty(json);

            // Act

            // Convert to C# object
            // Like JSON.parse()
            RootObject root = JsonConvert.DeserializeObject<RootObject>(json);

            // Assert
            Assert.Equal(147, root.features.Count);


            var startsWith5 = root.features
                .Where(
                    feature =>
                    feature.properties.address.StartsWith("5")
                );

            var count = startsWith5.Count();

            Assert.Equal(6, count);
        }
    }

    class RootObject
    {
        public string type { get; set; }

        public List<Feature> features { get; set; }
    }

    class Feature
    {
        public string type { get; set; }

        public Properties properties { get; set; }
    }

    class Properties
    {
        public string zip { get; set; }
        public string address { get; set; }
    }
}
