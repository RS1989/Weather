using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.WeatherConverter
{
    public class TemperatureF:Temperature
    {
        public override double GetTemp(double tempK)
        {
            var celsius = tempK - 273;
            return celsius * 18 / 10 + 32;
        }
    }
}
