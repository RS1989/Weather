using MD.WeatherConverter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Weather.Tests
{
    public class TemperatureCTests
    {
        [Test]
        [TestCase(123, -150)]      
        public void Convert(double value, double expectedValue)
        {            
            var temp = new Converter(new TemperatureC());
            var result = temp.Convert(value);

            Assert.IsTrue(result.Equals(expectedValue), $"return wrong name value");
        }
    }
}
