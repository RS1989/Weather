using MD.WeatherConverter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Weather.Tests
{
    public class TemperatureFTests
    {

        [Test]
        [TestCase(123, -238)]       
        public void Convert(double value, double expectedValue)
        {
            var temp = new Converter(new TemperatureF());
            var result = temp.Convert(value);

            Assert.IsTrue(result.Equals(expectedValue), $"return wrong name value");
        }
    }
}
